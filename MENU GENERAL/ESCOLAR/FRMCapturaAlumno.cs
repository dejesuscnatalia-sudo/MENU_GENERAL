using MENU_GENERAL.CLASES;
using System;
using System.Data;
using System.Windows.Forms;

namespace MENU_GENERAL.REGISTRO_ALUMNOS
{
    public partial class FRMCapturaAlumno : Form
    {
        Alumno[] RegistroAlumno = new Alumno[10];
        int contador = 0;

        public FRMCapturaAlumno()
        {
            InitializeComponent();
            CargarCarreras();
            textBox2.Leave += textBox2_Leave;      // al salir de Matrícula, busca
        }

        private void CargarCarreras()
        {
            new Conexion("Select idCarrera, carrera from tbl_Carreras order by carrera")
                .LlenarCombo(comboBox1, "idCarrera", "carrera");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "" || textBox1.Text.Trim() == "" || comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Captura matrícula, nombre y carrera.");
                return;
            }

            Alumno alumno = new Alumno(textBox2.Text.Trim(), textBox1.Text.Trim(),
                Convert.ToInt32(comboBox1.SelectedValue), textBox4.Text.Trim(), textBox3.Text.Trim());

            DataSet ds = new Conexion(alumno.Buscar()).CONSULTAR();
            if (ds.Tables["Tabla"].Rows.Count > 0)
            {
                new Conexion(alumno.Modificar()).EJECUTAR();
                MessageBox.Show("Alumno modificado con éxito");
            }
            else
            {
                new Conexion(alumno.Guardar()).EJECUTAR();
                MessageBox.Show("Alumno guardado con éxito");
            }

            lstHistorial.Items.Add(alumno.ObtenerDatos(comboBox1.Text));
            if (contador < RegistroAlumno.Length)
            {
                alumno.GuardarEnArreglo(RegistroAlumno, contador);
                contador++;
            }

            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "") return;

            DataTable t = new Conexion(new Alumno(textBox2.Text.Trim()).Buscar()).CONSULTAR().Tables["Tabla"];
            if (t.Rows.Count > 0)
            {
                textBox1.Text = t.Rows[0]["nombre"].ToString();
                textBox3.Text = t.Rows[0]["correo"].ToString();
                textBox4.Text = t.Rows[0]["telefono"].ToString();
                if (t.Rows[0]["idCarrera"] != DBNull.Value)
                    comboBox1.SelectedValue = Convert.ToInt32(t.Rows[0]["idCarrera"]);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}

