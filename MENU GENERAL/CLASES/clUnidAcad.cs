using System;

namespace MENU_GENERAL.CLASES
{
    // Municipio 1 ---- N Unidades Académicas  |  Unidad 1 ---- N Departamentos
    internal class clUnidAcad
    {
        private int id_unidad;
        private string nombre;
        private int id_municipio;

        public clUnidAcad() { }
        public clUnidAcad(int id)
        {
            id_unidad = id;
        }
        public clUnidAcad(int id, string nombre, int idMunicipio)
        {
            id_unidad = id;
            this.nombre = nombre;
            id_municipio = idMunicipio;
        }

        public string Guardar()
        {
            return "Insert into tbl_Unidades_Academicas (Id_Unidad, Nombre_unidad, Id_Municipio) Values (" +
                   id_unidad + ", '" + Global.Esc(nombre) + "', " + id_municipio + ")";
        }
        public string Modificar()
        {
            return "Update tbl_Unidades_Academicas set Nombre_unidad='" + Global.Esc(nombre) +
                   "', Id_Municipio=" + id_municipio + " where Id_Unidad=" + id_unidad;
        }
        public string Buscar()
        {
            return "Select * from tbl_Unidades_Academicas where Id_Unidad=" + id_unidad;
        }
        public string Eliminar()
        {
            return "delete from tbl_Unidades_Academicas where Id_Unidad=" + id_unidad;
        }
        public string consultageneral()
        {
            return "select * from tbl_Unidades_Academicas order by Nombre_unidad";
        }
        public string consultaMunicipios()
        {
            return "select * from tbl_Municipios order by Nombre_municipio";
        }
    }
}
