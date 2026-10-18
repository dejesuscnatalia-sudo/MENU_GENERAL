using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENU_GENERAL
{
    internal class clRESTA
    {
        //PROPIEDADES: LOS NÚMEROS Y LA DIFERENCIA
        private float val1;
        private float val2;
        private float diferencia;

        //CONSTRUCTOR
        public clRESTA(float n1, float n2)
        {
            this.val1= n1;
            this.val2 = n2;
        }
       
        //MÉTODOS: 
        public float Restar()
        {
            diferencia = val1 - val2;
            return diferencia;
        }
    }
}
