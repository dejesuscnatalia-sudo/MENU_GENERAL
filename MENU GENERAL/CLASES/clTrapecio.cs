using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MENU_GENERAL.CLASES
{
    internal class clTrapecio
    {
        private float baseMa;
        private float basemen;
        private float alt;
        public float area;
        public float perimetro;


        public clTrapecio(float bma, float bmen,  float alt)
        {
            this.baseMa = bma;  
            this.basemen = bmen;
            this.alt= alt;
        }

        public float Area()
        {
            area = (baseMa + basemen) * alt / 2;
            return area;
        }
        public float Perimetro() 
        {

            return perimetro;
        }
    }
}
