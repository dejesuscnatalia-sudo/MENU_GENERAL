using System;

namespace MENU_GENERAL.CLASES
{
    // Departamento 1 ---- N Carreras
    internal class clCarreras
    {
        private int num_carrera;
        private string carrera;
        private int id_departamento;

        public clCarreras() { }
        public clCarreras(int num_carrera)
        {
            this.num_carrera = num_carrera;
        }
        public clCarreras(int num_carrera, string carrera, int id_departamento)
        {
            this.num_carrera = num_carrera;
            this.carrera = carrera;
            this.id_departamento = id_departamento;
        }

        public string Guardar()
        {
            return "Insert into tbl_Carreras (idCarrera, carrera, Id_Departamento) Values (" +
                   num_carrera + ", '" + Global.Esc(carrera) + "', " + id_departamento + ")";
        }
        public string Modificar()
        {
            return "Update tbl_Carreras set carrera='" + Global.Esc(carrera) + "', Id_Departamento=" +
                   id_departamento + " where idCarrera=" + num_carrera;
        }
        public string Buscar()
        {
            return "Select * from tbl_Carreras where idCarrera = " + num_carrera;
        }
        public string Eliminar()
        {
            return "delete from tbl_Carreras where idCarrera = " + num_carrera;
        }
        public string consultageneral()
        {
            return "select * from tbl_Carreras order by carrera";
        }
    }
}
