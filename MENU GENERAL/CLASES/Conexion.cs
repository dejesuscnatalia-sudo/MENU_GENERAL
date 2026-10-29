using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MENU_GENERAL.CLASES
{
    internal class Conexion
    {
        private string sentencia1;

        public Conexion() { }

        public Conexion(string sentencia)
        {
            sentencia1 = sentencia;
        }

        // INSERT, UPDATE, DELETE
        public string EJECUTAR()
        {
            using (SqlConnection cn = new SqlConnection(Global.miconexion))
            using (SqlCommand cmd = new SqlCommand(sentencia1, cn))
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            return "Operación exitosa";
        }

        // SELECT: devuelve un DataSet con la tabla llamada "Tabla"
        public DataSet CONSULTAR()
        {
            DataSet datos = new DataSet();
            using (SqlConnection cn = new SqlConnection(Global.miconexion))
            using (SqlDataAdapter da = new SqlDataAdapter(sentencia1, cn))
            {
                da.Fill(datos, "Tabla");
            }
            return datos;
        }

        public static string Esc(string s)
        {
            return (s ?? "").Replace("'", "''");
        }

        // Llena un combo con la sentencia del constructor
        // valor = columna llave, texto = columna que se ve
        public void LlenarCombo(ComboBox cmb, string valor, string texto)
        {
            DataSet ds = CONSULTAR();
            cmb.DataSource = null;
            cmb.Items.Clear();
            cmb.DisplayMember = texto;
            cmb.ValueMember = valor;
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb.DataSource = ds.Tables["Tabla"];
            cmb.SelectedIndex = -1;
        }
    }
}
