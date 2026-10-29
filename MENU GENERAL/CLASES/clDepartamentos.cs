using System;

namespace MENU_GENERAL.CLASES
{
    internal class clDepartamentos : ICatalogo
    {
        private int id_departamento;
        private string nombre;
        private int id_unidad;

        public clDepartamentos() { }
        public clDepartamentos(int id) { id_departamento = id; }
        public clDepartamentos(int id, string nombre, int idUnidad)
        {
            id_departamento = id;
            this.nombre = nombre;
            id_unidad = idUnidad;
        }

        public string Guardar()
        {
            return "Insert into tbl_Departamentos (Id_Departamento, Nombre_Departamento, Id_Unid_Acad) Values (" +
                   id_departamento + ", '" + Global.Esc(nombre) + "', " + id_unidad + ")";
        }
        public string Modificar()
        {
            return "Update tbl_Departamentos set Nombre_Departamento='" + Global.Esc(nombre) +
                   "', Id_Unid_Acad=" + id_unidad + " where Id_Departamento=" + id_departamento;
        }
        public string Buscar()
        {
            return "Select * from tbl_Departamentos where Id_Departamento=" + id_departamento;
        }
        public string Existe() { return Buscar(); }
        public string Eliminar()
        {
            return "delete from tbl_Departamentos where Id_Departamento=" + id_departamento;
        }
        public string consultageneral()
        {
            return "select * from tbl_Departamentos order by Nombre_Departamento";
        }
    }
}