using MENU_GENERAL.CLASES;
using System;
using System.Data;
using System.Windows.Forms;

namespace MENU_GENERAL.ESCOLAR
{
    public partial class FRM_CARRERA : Form
    {
        public FRM_CARRERA()
        {
            InitializeComponent();

            // El Designer ata Leave a btnBuscar_Click (avisaba "No existe" al cambiar de control):
            // se cambia por un handler silencioso.
            txtbnumCarrera.Leave -= btnBuscar_Click;
            txtbnumCarrera.Leave += txtbnumCarrera_Leave;

            // Menú sin handlers en el Designer
            guardarToolStripMenuItem.Click += (s, ev) => btnGuardar_Click(s, ev);
            buscarToolStripMenuItem.Click += (s, ev) => btnBuscar_Click(s, ev);
            eliminarToolStripMenuItem.Click += (s, ev) => btnEliminar_Click(s, ev);
            salirToolStripMenuItem.Click += (s, ev) => Close();

            Global.Proteger(() =>
                new Conexion("select Id_Departamento, Nombre_Departamento from tbl_Departamentos order by Nombre_Departamento")
                    .LlenarCombo(cbxDepas, "Id_Departamento", "Nombre_Departamento"));
        }

        private void btnGuardar_Click(object sender, EventArgs e) { Global.Proteger(registro); }
        private void btnBuscar_Click(object sender, EventArgs e) { Global.Proteger(() => buscar(true)); }
        private void btnEliminar_Click(object sender, EventArgs e) { Global.Proteger(eliminar); }
        private void txtbnumCarrera_Leave(object sender, EventArgs e) { Global.Proteger(() => buscar(false)); }

        private void registro()
        {
            int id;
            if (!Global.LeerEntero(txtbnumCarrera, "Clave de carrera", out id)) return;
            if (Global.CampoVacio(txtbCarrera, "Nombre de carrera")) return;
            if (Global.SeleccionVacia(cbxDepas, "Departamento")) return;

            clCarreras o = new clCarreras(id, txtbCarrera.Text.Trim(), Convert.ToInt32(cbxDepas.SelectedValue));
            bool existe = new Conexion(o.Buscar()).CONSULTAR().Tables["Tabla"].Rows.Count > 0;

            new Conexion(existe ? o.Modificar() : o.Guardar()).EJECUTAR();
            MessageBox.Show(existe ? "Registro modificado con éxito" : "Registro guardado con éxito");
        }

        private void buscar(bool avisar)
        {
            int id;
            if (!int.TryParse(txtbnumCarrera.Text.Trim(), out id))
            {
                if (avisar) MessageBox.Show("Capture una clave numérica.");
                return;
            }

            DataTable t = new Conexion(new clCarreras(id).Buscar()).CONSULTAR().Tables["Tabla"];
            if (t.Rows.Count > 0)
            {
                txtbCarrera.Text = t.Rows[0]["carrera"].ToString();
                Global.SeleccionarCombo(cbxDepas, t.Rows[0]["id_Departamento"]);
            }
            else if (avisar)
            {
                MessageBox.Show("No existe este dato");
            }
        }

        private void eliminar()
        {
            int id;
            if (!Global.LeerEntero(txtbnumCarrera, "Clave de carrera", out id)) return;

            clCarreras o = new clCarreras(id);
            if (new Conexion(o.Buscar()).CONSULTAR().Tables["Tabla"].Rows.Count == 0)
            {
                MessageBox.Show("El registro no existe");
                return;
            }
            if (MessageBox.Show("¿Desea eliminar este registro?", "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            new Conexion(o.Eliminar()).EJECUTAR();     // antes faltaba esta línea
            MessageBox.Show("El registro se borró correctamente");
            txtbnumCarrera.Clear();
            txtbCarrera.Clear();
            cbxDepas.SelectedIndex = -1;
        }
    }
}