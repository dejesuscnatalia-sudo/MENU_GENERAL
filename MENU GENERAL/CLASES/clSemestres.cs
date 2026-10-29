using System;

namespace MENU_GENERAL.CLASES
{
    internal class clSemestres : ICatalogo
    {
        private int id_semestre;
        private string nombre;

        public clSemestres() { }
        public clSemestres(int id) { id_semestre = id; }
        public clSemestres(int id, string nombre)
        {
            id_semestre = id;
            this.nombre = nombre;
        }

        public string Guardar()
        {
            return "Insert into Tbl_Semestres (Id_Semestre, Nombre_Semestre) Values (" + id_semestre +
                   ", '" + Global.Esc(nombre) + "')";
        }
        public string Modificar()
        {
            return "Update Tbl_Semestres set Nombre_Semestre='" + Global.Esc(nombre) +
                   "' where Id_Semestre=" + id_semestre;
        }
        public string Buscar()
        {
            return "Select * from Tbl_Semestres where Id_Semestre=" + id_semestre;
        }
        public string Existe() { return Buscar(); }
        public string Eliminar()
        {
            return "delete from Tbl_Semestres where Id_Semestre=" + id_semestre;
        }
        public string consultageneral()
        {
            return "select * from Tbl_Semestres order by Id_Semestre";
        }
    }
}
