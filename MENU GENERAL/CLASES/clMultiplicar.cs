using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENU_GENERAL
{
    internal class clMultiplicar
    {//PROPIEDADES:LOS NÚM A INGRESA
        private float val1;
        private float val2;
        private float producto;

        //CONSTRUCTOR
        public clMultiplicar(float n1, float n2)
        {
            this.val1= n1;
            this.val2 = n2;
        }

        //MÉTODOS: MULTIPLICAR

        public float Multi()
        {
            producto = val1 * val2;
            return producto;
        }
    }
}
