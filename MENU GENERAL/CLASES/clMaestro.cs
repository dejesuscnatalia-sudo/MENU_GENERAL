using System;

namespace MENU_GENERAL.CLASES
{
    // Carrera 1 ---- N Maestros
    internal class clMaestro
    {
        private int num_Empleado;
        private string nombre;
        private string telefono;
        private string correo;
        private int carreras;

        public clMaestro(int numEmp, string _nombre, string telefono, string correo, int carreras)
        {
            this.num_Empleado = numEmp;
            this.nombre = _nombre;
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
            return "Insert into tbl_Registro_Maestros (num_Empleado, nombre, correo, telefono, idCarrera) Values (" +
                   num_Empleado + ", '" + Global.Esc(nombre) + "', '" + Global.Esc(correo) + "', '" +
                   Global.Esc(telefono) + "', " + carreras + ")";
        }
        public string Modificar()
        {
            return "Update tbl_Registro_Maestros set nombre='" + Global.Esc(nombre) + "', correo='" +
                   Global.Esc(correo) + "', telefono='" + Global.Esc(telefono) + "', idCarrera=" + carreras +
                   " where num_Empleado=" + num_Empleado;
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
