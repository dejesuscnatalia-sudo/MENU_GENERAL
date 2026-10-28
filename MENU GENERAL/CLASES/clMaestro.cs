using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENU_GENERAL.CLASES
{
    internal class clMaestro
    {
        private int num_Empleado;
        private string nombre;
        private string telefono;
        private string correo;
        private int carreras;

        public clMaestro(int numEmp, string _nombre, string telefono, string correo, int carreras)
        {
            //Para grabar y modificar
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
            return "Insert into tbl_Registro_Maestros Values ("+num_Empleado+", '"+nombre+"', '"+correo+"', '"+telefono+"', '"+carreras+")";
            
        }

        public string Modificar()
        {
            return $"Update tbl_Registro_Maestros set nombre={nombre}, correo={correo}, telefono={telefono}, idCarrera={carreras} where num_Empleado={num_Empleado}";

        }
        public string Buscar()
        {
            return "Select * from tbl_Registro_Maestros where num_Empleado = " + num_Empleado;
        }
        public string Eliminar()
        {
            return $"delete from tbl_Registro_Maestros where num_Empleado = {num_Empleado}";
        }
        public void Limpiar()
        {
            
        }
    }
}
