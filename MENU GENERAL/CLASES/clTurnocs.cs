using MENU_GENERAL.ESCOLAR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENU_GENERAL.CLASES
{
    internal class clTurno : ICatalogo
    {
        private int idTurno;
        private string turno;

        public clTurno(int idTurno, string turno)
        {
            this.idTurno = idTurno;
            this.turno = turno;
        }
        public string Guardar()
        {
            return "Insert into tbl_Turnos (idTurno, turno) Values (" + idTurno + ", '" + Conexion.Esc(turno) + "')";
        }
        public string Modificar()
        {
            return "Update tbl_Turnos set turno='" + Conexion.Esc(turno) + "' where idTurno=" + idTurno;
        }
        public string Buscar()
        {
            return "Select * from tbl_Turnos where idTurno = " + idTurno;
        }
        public string Eliminar()
        {
            return "delete from tbl_Turnos where idTurno = " + idTurno;
        }
    }
}