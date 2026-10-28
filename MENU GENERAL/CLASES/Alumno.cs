using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MENU_GENERAL.CLASES;

namespace MENU_GENERAL
{
    internal class Alumno
    {
        private string _matricula;
        private string _nombre;
        private int _idCarrera;
        private string _telefono;
        private string _correo;

        public Alumno(string mat)
        {
            _matricula = mat;
        }

        public Alumno(string mat, string nom, int idCarrera, string tel, string correo)
        {
            _matricula = mat;
            _nombre = nom;
            _idCarrera = idCarrera;
            _telefono = tel;
            _correo = correo;
        }

        public string Guardar()
        {
            return "Insert into tbl_Alumnos (matricula, nombre, idCarrera, correo, telefono) Values ('"
                + Conexion.Esc(_matricula) + "', '" + Conexion.Esc(_nombre) + "', " + _idCarrera + ", '"
                + Conexion.Esc(_correo) + "', '" + Conexion.Esc(_telefono) + "')";
        }
        public string Modificar()
        {
            return "Update tbl_Alumnos set nombre='" + Conexion.Esc(_nombre) + "', idCarrera=" + _idCarrera
                + ", correo='" + Conexion.Esc(_correo) + "', telefono='" + Conexion.Esc(_telefono)
                + "' where matricula='" + Conexion.Esc(_matricula) + "'";
        }
        public string Buscar()
        {
            return "Select * from tbl_Alumnos where matricula='" + Conexion.Esc(_matricula) + "'";
        }
        public string Eliminar()
        {
            return "delete from tbl_Alumnos where matricula='" + Conexion.Esc(_matricula) + "'";
        }

        public void GuardarEnArreglo(Alumno[] array, int indice)
        {
            array[indice] = this;
        }
        public string ObtenerDatos(string carrera)
        {
            return $"{_matricula} - {_nombre} - {carrera} - {_correo} - {_telefono}";
        }
    }
}