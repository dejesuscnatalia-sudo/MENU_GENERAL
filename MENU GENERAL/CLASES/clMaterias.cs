using System;

namespace MENU_GENERAL.CLASES
{
    internal class clMaterias
    {
        public int id_materia { get; set; }
        public string Nombre { get; set; }

        public clMaterias()
        {
            id_materia = 0;
            Nombre = "";
        }
        public clMaterias(int clave, string nombre)
        {
            this.id_materia = clave;
            this.Nombre = nombre;
        }
        public clMaterias(int clave) { this.id_materia = clave; }

        public string Guardar()
        {
            return "Insert into tbl_Materias (Id_Materia, nombre) Values (" + id_materia + ", '" + Global.Esc(Nombre) + "')";
        }
        public string Modificar()
        {
            return "Update tbl_Materias set nombre='" + Global.Esc(Nombre) + "' where Id_Materia=" + id_materia;
        }
        public string Buscar()
        {
            return "Select * from tbl_Materias where Id_Materia=" + id_materia;
        }
        public string Eliminar()
        {
            return "delete from tbl_Materias where Id_Materia=" + id_materia;
        }
    }
}