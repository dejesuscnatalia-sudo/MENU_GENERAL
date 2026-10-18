using MENU_GENERAL.ESCOLAR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENU_GENERAL.CLASES
{
    internal class clMaterias
    {
        public int id_materia { get; set; }
        public string Nombre { get; set; }
        private static List<clMaterias> listaMaterias = new List<clMaterias>();

        //CONSTRUCTORES
        public clMaterias() 
        {
            id_materia = 0;
            Nombre = "";
        }

        public clMaterias(int clave, string nombre)
        { 
            this.id_materia= clave;
            this.Nombre= nombre;
        }
        public clMaterias(int clave)
        { 
            this.id_materia = clave; 
        }

        public string Guardar() {
            return "Insert into tbl_Materias Values (" + id_materia + ", '" + Nombre + "')";
        }

        public string Modificar()
        {
            return $"Update tbl_Materias set carrera='{id_materia}' where idCarrera={Nombre}";
        }
        public string Buscar()
        {
            return "Select * from tbl_Materias where id_Materia= " + id_materia;
        }
        public string Eliminar()
        {
            return $"delete from tbl_Materias where id_Materia = {id_materia}";
        }

        /*public clMaterias Buscar(string clave) 
        { 
          foreach(clMaterias materia in listaMaterias)
            {
                if (materia.Clave == clave)
                {
                    return materia;
                }
            }
            return null;
        }


        public string Modificar() 
        {
          for(int i=0; i<listaMaterias.Count; i++) 
          {
            if(listaMaterias[i].Clave == this.Clave)
                {
                    listaMaterias[i].Nombre= this.Nombre;
                    return "Materia modificada correctamente";
                }
          }
            return "La materia no existe";
        }

        public string Eliminar() 
        {
            for (int i = 0; i < listaMaterias.Count; i++)
            {
                if (listaMaterias[i].Clave == this.Clave)
                {
                    listaMaterias.RemoveAt(i);
                    return "Materia eliminada Correctamente";
                }
            }

            return "Materia no existente";
        }
        */


    }
}
