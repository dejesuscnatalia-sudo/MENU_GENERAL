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
    public partial class FRMRESTA : Form
    {
        public FRMRESTA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float ctxt1 = float.Parse(textBox1.Text), ctxt2 = float.Parse(textBox2.Text);
            clRESTA orestar=new clRESTA(ctxt1, ctxt2);
            textBox3.Text = orestar.Restar().ToString();
        }
    }
}
