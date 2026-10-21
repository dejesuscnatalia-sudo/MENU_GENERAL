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
        
        private void registrarbtn_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            metregistrar();
        }


        private void toolStripButton1_Click(object sender, EventArgs e)//buscar
        {
            metregistrar();
        }
        private void borrarbtn_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void cmbcarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargacarreras();
        }
        private void cargacarreras()
        {
            DataSet ds = new DataSet();
            CLASES.clCarreras s = new CLASES.clCarreras();
            CLASES.Conexion c= new CLASES.Conexion(s.consultageneral());
            ds=c.CONSULTAR(); 
            cmbcarreras.DataSource = ds.Tables[0]; //origen de datos. Util para datos variables de la bd
            cmbcarreras.DisplayMember = ds.Tables[0].Columns["carrera"].ToString(); //el campo a visualizar
            cmbcarreras.ValueMember = ds.Tables[0].Columns["idCarrera"].ToString();
            //
        }
        private void metregistrar()
        {
            int idcarrera = int.Parse(cmbcarreras.SelectedValue.ToString());
            clMaestro oMaestro = new clMaestro(int.Parse(textBoxNumero.Text));
            DataSet ds = new DataSet();
            c = new CLASES.Conexion(oMaestro.Buscar());
            ds = c.CONSULTAR();
            if (ds.Tables["Tabla"].Rows.Count > 0)
            {
                

                oMaestro = new clMaestro(int.Parse(textBoxNumero.Text), textBox_nombre.Text,
                    textBoxTelef.Text, textBoxCorreo.Text, idcarrera);
                c = new CLASES.Conexion(oMaestro.Modificar());
                c.EJECUTAR();
            }
            else
            {
                oMaestro = new clMaestro(int.Parse(textBoxNumero.Text), textBox_nombre.Text, textBoxTelef.Text, textBoxCorreo.Text, idcarrera);
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
                cmbcarreras.SelectedValue = ds.Tables["Tabla"].Rows[0]["idCarrera"].ToString();

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
