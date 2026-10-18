using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENU_GENERAL
{
    internal class clSUMAR
    {
        //PROPIEDADES: SUMANDOS
        private float val1;
        private float val2;
        private float sum;

        //constructor
        public clSUMAR(float n1, float n2)
        {
            this.val1=n1; 
            this.val2=n2;
        }
        
      //MÉTODO: SUMAR
      public float Sumar ()
        {
            sum = val1 + val2;
            return sum;
        }
    }
}
