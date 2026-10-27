using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENU_GENERAL.CLASES
{
    internal class clTurno
    {
        private int num_turno;
        private string Nombre_turno;

        public clTurno() { } //meterle constructores en blanco
        public clTurno(int num_turno)
        {
            this.num_turno = num_turno;
        }
        public clTurno(int num_turno, string Nombre_turno)
        {
            this.num_turno = num_turno;
            this.Nombre_turno = Nombre_turno;
        }
        public string Guardar()
        {
            return "Insert into Tbl_Turno Values (" + num_turno + ", '" + Nombre_turno + "')";
        }
        public string Modificar()
        {
            return $"Update Tbl_Turno set Nombre_turno='{Nombre_turno}' where Id_Turno={num_turno}";
        }
        public string Buscar()
        {
            return "Select * from Tbl_Turno where Id_Turno= " + num_turno;
        }
        public string Eliminar()
        {
            return $"Update Tbl_Turno set Estado=0 where Id_Turno={num_turno}";
        }

        public string consultageneral()//esto en poco datos. De cientos de miles, abrir búsqueda en una ventana
        {
            return "select * from Tbl_Turno";
        }
    }
}
