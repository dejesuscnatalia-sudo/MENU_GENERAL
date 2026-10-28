using System;

namespace MENU_GENERAL.CLASES
{
    // Carrera 1 ---- N Alumnos | Turno 1 ---- N Alumnos | Semestre 1 ---- N Alumnos
    internal class Alumno
    {
        private string _matricula;
        private string _nombre;
        private string _correo;
        private string _telefono;
        private int _carrera;
        private int _turno;
        private int _semestre;

        public Alumno() { }
        public Alumno(string matricula)
        {
            _matricula = matricula;
        }
        public Alumno(string matricula, string nombre, string correo, string telefono,
                      int carrera, int turno, int semestre)
        {
            _matricula = matricula;
            _nombre = nombre;
            _correo = correo;
            _telefono = telefono;
            _carrera = carrera;
            _turno = turno;
            _semestre = semestre;
        }

        public string Guardar()
        {
            return "Insert into tbl_Alumnos (Matricula, Nombre, Correo, Telefono, idCarrera, Id_Turno, Id_Semestre) Values ('" +
                   Global.Esc(_matricula) + "', '" + Global.Esc(_nombre) + "', '" + Global.Esc(_correo) + "', '" +
                   Global.Esc(_telefono) + "', " + _carrera + ", " + _turno + ", " + _semestre + ")";
        }
        public string Modificar()
        {
            return "Update tbl_Alumnos set Nombre='" + Global.Esc(_nombre) + "', Correo='" + Global.Esc(_correo) +
                   "', Telefono='" + Global.Esc(_telefono) + "', idCarrera=" + _carrera + ", Id_Turno=" + _turno +
                   ", Id_Semestre=" + _semestre + " where Matricula='" + Global.Esc(_matricula) + "'";
        }
        public string Buscar()
        {
            return "Select * from tbl_Alumnos where Matricula='" + Global.Esc(_matricula) + "'";
        }
        public string Eliminar()
        {
            return "delete from tbl_Alumnos where Matricula='" + Global.Esc(_matricula) + "'";
        }
        // Lista con los nombres de las tablas relacionadas (JOIN)
        public string ConsultaGeneral()
        {
            return "select a.Matricula, a.Nombre, c.carrera as Carrera, t.Nombre_turno as Turno, " +
                   "s.Nombre_semestre as Semestre, a.Correo, a.Telefono " +
                   "from tbl_Alumnos a " +
                   "inner join tbl_Carreras c on a.idCarrera = c.idCarrera " +
                   "inner join Tbl_Turno t on a.Id_Turno = t.Id_Turno " +
                   "inner join Tbl_Semestres s on a.Id_Semestre = s.Id_Semestre " +
                   "order by a.Nombre";
        }
    }
}
