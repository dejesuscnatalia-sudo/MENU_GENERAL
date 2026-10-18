using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MENU_GENERAL
{
    public partial class FRMDIV : Form
    {
        public FRMDIV()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float ctxt1 = float.Parse(textBox1.Text), ctxt2 = float.Parse(textBox2.Text);
            if (ctxt2 == 0)
            {
                textBox3.Text = "Error, no se puede dividir entre 0.";
            }
            else
            {
                clDividir odividir = new clDividir(ctxt1, ctxt2);
                textBox3.Text = odividir.Divicion().ToString();
            }
        }
            
                
        
        
    }
}
