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
    public partial class FRMMULTIP : Form
    {
        public FRMMULTIP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float ctxt1 = float.Parse(textBox1.Text), ctxt2 = float.Parse(textBox2.Text);
            clMultiplicar omulti = new clMultiplicar(ctxt1, ctxt2);
            textBox3.Text=omulti.Multi().ToString();

        }
    }
}
