using MENU_GENERAL.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MENU_GENERAL.ESCOLAR
{
    public partial class FRMMAESTROS : Form
    {
        CLASES.Conexion c;

        public FRMMAESTROS()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)//guardar
        {
            clMaestro oMaestro =new clMaestro(int.Parse(textBoxNumero.Text), textBox_nombre.Text, textBoxTelef.Text, textBoxCorreo.Text);
            c = new CLASES.Conexion(oMaestro.Guardar());
            c.EJECUTAR();

        }
         private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
            //oBuscar.Buscar();
        }
       

        private void btnModif_Click(object sender, EventArgs e)
        {
            metregistrar();
        }

        private void textBoxNumero_Leave(object sender, EventArgs e)
        {
            buscar();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)//buscar
        {
            buscar();
        }
        private void borrarbtn_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        private void metregistrar()
        {
            clMaestro oMaestro = new clMaestro(int.Parse(textBoxNumero.Text));
            DataSet ds = new DataSet();
            c = new CLASES.Conexion(oMaestro.Buscar());
            ds = c.CONSULTAR();
            if (ds.Tables["Tabla"].Rows.Count > 0)
            {
                oMaestro = new clMaestro(int.Parse(textBoxNumero.Text), textBox_nombre.Text,
                    textBoxTelef.Text, textBoxCorreo.Text);
                c = new CLASES.Conexion(oMaestro.Modificar());
                c.EJECUTAR();
            }
            else
            {
                oMaestro = new clMaestro(int.Parse(textBoxNumero.Text), textBox_nombre.Text, textBoxTelef.Text, textBoxCorreo.Text);
                c = new CLASES.Conexion(oMaestro.Guardar());
                c.EJECUTAR();

            }
        }
        private void buscar()
        {
            clMaestro oMaestro = new clMaestro(int.Parse(textBoxNumero.Text));
            DataSet ds = new DataSet();
            c = new CLASES.Conexion(oMaestro.Buscar());
            ds = c.CONSULTAR();
            if (ds.Tables["Tabla"].Rows.Count > 0)
            {
                textBoxNumero.Text = ds.Tables["Tabla"].Rows[0]["num_Empleado"].ToString();
                textBox_nombre.Text = ds.Tables["Tabla"].Rows[0]["nombre"].ToString();
                textBoxCorreo.Text = ds.Tables["Tabla"].Rows[0]["correo"].ToString();
                textBoxTelef.Text = ds.Tables["Tabla"].Rows[0]["telefono"].ToString();

            }
            else
            {
                MessageBox.Show("No existe este dato");
            }
        }
        private void eliminar()
        { clMaestro oMaestro = new clMaestro(int.Parse(textBoxNumero.Text));
            DataSet ds = new DataSet();
            c = new CLASES.Conexion(oMaestro.Buscar());
            ds = c.CONSULTAR();
            if (ds.Tables["Tabla"].Rows.Count > 0)
            { if (MessageBox.Show("¿Desea eliminar este registro?", 
                "Eliminar", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question)==DialogResult.Yes)
              { 
                c = new CLASES.Conexion(oMaestro.Eliminar());
              }
            } //
            else
            {
                MessageBox.Show("El registro no existe");
            }
        }


    }
}
