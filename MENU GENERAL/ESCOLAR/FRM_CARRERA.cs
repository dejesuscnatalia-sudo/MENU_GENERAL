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

namespace MENU_GENERAL.ESCOLAR
{
    public partial class FRM_CARRERA : Form
    {
        public FRM_CARRERA()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            registro();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        CLASES.Conexion c;
        private void registro()
        {
            clCarreras oCarrera = new clCarreras(int.Parse(txtbnumCarrera.Text));
            DataSet ds = new DataSet();
            c = new CLASES.Conexion(oCarrera.Buscar());
            ds = c.CONSULTAR();
            if (ds.Tables["Tabla"].Rows.Count > 0)
            {
                oCarrera = new clCarreras(int.Parse(txtbnumCarrera.Text), txtbCarrera.Text);
                c = new CLASES.Conexion(oCarrera.Modificar());
                c.EJECUTAR();
                MessageBox.Show("Registro Modificado con Éxito");
            }
            else
            {
                oCarrera = new clCarreras(int.Parse(txtbnumCarrera.Text), txtbCarrera.Text);
                c = new CLASES.Conexion(oCarrera.Guardar());
                c.EJECUTAR();
                MessageBox.Show("Registro Guardado Con Éxito");
            }
        }
        private void buscar()
        {
           clCarreras oCarrera = new clCarreras(int.Parse(txtbnumCarrera.Text));
            DataSet ds = new DataSet();
            c = new CLASES.Conexion(oCarrera.Buscar());
            ds = c.CONSULTAR();
            if (ds.Tables["Tabla"].Rows.Count > 0)
            {
                txtbnumCarrera.Text = ds.Tables["Tabla"].Rows[0]["idCarrera"].ToString();
                txtbCarrera.Text = ds.Tables["Tabla"].Rows[0]["carrera"].ToString();
                

            }
            else
            {
                MessageBox.Show("No existe este dato");
            }
        }
      
        private void eliminar()
        {
            clCarreras oCarrera = new clCarreras(int.Parse(txtbnumCarrera.Text));
            DataSet ds = new DataSet();
            c = new CLASES.Conexion(oCarrera.Buscar());
            ds = c.CONSULTAR();
            if (ds.Tables["Tabla"].Rows.Count > 0)
            {
                if (MessageBox.Show("¿Desea eliminar este registro?",
                "Eliminar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    c = new CLASES.Conexion(oCarrera.Eliminar());
                }
            }
            else
            { //suena a comunicacion
                MessageBox.Show("El registro no existe");
            }
        }

        
    }
}
