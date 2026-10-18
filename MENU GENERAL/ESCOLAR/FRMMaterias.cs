using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MENU_GENERAL.CLASES
{
    public partial class FRMMaterias : Form
    {
        public FRMMaterias()
        {
            InitializeComponent(); 
        }


        CLASES.Conexion c;
        private void registro()
        {
            clMaterias oCarrera = new clMaterias(int.Parse(txtbClave.Text));
            DataSet ds = new DataSet();
            c = new CLASES.Conexion(oCarrera.Buscar());
            ds = c.CONSULTAR();
            if (ds.Tables["Tabla"].Rows.Count > 0)
            {
                oCarrera = new clMaterias(int.Parse(txtbClave.Text), txtbMateria.Text);
                c = new CLASES.Conexion(oCarrera.Modificar());
                c.EJECUTAR();
                MessageBox.Show("Registro Modificado con Éxito");
            }
            else
            {
                oCarrera = new clMaterias(int.Parse(txtbClave.Text), txtbMateria.Text);
                c = new CLASES.Conexion(oCarrera.Guardar());
                c.EJECUTAR();
                MessageBox.Show("Registro Guardado Con Éxito");
            }
        }
        private void buscar()
        {
            clMaterias oCarrera = new clMaterias(int.Parse(txtbClave.Text));
            DataSet ds = new DataSet();
            c = new CLASES.Conexion(oCarrera.Buscar());
            ds = c.CONSULTAR();
            if (ds.Tables["Tabla"].Rows.Count > 0)
            {
                txtbClave.Text = ds.Tables["Tabla"].Rows[0]["id_Materia"].ToString();
                txtbMateria.Text = ds.Tables["Tabla"].Rows[0]["nombre"].ToString();


            }
            else
            {
                MessageBox.Show("No existe este dato");
            }
        }

        private void eliminar()
        {
            clMaterias oCarrera = new clMaterias(int.Parse(txtbClave.Text));
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
                    c.EJECUTAR();
                    MessageBox.Show("El registro se borró correctamente");

                }
            }
            else
            { //suena a comunicacion
                MessageBox.Show("El registro no existe");
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            registro();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void btElim_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            /*clMaterias materia = new clMaterias(txtbClave.Text, txtbMateria.Text);
            string mensaje = materia.Guardar();
            MessageBox.Show(mensaje);*/
        }

        private void btnBusc_Click(object sender, EventArgs e)
        {
            /*clMaterias materia = new clMaterias();

            clMaterias resultado = materia.Buscar(txtbClave.Text);
            if (resultado != null)
            {
                txtbMateria.Text = resultado.Nombre;
            }
            else
            {
                MessageBox.Show("La materia no existe.");
            }*/
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            /*clMaterias materia = new clMaterias(txtbClave.Text, txtbMateria.Text);
            string mensaje = materia.Modificar();
            MessageBox.Show(mensaje);
        */
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            /*clMaterias materia=new clMaterias();
            materia.Clave = txtbClave.Text;
            string mensaje = materia.Eliminar();
            MessageBox.Show(mensaje);
            */
        }
    }
}
