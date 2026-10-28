using MENU_GENERAL.ESCOLAR.MENU_GENERAL.CLASES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENU_GENERAL.CLASES
{
    internal class clUnidadAcademica : ICatalogo
    {
        private int idUnidad;
        private string unidad;

        public clUnidadAcademica(int idUnidad, string unidad)
        {
            this.idUnidad = idUnidad;
            this.unidad = unidad;
        }
        public string Guardar()
        {
            return "Insert into tbl_Unidades_Academicas (idUnidad, unidad) Values (" + idUnidad + ", '" + Conexion.Esc(unidad) + "')";
        }
        public string Modificar()
        {
            return "Update tbl_Unidades_Academicas set unidad='" + Conexion.Esc(unidad) + "' where idUnidad=" + idUnidad;
        }
        public string Buscar()
        {
            return "Select * from tbl_Unidades_Academicas where idUnidad = " + idUnidad;
        }
        public string Eliminar()
        {
            return "delete from tbl_Unidades_Academicas where idUnidad = " + idUnidad;
        }
    }
}