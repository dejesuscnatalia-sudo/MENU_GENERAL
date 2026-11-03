using MENU_GENERAL.CLASES;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MENU_GENERAL.REGISTRO_ALUMNOS
{
    public partial class FRMCapturaAlumno : Form
    {
        
        
        public FRMCapturaAlumno()
        {
            InitializeComponent();

            
            
            toolStripButton1.Click += (s, ev) => Global.Proteger(GuardarAlumno);
            toolStripButton2.Click += (s, ev) => Global.Proteger(() => BuscarAlumno(true));
            toolStripButton3.Click += (s, ev) => Global.Proteger(EliminarAlumno);


            Global.Proteger(CargarCarreras);
            matrícula.Leave += (s, ev) => Global.Proteger(() => BuscarAlumno(false));
        }

        private void CargarCarreras()
        {
            new Conexion("Select idCarrera, carrera from tbl_Carreras order by carrera")
                .LlenarCombo(carrera, "idCarrera", "carrera");
        }

        private void guardar_Click(object sender, EventArgs e)    // GUARDAR
        {
            Global.Proteger(GuardarAlumno);
        }

        private void GuardarAlumno()
        {
            if (Global.CampoVacio(matrícula, "Matrícula") ||
                Global.CampoVacio(nombre, "Nombre") ||
                Global.SeleccionVacia(carrera, "Carrera")) return;

            // Orden del constructor: matrícula, nombre, carrera, teléfono, correo
            Alumno alumno = new Alumno(matrícula.Text.Trim(), nombre.Text.Trim(),
                Convert.ToInt32(carrera.SelectedValue), teléfono.Text.Trim(), correo.Text.Trim());

            bool existe = new Conexion(alumno.Buscar()).CONSULTAR().Tables["Tabla"].Rows.Count > 0;
            new Conexion(existe ? alumno.Modificar() : alumno.Guardar()).EJECUTAR();
            MessageBox.Show(existe ? "Alumno modificado con éxito" : "Alumno guardado con éxito");

            
            LimpiarCampos();
        }

        private void BuscarAlumno(bool avisar)
        {
           
            DataTable t = new Conexion(new Alumno(matrícula.Text.Trim()).Buscar()).CONSULTAR().Tables["Tabla"];
            if (t.Rows.Count > 0)
            {
                nombre.Text = t.Rows[0]["nombre"].ToString();
                correo.Text = t.Rows[0]["correo"].ToString();
                teléfono.Text = t.Rows[0]["telefono"].ToString();
                Global.SeleccionarCombo(carrera, t.Rows[0]["carrera"]);
            }
            else if (avisar)
            {
                MessageBox.Show("No existe este dato");
            }
        }

        private void EliminarAlumno()
        {
            if (Global.CampoVacio(matrícula, "Matrícula")) return;

            Alumno a = new Alumno(matrícula.Text.Trim());
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
            nombre.Clear(); matrícula.Clear(); correo.Clear(); teléfono.Clear();
            carrera.SelectedIndex = -1;
        }

        private void label4_Click(object sender, EventArgs e) { }   // referenciado por el Designer

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Global.Proteger(GuardarAlumno);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Global.Proteger(() => BuscarAlumno(true));
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Global.Proteger(EliminarAlumno);
        }

        

        
        
    }
}