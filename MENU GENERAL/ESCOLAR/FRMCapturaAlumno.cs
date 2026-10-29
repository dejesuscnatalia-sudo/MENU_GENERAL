using MENU_GENERAL.CLASES;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MENU_GENERAL.REGISTRO_ALUMNOS
{
    public partial class FRMCapturaAlumno : Form
    {
        Alumno[] RegistroAlumno = new Alumno[10];
        int contador = 0;
        private Button btnBuscar = new Button();
        private Button btnEliminar = new Button();

        public FRMCapturaAlumno()
        {
            InitializeComponent();

            // Botones nuevos creados por código (debajo de "Guardar Alumno")
            btnBuscar.Text = "Buscar Alumno";
            btnBuscar.Size = new Size(114, 26);
            btnBuscar.Location = new Point(507, 120);
            btnEliminar.Text = "Eliminar Alumno";
            btnEliminar.Size = new Size(114, 26);
            btnEliminar.Location = new Point(507, 156);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            btnBuscar.Click += (s, ev) => Global.Proteger(() => BuscarAlumno(true));
            btnEliminar.Click += (s, ev) => Global.Proteger(EliminarAlumno);

            Global.Proteger(CargarCarreras);
            textBox2.Leave += (s, ev) => Global.Proteger(() => BuscarAlumno(false));
        }

        private void CargarCarreras()
        {
            new Conexion("Select idCarrera, carrera from tbl_Carreras order by carrera")
                .LlenarCombo(comboBox1, "idCarrera", "carrera");
        }

        private void button1_Click(object sender, EventArgs e)    // GUARDAR
        {
            Global.Proteger(GuardarAlumno);
        }

        private void GuardarAlumno()
        {
            if (Global.CampoVacio(textBox2, "Matrícula") ||
                Global.CampoVacio(textBox1, "Nombre") ||
                Global.SeleccionVacia(comboBox1, "Carrera")) return;

            // Orden del constructor: matrícula, nombre, carrera, teléfono, correo
            Alumno alumno = new Alumno(textBox2.Text.Trim(), textBox1.Text.Trim(),
                Convert.ToInt32(comboBox1.SelectedValue), textBox4.Text.Trim(), textBox3.Text.Trim());

            bool existe = new Conexion(alumno.Buscar()).CONSULTAR().Tables["Tabla"].Rows.Count > 0;
            new Conexion(existe ? alumno.Modificar() : alumno.Guardar()).EJECUTAR();
            MessageBox.Show(existe ? "Alumno modificado con éxito" : "Alumno guardado con éxito");

            lstHistorial.Items.Add(alumno.ObtenerDatos(comboBox1.Text));
            if (contador < RegistroAlumno.Length)
            {
                alumno.GuardarEnArreglo(RegistroAlumno, contador);
                contador++;
            }
            LimpiarCampos();
        }

        private void BuscarAlumno(bool avisar)
        {
            if (textBox2.Text.Trim() == "")
            {
                if (avisar) MessageBox.Show("Capture la matrícula.");
                return;
            }

            DataTable t = new Conexion(new Alumno(textBox2.Text.Trim()).Buscar()).CONSULTAR().Tables["Tabla"];
            if (t.Rows.Count > 0)
            {
                textBox1.Text = t.Rows[0]["nombre"].ToString();
                textBox3.Text = t.Rows[0]["correo"].ToString();
                textBox4.Text = t.Rows[0]["telefono"].ToString();
                Global.SeleccionarCombo(comboBox1, t.Rows[0]["carrera"]);
            }
            else if (avisar)
            {
                MessageBox.Show("No existe este dato");
            }
        }

        private void EliminarAlumno()
        {
            if (Global.CampoVacio(textBox2, "Matrícula")) return;

            Alumno a = new Alumno(textBox2.Text.Trim());
            if (new Conexion(a.Buscar()).CONSULTAR().Tables["Tabla"].Rows.Count == 0)
            {
                MessageBox.Show("El registro no existe");
                return;
            }
            if (MessageBox.Show("¿Desea eliminar este alumno?", "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            new Conexion(a.Eliminar()).EJECUTAR();
            MessageBox.Show("El registro se borró correctamente");
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void label4_Click(object sender, EventArgs e) { }   // referenciado por el Designer
    }
}