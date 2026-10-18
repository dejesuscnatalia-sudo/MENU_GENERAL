using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MENU_GENERAL.REGISTRO_ALUMNOS
{
    public partial class FRMCapturaAlumno : Form
    {
        public FRMCapturaAlumno()
        {
            InitializeComponent();
        }

        Alumno[] RegistroAlumno =new Alumno[10];
        int contador = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (contador< RegistroAlumno.Length)
            {
                Alumno nuevoAlumno= new Alumno(textBox1.Text, textBox2.Text, comboBox1.Text);
                nuevoAlumno.GuardarEnArreglo(RegistroAlumno, contador);
                lstHistorial.Items.Add(nuevoAlumno.ObtenerDatos());
                contador ++;
            }*/
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
