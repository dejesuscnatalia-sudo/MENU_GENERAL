using System;

namespace MENU_GENERAL.CLASES
{
    internal class clAsignacionMaestroMateria
    {
        private int id_asignacion;
        private int num_empleado;
        private int id_materia;
        private string grupo;
        private string salon;
        private DateTime fecha_asig;
        private DateTime? fecha_fin;
        private DateTime fecha_movimiento;
        private string estado;

        // Constructor para crear una nueva asignación
        public clAsignacionMaestroMateria(int idAsignacion, int numEmp, int idMat, string gr, string sal, 
                                         DateTime fechaAsig, DateTime? fechaFin, string est)
        {
            this.id_asignacion = idAsignacion;
            this.num_empleado = numEmp;
            this.id_materia = idMat;
            this.grupo = gr;
            this.salon = sal;
            this.fecha_asig = fechaAsig;
            this.fecha_fin = fechaFin;
            this.fecha_movimiento = DateTime.Now;
            this.estado = est;
        }

        // Constructor para búsqueda por ID
        public clAsignacionMaestroMateria(int idAsignacion) 
        { 
            id_asignacion = idAsignacion; 
        }

        // Propiedades
        public int Id_Asignacion
        {
            get { return id_asignacion; }
            set { id_asignacion = value; }
        }

        public int Num_Empleado
        {
            get { return num_empleado; }
            set { num_empleado = value; }
        }

        public int Id_Materia
        {
            get { return id_materia; }
            set { id_materia = value; }
        }

        public string Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }

        public string Salon
        {
            get { return salon; }
            set { salon = value; }
        }

        public DateTime Fecha_Asig
        {
            get { return fecha_asig; }
            set { fecha_asig = value; }
        }

        public DateTime? Fecha_Fin
        {
            get { return fecha_fin; }
            set { fecha_fin = value; }
        }

        public DateTime Fecha_Movimiento
        {
            get { return fecha_movimiento; }
            set { fecha_movimiento = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        // Método para guardar una nueva asignación
        public string Guardar()
        {
            string fechaFinSQL = fecha_fin.HasValue ? "'" + fecha_fin.Value.ToString("yyyy-MM-dd") + "'" : "NULL";

            return "Insert into TBL_Asignacion_Maestro_Materia (num_empleado, id_materia, grupo, salon, " +
                   "fecha_asig, fecha_fin, fecha_movimiento, estado) Values (" +
                   num_empleado + ", " + id_materia + ", '" + Global.Esc(grupo) + "', '" + 
                   Global.Esc(salon) + "', '" + fecha_asig.ToString("yyyy-MM-dd") + "', " +
                   fechaFinSQL + ", GETDATE(), '" + Global.Esc(estado) + "')";
        }

        // Método para modificar una asignación existente
        public string Modificar()
        {
            string fechaFinSQL = fecha_fin.HasValue ? "'" + fecha_fin.Value.ToString("yyyy-MM-dd") + "'" : "NULL";

            return "Update TBL_Asignacion_Maestro_Materia set num_empleado=" + num_empleado + 
                   ", id_materia=" + id_materia + ", grupo='" + Global.Esc(grupo) + 
                   "', salon='" + Global.Esc(salon) + "', fecha_asig='" + 
                   fecha_asig.ToString("yyyy-MM-dd") + "', fecha_fin=" + fechaFinSQL + 
                   ", fecha_movimiento=GETDATE(), estado='" + Global.Esc(estado) + 
                   "' where id_asignacion=" + id_asignacion;
        }

        // Método para buscar una asignación por ID
        public string Buscar()
        {
            return "Select * from TBL_Asignacion_Maestro_Materia where id_asignacion = " + id_asignacion;
        }

        // Método para buscar asignaciones por número de empleado
        public string BuscarPorMaestro()
        {
            return "Select a.*, m.nombre as nombre_maestro, mat.nombre as nombre_materia " +
                   "from TBL_Asignacion_Maestro_Materia a " +
                   "join TBL_Registro_Maestros m on a.num_empleado = m.num_Empleado " +
                   "join tbl_Materias mat on a.id_materia = mat.Id_Materia " +
                   "where a.num_empleado = " + num_empleado;
        }

        // Método para buscar asignaciones por materia
        public string BuscarPorMateria()
        {
            return "Select a.*, m.nombre as nombre_maestro, mat.nombre as nombre_materia " +
                   "from TBL_Asignacion_Maestro_Materia a " +
                   "join TBL_Registro_Maestros m on a.num_empleado = m.num_Empleado " +
                   "join tbl_Materias mat on a.id_materia = mat.Id_Materia " +
                   "where a.id_materia = " + id_materia;
        }

        // Método para buscar todas las asignaciones activas
        public string BuscarActivas()
        {
            return "Select a.*, m.nombre as nombre_maestro, mat.nombre as nombre_materia " +
                   "from TBL_Asignacion_Maestro_Materia a " +
                   "join TBL_Registro_Maestros m on a.num_empleado = m.num_Empleado " +
                   "join tbl_Materias mat on a.id_materia = mat.Id_Materia " +
                   "where a.estado = 'activo' order by a.fecha_asig desc";
        }

        // Método para eliminar una asignación
        public string Eliminar()
        {
            return "delete from TBL_Asignacion_Maestro_Materia where id_asignacion = " + id_asignacion;
        }

        // Método para cambiar el estado
        public string CambiarEstado(string nuevoEstado)
        {
            return "Update TBL_Asignacion_Maestro_Materia set estado='" + Global.Esc(nuevoEstado) + 
                   "', fecha_movimiento=GETDATE() where id_asignacion=" + id_asignacion;
        }
    }
}
