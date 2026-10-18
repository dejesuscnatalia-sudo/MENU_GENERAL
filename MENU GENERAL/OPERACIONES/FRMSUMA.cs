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
    public partial class FRMSUMA : Form
    {
        public FRMSUMA()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float cajatxt1=float.Parse(textBox1.Text), cajatxt2=float.Parse(textBox2.Text);

            clSUMAR osuma=new clSUMAR(cajatxt1, cajatxt2);
            textBox3.Text = osuma.Sumar().ToString();
        }

        
        //si le picas al lado izq con los núm, se puede correr, desde ese punto en modo paso a paso
        //con las flechitas azules de arriba (donde está el stop )
    }
}
