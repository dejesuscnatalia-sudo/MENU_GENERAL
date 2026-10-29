using System;

namespace MENU_GENERAL.CLASES
{
    internal class clUnidAcad : ICatalogo
    {
        private int id_unidad;
        private string nombre;
        private int id_municipio;

        public clUnidAcad() { }
        public clUnidAcad(int id) { id_unidad = id; }
        public clUnidAcad(int id, string nombre, int idMunicipio)
        {
            id_unidad = id;
            this.nombre = nombre;
            id_municipio = idMunicipio;
        }

        public string Guardar()
        {
            return "Insert into Tbl_Unidades_Academicas (Id_Unid_Acad, Nombre_unidad, id_Municipio) Values (" +
                   id_unidad + ", '" + Global.Esc(nombre) + "', " + id_municipio + ")";
        }
        public string Modificar()
        {
            return "Update Tbl_Unidades_Academicas set Nombre_unidad='" + Global.Esc(nombre) +
                   "', id_Municipio=" + id_municipio + " where Id_Unid_Acad=" + id_unidad;
        }
        public string Buscar()
        {
            return "Select * from Tbl_Unidades_Academicas where Id_Unid_Acad=" + id_unidad;
        }
        public string Existe() { return Buscar(); }
        public string Eliminar()
        {
            return "delete from Tbl_Unidades_Academicas where Id_Unid_Acad=" + id_unidad;
        }
        public string consultageneral()
        {
            return "select * from Tbl_Unidades_Academicas order by Nombre_unidad";
        }
        public string consultaMunicipios()
        {
            return "select Id_Municipio, Nombre_municipio from Tbl_Municipios order by Nombre_municipio";
        }
    }
}