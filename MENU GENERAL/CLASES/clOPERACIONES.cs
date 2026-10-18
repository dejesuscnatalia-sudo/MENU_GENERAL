using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENU_GENERAL
{
    internal class clOPERACIONES
    {
        //PROPIEDADES:LOS NÚM A INGRESA
        private float val1;
        private float val2;
        private float result;


        //CONSTRUCTOR
        public clOPERACIONES(float n1, float n2)
        {
            this.val1 = n1;
            this.val2 = n2;

        }
        //MÉTODO: SUMAR

        public float Sumar()
        {
            result = val1 + val2;
            return result;
        }

        //MÉTODO: RESTAR
        public float Restar()
        {
            result = val1 - val2;
            return result;
        }

        //MÉTODO: MULTIPLICAR

        public float Multi()
        {
            result = val1 * val2;
            return result;
        }

        //MÉTODO: DIVIDIR

        public float Division()
        {

            result = val1 / val2;
            return result;
        }
    }
}
