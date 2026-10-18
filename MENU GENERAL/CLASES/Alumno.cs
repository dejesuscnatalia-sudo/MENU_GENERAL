using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENU_GENERAL
{
    internal class Alumno
    {
        private string _matricula;
        private string _nombre;
        private byte _carrera;
        private string _telefono;
        private string _correo;

        //private byte carrera
        //y en explorer

        public Alumno(string mat, string nom, byte carr)
        {
            this._matricula= mat;//como hacias para cambiar name de variable?
            this._nombre= nom;
            this._carrera= carr;
        }

        public void GuardarEnArreglo(Alumno[] array, int indice)
        {
            array[indice] = this;
        }
        public string ObtenerDatos()
        {
            return $"{_matricula} - {_nombre} -{_carrera}";
        }
    }
}

