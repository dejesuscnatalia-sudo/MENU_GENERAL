using MENU_GENERAL.CLASES;
using System;
using System.Data;
using System.Windows.Forms;

namespace MENU_GENERAL.CLASES
{
    public partial class FRMMaterias : Form
    {
        public FRMMaterias()
        {
            InitializeComponent();

            guardarToolStripMenuItem.Click += (s, ev) => btGuardar_Click(s, ev);
            buscarToolStripMenuItem.Click += (s, ev) => btBuscar_Click(s, ev);
            eliminarToolStripMenuItem.Click += (s, ev) => btElim_Click(s, ev);
            salirToolStripMenuItem.Click += (s, ev) => Close();
            txtbClave.Leave += (s, ev) => Global.Proteger(() => buscar(false));
        }

        private void registro()
        {
            int id;
            if (!Global.LeerEntero(txtbClave, "Número de materia", out id)) return;
            if (Global.CampoVacio(txtbMateria, "Nombre de materia")) return;

            clMaterias o = new clMaterias(id, txtbMateria.Text.Trim());
            bool existe = new Conexion(o.Buscar()).CONSULTAR().Tables["Tabla"].Rows.Count > 0;

            new Conexion(existe ? o.Modificar() : o.Guardar()).EJECUTAR();
            MessageBox.Show(existe ? "Registro modificado con éxito" : "Registro guardado con éxito");
        }

        private void buscar(bool avisar)
        {
            int id;
            if (!int.TryParse(txtbClave.Text.Trim(), out id))
            {
                if (avisar) MessageBox.Show("Capture una clave numérica.");
                return;
            }

            DataTable t = new Conexion(new clMaterias(id).Buscar()).CONSULTAR().Tables["Tabla"];
            if (t.Rows.Count > 0)
                txtbMateria.Text = t.Rows[0]["nombre"].ToString();
            else if (avisar)
                MessageBox.Show("No existe este dato");
        }

        private void eliminar()
        {
            int id;
            if (!Global.LeerEntero(txtbClave, "Número de materia", out id)) return;

            clMaterias o = new clMaterias(id);
            if (new Conexion(o.Buscar()).CONSULTAR().Tables["Tabla"].Rows.Count == 0)
            {
                MessageBox.Show("El registro no existe");
                return;
            }
            if (MessageBox.Show("¿Desea eliminar este registro?", "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            new Conexion(o.Eliminar()).EJECUTAR();
            MessageBox.Show("El registro se borró correctamente");
            txtbClave.Clear();
            txtbMateria.Clear();
        }

        // Handlers que el Designer ya referencia
        private void btGuardar_Click(object sender, EventArgs e) { Global.Proteger(registro); }
        private void btBuscar_Click(object sender, EventArgs e) { Global.Proteger(() => buscar(true)); }
        private void btElim_Click(object sender, EventArgs e) { Global.Proteger(eliminar); }
        private void label1_Click(object sender, EventArgs e) { }
    }
}