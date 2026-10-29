using System;

namespace MENU_GENERAL.CLASES
{
    internal class Alumno
    {
        private string _matricula;
        private string _nombre;
        private int _carrera;
        private string _telefono;
        private string _correo;

        public Alumno() { }
        public Alumno(string matricula) { _matricula = matricula; }
        public Alumno(string matricula, string nombre, int carrera, string telefono, string correo)
        {
            _matricula = matricula;
            _nombre = nombre;
            _carrera = carrera;
            _telefono = telefono;
            _correo = correo;
        }

        public string Guardar()
        {
            return "Insert into TBL_Registro_Alumnos (matricula, nombre, carrera, telefono, correo) Values ('" +
                   Global.Esc(_matricula) + "', '" + Global.Esc(_nombre) + "', '" + _carrera + "', '" +
                   Global.Esc(_telefono) + "', '" + Global.Esc(_correo) + "')";
        }
        public string Modificar()
        {
            return "Update TBL_Registro_Alumnos set nombre='" + Global.Esc(_nombre) + "', carrera='" + _carrera +
                   "', telefono='" + Global.Esc(_telefono) + "', correo='" + Global.Esc(_correo) +
                   "' where matricula='" + Global.Esc(_matricula) + "'";
        }
        public string Buscar()
        {
            return "Select * from TBL_Registro_Alumnos where matricula='" + Global.Esc(_matricula) + "'";
        }
        public string Eliminar()
        {
            return "delete from TBL_Registro_Alumnos where matricula='" + Global.Esc(_matricula) + "'";
        }
        public string ConsultaGeneral()
        {
            return "select * from TBL_Registro_Alumnos order by nombre";
        }

        // Para el historial (ListBox) y el arreglo de la captura
        public string ObtenerDatos(string carrera)
        {
            return _matricula + " - " + _nombre + " - " + carrera;
        }
        public void GuardarEnArreglo(Alumno[] arr, int pos)
        {
            arr[pos] = this;
        }
    }
}