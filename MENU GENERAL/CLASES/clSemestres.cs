using MENU_GENERAL.ESCOLAR.MENU_GENERAL.CLASES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENU_GENERAL.CLASES
{
    internal class clSemestre : ICatalogo
    {
        private int idSemestre;
        private string semestre;

        public clSemestre(int idSemestre, string semestre)
        {
            this.idSemestre = idSemestre;
            this.semestre = semestre;
        }
        public string Guardar()
        {
            return "Insert into tbl_Semestres (idSemestre, semestre) Values (" + idSemestre + ", '" + Conexion.Esc(semestre) + "')";
        }
        public string Modificar()
        {
            return "Update tbl_Semestres set semestre='" + Conexion.Esc(semestre) + "' where idSemestre=" + idSemestre;
        }
        public string Buscar()
        {
            return "Select * from tbl_Semestres where idSemestre = " + idSemestre;
        }
        public string Eliminar()
        {
            return "delete from tbl_Semestres where idSemestre = " + idSemestre;
        }
    }
}