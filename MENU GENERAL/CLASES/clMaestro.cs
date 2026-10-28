using System;

namespace MENU_GENERAL.CLASES
{
    internal class clMaestro
    {
        private int num_Empleado;
        private string nombre;
        private string telefono;
        private string correo;
        private int carreras;

        public clMaestro(int numEmp, string nombre, string telefono, string correo, int carreras)
        {
            this.num_Empleado = numEmp;
            this.nombre = nombre;
            this.telefono = telefono;
            this.correo = correo;
            this.carreras = carreras;
        }
        public clMaestro(int numEmp)
        {
            num_Empleado = numEmp;
        }

        public string Guardar()
        {
            return "Insert into tbl_Registro_Maestros (num_Empleado, nombre, correo, telefono, idCarrera) Values ("
                + num_Empleado + ", '" + Conexion.Esc(nombre) + "', '" + Conexion.Esc(correo) + "', '"
                + Conexion.Esc(telefono) + "', " + carreras + ")";
        }
        public string Modificar()
        {
            return "Update tbl_Registro_Maestros set nombre='" + Conexion.Esc(nombre) + "', correo='" + Conexion.Esc(correo)
                + "', telefono='" + Conexion.Esc(telefono) + "', idCarrera=" + carreras
                + " where num_Empleado=" + num_Empleado;
        }
        public string Buscar()
        {
            return "Select * from tbl_Registro_Maestros where num_Empleado = " + num_Empleado;
        }
        public string Eliminar()
        {
            return "delete from tbl_Registro_Maestros where num_Empleado = " + num_Empleado;
        }
    }
}
