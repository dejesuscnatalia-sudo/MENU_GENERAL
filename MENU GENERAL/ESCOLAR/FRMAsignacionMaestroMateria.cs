using MENU_GENERAL.CLASES;
using System;
using System.Data;
using System.Windows.Forms;

namespace MENU_GENERAL.ESCOLAR
{
    public partial class FRMAsignacionMaestroMateria : Form
    {
        public FRMAsignacionMaestroMateria()
        {
            InitializeComponent();

            // Cargar combos de maestros y materias
            Global.Proteger(() =>
                new Conexion("select num_Empleado, nombre from tbl_Registro_Maestros order by nombre")
                    .LlenarCombo(cmbMaestros, "num_Empleado", "nombre"));

            Global.Proteger(() =>
                new Conexion("select Id_Materia, nombre from tbl_Materias order by nombre")
                    .LlenarCombo(cmbMaterias, "Id_Materia", "nombre"));

            // Cargar combo de estados
            cmbEstado.Items.Add("activo");
            cmbEstado.Items.Add("inactivo");

            // Conexiones que no estaban en el Designer
            textBoxIdAsignacion.Leave += textBoxIdAsignacion_Leave;
            registrarbtn.Click += (s, ev) => Global.Proteger(() => buscar(true));
            registrarToolStripMenuItem.Click += (s, ev) => Global.Proteger(metregistrar);
            consultarToolStripMenuItem.Click += (s, ev) => Global.Proteger(() => buscar(true));
            eliminarToolStripMenuItem.Click += (s, ev) => Global.Proteger(eliminar);
            salirToolStripMenuItem.Click += (s, ev) => Close();
        }

        private void textBoxIdAsignacion_Leave(object sender, EventArgs e)
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
            // Validación de ID (opcional, puede generar automático)
            int idAsig = 0;
            if (!string.IsNullOrEmpty(textBoxIdAsignacion.Text.Trim()))
            {
                if (!int.TryParse(textBoxIdAsignacion.Text.Trim(), out idAsig))
                {
                    MessageBox.Show("ID de asignación debe ser un número válido.");
                    return;
                }
            }

            // Validaciones de campos obligatorios
            if (Global.SeleccionVacia(cmbMaestros, "Maestro")) return;
            if (Global.SeleccionVacia(cmbMaterias, "Materia")) return;
            if (Global.CampoVacio(textBoxGrupo, "Grupo")) return;
            if (Global.CampoVacio(textBoxSalon, "Salón")) return;
            if (dtpFechaAsig.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de asignación no puede ser una fecha futura.");
                return;
            }
            if (Global.SeleccionVacia(cmbEstado, "Estado")) return;

            DateTime? fechaFin = null;
            if (dtpFechaFin.Checked)
            {
                fechaFin = dtpFechaFin.Value;
                if (fechaFin < dtpFechaAsig.Value)
                {
                    MessageBox.Show("La fecha de fin no puede ser anterior a la fecha de asignación.");
                    return;
                }
            }

            clAsignacionMaestroMateria o = new clAsignacionMaestroMateria(
                idAsig,
                Convert.ToInt32(cmbMaestros.SelectedValue),
                Convert.ToInt32(cmbMaterias.SelectedValue),
                textBoxGrupo.Text.Trim(),
                textBoxSalon.Text.Trim(),
                dtpFechaAsig.Value,
                fechaFin,
                cmbEstado.SelectedItem.ToString()
            );

            bool existe = false;
            if (idAsig > 0)
            {
                existe = new Conexion(o.Buscar()).CONSULTAR().Tables["Tabla"].Rows.Count > 0;
            }

            new Conexion(existe ? o.Modificar() : o.Guardar()).EJECUTAR();
            MessageBox.Show(existe ? "Registro modificado con éxito" : "Registro guardado con éxito");

            Limpiar();
            CargarListaAsignaciones();
        }

        private void buscar(bool avisar)
        {
            int id;
            if (!int.TryParse(textBoxIdAsignacion.Text.Trim(), out id))
            {
                if (avisar) MessageBox.Show("Capture un ID de asignación válido.");
                return;
            }

            DataTable t = new Conexion(new clAsignacionMaestroMateria(id).Buscar()).CONSULTAR().Tables["Tabla"];
            if (t.Rows.Count > 0)
            {
                textBoxIdAsignacion.Text = t.Rows[0]["id_asignacion"].ToString();
                Global.SeleccionarCombo(cmbMaestros, t.Rows[0]["num_empleado"]);
                Global.SeleccionarCombo(cmbMaterias, t.Rows[0]["id_materia"]);
                textBoxGrupo.Text = t.Rows[0]["grupo"].ToString();
                textBoxSalon.Text = t.Rows[0]["salon"].ToString();
                dtpFechaAsig.Value = Convert.ToDateTime(t.Rows[0]["fecha_asig"]);

                if (t.Rows[0]["fecha_fin"] != DBNull.Value)
                {
                    dtpFechaFin.Checked = true;
                    dtpFechaFin.Value = Convert.ToDateTime(t.Rows[0]["fecha_fin"]);
                }
                else
                {
                    dtpFechaFin.Checked = false;
                }

                cmbEstado.SelectedItem = t.Rows[0]["estado"].ToString();
            }
            else if (avisar)
            {
                MessageBox.Show("No existe este dato");
            }
        }

        private void eliminar()
        {
            int id;
            if (!int.TryParse(textBoxIdAsignacion.Text.Trim(), out id))
            {
                MessageBox.Show("Capture un ID de asignación válido.");
                return;
            }

            clAsignacionMaestroMateria o = new clAsignacionMaestroMateria(id);
            if (new Conexion(o.Buscar()).CONSULTAR().Tables["Tabla"].Rows.Count == 0)
            {
                MessageBox.Show("El registro no existe");
                return;
            }
            if (MessageBox.Show("¿Desea eliminar este registro?", "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            new Conexion(o.Eliminar()).EJECUTAR();
            MessageBox.Show("El registro se borró correctamente");
            Limpiar();
            CargarListaAsignaciones();
        }

        private void Limpiar()
        {
            textBoxIdAsignacion.Clear();
            cmbMaestros.SelectedIndex = -1;
            cmbMaterias.SelectedIndex = -1;
            textBoxGrupo.Clear();
            textBoxSalon.Clear();
            dtpFechaAsig.Value = DateTime.Now;
            dtpFechaFin.Checked = false;
            cmbEstado.SelectedIndex = -1;
        }

        private void CargarListaAsignaciones()
        {
            try
            {
                DataTable dt = new Conexion(new clAsignacionMaestroMateria(0).BuscarActivas())
                    .CONSULTAR().Tables["Tabla"];

                // Opcional: cargar en un DataGridView si existe
                // dgvAsignaciones.DataSource = dt;
            }
            catch { }
        }

        private void FRMAsignacionMaestroMateria_Load(object sender, EventArgs e)
        {
            CargarListaAsignaciones();
        }
    }
}
