using MENU_GENERAL.CLASES;
using System;
using System.Data;
using System.Windows.Forms;

namespace MENU_GENERAL.ESCOLAR
{
    public partial class FRMMAESTROS : Form
    {
        public FRMMAESTROS()
        {
            InitializeComponent();

            Global.Proteger(() =>
                new Conexion("select idCarrera, carrera from tbl_Carreras order by carrera")
                    .LlenarCombo(cmbcarreras, "idCarrera", "carrera"));

            // Conexiones que no estaban en el Designer
            textBoxNumero.Leave += textBoxNumero_Leave;
            registrarbtn.Click += (s, ev) => Global.Proteger(() => buscar(true));
            registrarToolStripMenuItem.Click += (s, ev) => Global.Proteger(metregistrar);
            consultarToolStripMenuItem.Click += (s, ev) => Global.Proteger(() => buscar(true));
            eliminarToolStripMenuItem.Click += (s, ev) => Global.Proteger(eliminar);
            salirToolStripMenuItem.Click += (s, ev) => Close();
        }

        private void textBoxNumero_Leave(object sender, EventArgs e)
        {
            Global.Proteger(() => buscar(false));
        }

        private void toolStripButton1_Click(object sender, EventArgs e)   // botón GUARDAR
        {
            Global.Proteger(metregistrar);
        }

        private void borrarbtn_Click(object sender, EventArgs e)
        {
            Global.Proteger(eliminar);
        }

        private void metregistrar()
        {
            int num;
            if (!Global.LeerEntero(textBoxNumero, "Número de empleado", out num)) return;
            if (Global.CampoVacio(textBox_nombre, "Nombre")) return;
            if (Global.SeleccionVacia(cmbcarreras, "Carrera")) return;

            clMaestro o = new clMaestro(num, textBox_nombre.Text.Trim(), textBoxTelef.Text.Trim(),
                                        textBoxCorreo.Text.Trim(), Convert.ToInt32(cmbcarreras.SelectedValue));
            bool existe = new Conexion(o.Buscar()).CONSULTAR().Tables["Tabla"].Rows.Count > 0;

            new Conexion(existe ? o.Modificar() : o.Guardar()).EJECUTAR();
            MessageBox.Show(existe ? "Registro modificado con éxito" : "Registro guardado con éxito");
        }

        private void buscar(bool avisar)
        {
            int num;
            if (!int.TryParse(textBoxNumero.Text.Trim(), out num))
            {
                if (avisar) MessageBox.Show("Capture un número de empleado válido.");
                return;
            }

            DataTable t = new Conexion(new clMaestro(num).Buscar()).CONSULTAR().Tables["Tabla"];
            if (t.Rows.Count > 0)
            {
                textBox_nombre.Text = t.Rows[0]["nombre"].ToString();
                textBoxCorreo.Text = t.Rows[0]["correo"].ToString();
                textBoxTelef.Text = t.Rows[0]["telefono"].ToString();
                Global.SeleccionarCombo(cmbcarreras, t.Rows[0]["idCarrera"]);
            }
            else if (avisar)
            {
                MessageBox.Show("No existe este dato");
            }
        }

        private void eliminar()
        {
            int num;
            if (!Global.LeerEntero(textBoxNumero, "Número de empleado", out num)) return;

            clMaestro o = new clMaestro(num);
            if (new Conexion(o.Buscar()).CONSULTAR().Tables["Tabla"].Rows.Count == 0)
            {
                MessageBox.Show("El registro no existe");
                return;
            }
            if (MessageBox.Show("¿Desea eliminar este registro?", "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            new Conexion(o.Eliminar()).EJECUTAR();
            MessageBox.Show("El registro se borró correctamente");
            textBoxNumero.Clear(); textBox_nombre.Clear();
            textBoxCorreo.Clear(); textBoxTelef.Clear();
            cmbcarreras.SelectedIndex = -1;
        }
    }
}