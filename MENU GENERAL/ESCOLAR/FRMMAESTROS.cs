using MENU_GENERAL.CLASES;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MENU_GENERAL.ESCOLAR
{
    public partial class FRMMAESTROS : Form
    {
        Conexion c;

        public FRMMAESTROS()
        {
            InitializeComponent();
            CargarCarreras();
        }
/*
            // Conexiones que no estaban en el diseñador
            registrarbtn.Click += (s, e) => buscar(true);
            registrarToolStripMenuItem.Click += (s, e) => metregistrar();
            consultarToolStripMenuItem.Click += (s, e) => buscar(true);
            eliminarToolStripMenuItem.Click += (s, e) => eliminar();
            salirToolStripMenuItem.Click += (s, e) => Close();
        }
*/
        private void CargarCarreras()
        {
            new Conexion("Select idCarrera, carrera from tbl_Carreras order by carrera")
                .LlenarCombo(cmbcarreras, "idCarrera", "carrera");
        }
        

        private void textBoxNumero_Leave(object sender, EventArgs e)
        {
            buscar(false);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)   // botón GUARDAR
        {
            metregistrar();
        }

        private void borrarbtn_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void metregistrar()
        {
            int num;
            if (!int.TryParse(textBoxNumero.Text, out num))
            {
                MessageBox.Show("Captura un número de empleado válido.");
                return;
            }
            if (textBox_nombre.Text.Trim() == "" || cmbcarreras.SelectedValue == null)
            {
                MessageBox.Show("Captura el nombre y selecciona una carrera.");
                return;
            }

            clMaestro oMaestro = new clMaestro(num);
            DataSet ds = new Conexion(oMaestro.Buscar()).CONSULTAR();

            oMaestro = new clMaestro(num, textBox_nombre.Text.Trim(), textBoxTelef.Text.Trim(),
                                     textBoxCorreo.Text.Trim(), Convert.ToInt32(cmbcarreras.SelectedValue));

            if (ds.Tables["Tabla"].Rows.Count > 0)
            {
                c = new Conexion(oMaestro.Modificar());
                c.EJECUTAR();
                MessageBox.Show("Registro modificado con éxito");
            }
            else
            {
                c = new Conexion(oMaestro.Guardar());
                c.EJECUTAR();
                MessageBox.Show("Registro guardado con éxito");
            }
        }

        private void buscar(bool avisar)
        {
            int num;
            if (!int.TryParse(textBoxNumero.Text, out num))
            {
                if (avisar) MessageBox.Show("Captura un número de empleado válido.");
                return;
            }

            clMaestro oMaestro = new clMaestro(num);
            DataTable t = new Conexion(oMaestro.Buscar()).CONSULTAR().Tables["Tabla"];

            if (t.Rows.Count > 0)
            {
                textBoxNumero.Text = t.Rows[0]["num_Empleado"].ToString();
                textBox_nombre.Text = t.Rows[0]["nombre"].ToString();
                textBoxCorreo.Text = t.Rows[0]["correo"].ToString();
                textBoxTelef.Text = t.Rows[0]["telefono"].ToString();

                if (t.Rows[0]["idCarrera"] != DBNull.Value)
                    cmbcarreras.SelectedValue = Convert.ToInt32(t.Rows[0]["idCarrera"]);
                else
                    cmbcarreras.SelectedIndex = -1;
            }
            else if (avisar)
            {
                MessageBox.Show("No existe este dato");
            }
        }

        private void eliminar()
        {
            int num;
            if (!int.TryParse(textBoxNumero.Text, out num))
            {
                MessageBox.Show("Captura un número de empleado válido.");
                return;
            }

            clMaestro oMaestro = new clMaestro(num);
            DataSet ds = new Conexion(oMaestro.Buscar()).CONSULTAR();

            if (ds.Tables["Tabla"].Rows.Count > 0)
            {
                if (MessageBox.Show("¿Desea eliminar este registro?", "Eliminar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    c = new Conexion(oMaestro.Eliminar());
                    c.EJECUTAR();                       // antes faltaba esta línea
                    MessageBox.Show("El registro se borró correctamente");
                    textBoxNumero.Clear(); textBox_nombre.Clear();
                    textBoxCorreo.Clear(); textBoxTelef.Clear();
                    cmbcarreras.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("El registro no existe");
            }
        }
    }
}