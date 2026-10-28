using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENU_GENERAL.CLASES
{
    internal class clCarreras
    {

        private int num_carrera;
        private string carrera;

        public clCarreras() { } //meterle constructores en blanco
        public clCarreras(int num_carrera) {
            this.num_carrera = num_carrera;
        }
        public clCarreras(int num_carrera, string carrera)
        {
            this.num_carrera = num_carrera;
            this.carrera = carrera;
        }
        public string Guardar()
        {
            return "Insert into tbl_Carreras Values (" + num_carrera + ", '" + carrera + "')";
        }
        public string Modificar()
        {
            return $"Update tbl_Carreras set carrera='{carrera}' where idCarrera={num_carrera}";
        }
        public string Buscar()
        {
            return "Select * from tbl_Carreras where idCarrera= " + num_carrera;
        }
        public string Eliminar()
        {
            return $"delete from tbl_Carreras where idCarrera = {num_carrera}";
        }

        public string consultageneral()//esto en poco datos. De cientos de miles, abrir búsqueda en una ventana
        {
            return "select * from tbl_Carreras";
        }
    }
}
