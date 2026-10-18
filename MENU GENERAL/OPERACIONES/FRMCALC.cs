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
    public partial class FRMCALC : Form
    {
        
        public FRMCALC()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float ctxt1 = float.Parse(textBox1.Text), ctxt2 = float.Parse(textBox2.Text);
            clOPERACIONES ooperacion = new clOPERACIONES(ctxt1, ctxt2);
            textBox3.Text = ooperacion.Sumar().ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float ctxt1 = float.Parse(textBox1.Text), ctxt2 = float.Parse(textBox2.Text);
            clOPERACIONES ooperacion = new clOPERACIONES(ctxt1, ctxt2);
            textBox3.Text = ooperacion.Restar().ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            float ctxt1 = float.Parse(textBox1.Text), ctxt2 = float.Parse(textBox2.Text);
            clOPERACIONES ooperacion = new clOPERACIONES(ctxt1, ctxt2);
            textBox3.Text = ooperacion.Multi().ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            float ctxt1 = float.Parse(textBox1.Text), ctxt2 = float.Parse(textBox2.Text);
            if (ctxt2 == 0)
            {
                textBox3.Text = "Error, no se puede dividir entre 0.";
            }
            else
            {
                clOPERACIONES ooperacion = new clOPERACIONES(ctxt1, ctxt2);
                textBox3.Text = ooperacion.Division().ToString();
            }


        }
    }
}
