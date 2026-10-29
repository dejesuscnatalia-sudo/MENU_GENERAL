using System;

namespace MENU_GENERAL.CLASES
{
    internal class clTurno : ICatalogo
    {
        private int num_turno;
        private string Nombre_turno;

        public clTurno() { }
        public clTurno(int num_turno) { this.num_turno = num_turno; }
        public clTurno(int num_turno, string Nombre_turno)
        {
            this.num_turno = num_turno;
            this.Nombre_turno = Nombre_turno;
        }

        public string Guardar()
        {
            return "Insert into Tbl_Turno (Id_Turno, Nombre_turno, Estado) Values (" + num_turno +
                   ", '" + Global.Esc(Nombre_turno) + "', 1)";
        }
        // Al modificar también reactiva el turno si estaba dado de baja
        public string Modificar()
        {
            return "Update Tbl_Turno set Nombre_turno='" + Global.Esc(Nombre_turno) +
                   "', Estado=1 where Id_Turno=" + num_turno;
        }
        // Existe aunque esté dado de baja (decide INSERT o UPDATE)
        public string Existe()
        {
            return "Select Id_Turno from Tbl_Turno where Id_Turno=" + num_turno;
        }
        // Buscar: solo turnos activos
        public string Buscar()
        {
            return "Select * from Tbl_Turno where Id_Turno=" + num_turno + " and Estado=1";
        }
        // Baja lógica
        public string Eliminar()
        {
            return "Update Tbl_Turno set Estado=0 where Id_Turno=" + num_turno;
        }
        public string consultageneral()
        {
            return "select * from Tbl_Turno where Estado=1 order by Nombre_turno";
        }
    }
}
