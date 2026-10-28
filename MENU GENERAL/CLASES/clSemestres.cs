using System;

namespace MENU_GENERAL.CLASES
{
    // Semestre 1 ---- N Alumnos
    internal class clSemestres
    {
        private int id_semestre;
        private string nombre;

        public clSemestres() { }
        public clSemestres(int id)
        {
            id_semestre = id;
        }
        public clSemestres(int id, string nombre)
        {
            id_semestre = id;
            this.nombre = nombre;
        }

        public string Guardar()
        {
            return "Insert into Tbl_Semestres (Id_Semestre, Nombre_semestre) Values (" + id_semestre +
                   ", '" + Global.Esc(nombre) + "')";
        }
        public string Modificar()
        {
            return "Update Tbl_Semestres set Nombre_semestre='" + Global.Esc(nombre) + "' where Id_Semestre=" + id_semestre;
        }
        public string Buscar()
        {
            return "Select * from Tbl_Semestres where Id_Semestre=" + id_semestre;
        }
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
