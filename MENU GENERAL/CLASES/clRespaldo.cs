using System;
using System.Data.SqlClient;

namespace MENU_GENERAL.CLASES
{
    /// <summary>
    /// Encapsula las operaciones de respaldo completo y restauración
    /// del último respaldo de una base de datos de SQL Server.
    /// NOTA: las rutas son rutas del SERVIDOR SQL, no de la PC cliente.
    /// </summary>
    internal class clRespaldo
    {
        //PROPIEDADES
        private readonly string _baseDatos;
        private string _carpeta;

        public string BaseDatos
        {
            get { return _baseDatos; }
        }

        public string Carpeta
        {
            get { return _carpeta; }
            set { _carpeta = value; }
        }

        //CONSTRUCTOR
        public clRespaldo(string baseDatos, string carpeta)
        {
            if (string.IsNullOrWhiteSpace(baseDatos))
                throw new ArgumentException("Debe indicar el nombre de la base de datos.");

            this._baseDatos = baseDatos;
            this._carpeta = carpeta;
        }

        //MÉTODOS PRIVADOS (apoyo)

        // Nombre de la BD entre corchetes para usarlo de forma segura en T-SQL
        private string NombreSeguro
        {
            get { return "[" + _baseDatos.Replace("]", "]]") + "]"; }
        }

        // Se conecta a master (necesario para restaurar), reutilizando Global.miconexion
        private SqlConnection CrearConexionMaster()
        {
            SqlConnectionStringBuilder cb = new SqlConnectionStringBuilder(Global.miconexion);
            cb.InitialCatalog = "master";
            return new SqlConnection(cb.ConnectionString);
        }

        private void Ejecutar(SqlConnection cn, string sql, string ruta = null, string nombre = null)
        {
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.CommandTimeout = 0; // respaldos grandes pueden tardar
                if (ruta != null) cmd.Parameters.AddWithValue("@ruta", ruta);
                if (nombre != null) cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.ExecuteNonQuery();
            }
        }

        private bool ArchivoExiste(SqlConnection cn, string ruta)
        {
            using (SqlCommand cmd = new SqlCommand("EXEC master.dbo.xp_fileexist @ruta", cn))
            {
                cmd.Parameters.AddWithValue("@ruta", ruta);
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    return rd.Read() && rd.GetInt32(0) == 1;
                }
            }
        }

        //MÉTODOS PÚBLICOS

        /// <summary>
        /// Crea un respaldo FULL con nombre BD_yyyyMMdd_HHmmss.bak y lo verifica.
        /// </summary>
        public clInfoRespaldo RespaldarCompleto()
        {
            if (string.IsNullOrWhiteSpace(_carpeta))
                throw new InvalidOperationException("Debe indicar la carpeta de respaldos.");

            string carpeta = _carpeta.Trim().TrimEnd('\\', '/');
            DateTime ahora = DateTime.Now;
            string ruta = carpeta + "\\" + _baseDatos + "_" + ahora.ToString("yyyyMMdd_HHmmss") + ".bak";

            using (SqlConnection cn = CrearConexionMaster())
            {
                cn.Open();

                // Crea la carpeta en el servidor si no existe
                using (SqlCommand cmd = new SqlCommand("EXEC master.dbo.xp_create_subdir @carpeta", cn))
                {
                    cmd.Parameters.AddWithValue("@carpeta", carpeta);
                    cmd.ExecuteNonQuery();
                }

                Ejecutar(cn,
                    "BACKUP DATABASE " + NombreSeguro +
                    " TO DISK = @ruta WITH INIT, CHECKSUM, NAME = @nombre",
                    ruta, "Respaldo completo " + _baseDatos);

                // Verifica que el respaldo sea legible
                Ejecutar(cn, "RESTORE VERIFYONLY FROM DISK = @ruta WITH CHECKSUM", ruta);
            }

            return ObtenerUltimoRespaldo();
        }

        /// <summary>
        /// Consulta el historial de msdb y devuelve el último respaldo FULL
        /// de la base de datos, o null si no existe ninguno.
        /// </summary>
        public clInfoRespaldo ObtenerUltimoRespaldo()
        {
            const string sql =
                "SELECT TOP 1 bmf.physical_device_name, bs.backup_finish_date, bs.backup_size " +
                "FROM msdb.dbo.backupset bs " +
                "INNER JOIN msdb.dbo.backupmediafamily bmf ON bs.media_set_id = bmf.media_set_id " +
                "WHERE bs.database_name = @bd AND bs.type = 'D' " +
                "ORDER BY bs.backup_finish_date DESC";

            using (SqlConnection cn = CrearConexionMaster())
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@bd", _baseDatos);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (!rd.Read()) return null;

                        return new clInfoRespaldo(
                            rd.GetString(0),
                            rd.GetDateTime(1),
                            Convert.ToDouble(rd.GetDecimal(2)) / (1024 * 1024));
                    }
                }
            }
        }

        /// <summary>
        /// Restaura el último respaldo FULL sobre la base de datos (la reemplaza).
        /// </summary>
        public clInfoRespaldo RestaurarUltimo()
        {
            clInfoRespaldo ultimo = ObtenerUltimoRespaldo();
            if (ultimo == null)
                throw new InvalidOperationException(
                    "No existe ningún respaldo completo registrado para " + _baseDatos + ".");

            using (SqlConnection cn = CrearConexionMaster())
            {
                cn.Open();

                if (!ArchivoExiste(cn, ultimo.Ruta))
                    throw new InvalidOperationException(
                        "El archivo del último respaldo ya no existe en el servidor:\n" + ultimo.Ruta);

                bool modoUnUsuario = false;
                try
                {
                    // Cierra conexiones abiertas para poder reemplazar la BD
                    Ejecutar(cn, "ALTER DATABASE " + NombreSeguro +
                                 " SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    modoUnUsuario = true;

                    Ejecutar(cn, "RESTORE DATABASE " + NombreSeguro +
                                 " FROM DISK = @ruta WITH REPLACE, RECOVERY", ultimo.Ruta);
                }
                finally
                {
                    // Siempre intenta dejar la BD disponible para todos los usuarios
                    if (modoUnUsuario)
                    {
                        try { Ejecutar(cn, "ALTER DATABASE " + NombreSeguro + " SET MULTI_USER"); }
                        catch { /* si falla, el error original es el importante */ }
                    }
                }
            }

            // Descarta conexiones del pool que quedaron apuntando a la BD anterior
            SqlConnection.ClearAllPools();
            return ultimo;
        }
    }
}
