using System;

namespace MENU_GENERAL.CLASES
{
    // Unidad Académica 1 ---- N Departamentos  |  Departamento 1 ---- N Carreras
    internal class clDepartamentos
    {
        private int id_departamento;
        private string nombre;
        

        public clDepartamentos() { }
        public clDepartamentos(int id)
        {
            id_departamento = id;
        }
        public clDepartamentos(int id, string nombre, )
        {
            id_departamento = id;
            this.nombre = nombre;
        }

        public string Guardar()
        {
            return "Insert into tbl_Departamentos (Id_Departamento, Nombre_departamento, Id_Unidad) Values (" +
                   id_departamento + ", '" + Global.Esc(nombre) + "')";
        }
        public string Modificar()
        {
            return "Update tbl_Departamentos set Nombre_departamento='" + Global.Esc(nombre) +
                   " where Id_Departamento=" + id_departamento;
        }
        public string Buscar()
        {
            return "Select * from tbl_Departamentos where Id_Departamento=" + id_departamento;
        }
        public string Eliminar()
        {
            return "delete from tbl_Departamentos where Id_Departamento=" + id_departamento;
        }
        public string consultageneral()
        {
            return "select * from tbl_Departamentos order by Nombre_departamento";
        }
    }
}
