using MENU_GENERAL.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MENU_GENERAL.ESCOLAR
{
    namespace MENU_GENERAL.CLASES
    {
        public interface ICatalogo
        {
            string Guardar();
            string Modificar();
            string Buscar();
            string Eliminar();
        }

        // No es abstracta a propósito: el diseñador de VS necesita poder instanciarla
        public class FRMCatalogoBase : Form
        {
            protected TextBox txtbClave = new TextBox();
            protected TextBox txtbNombre = new TextBox();
            private Label lblClave = new Label();
            private Label lblNombre = new Label();
            private Button btnGuardar = new Button();
            private Button btnBuscar = new Button();
            private Button btnEliminar = new Button();
            private Button btnLimpiar = new Button();

            public FRMCatalogoBase()
            {
                ClientSize = new Size(560, 260);
                StartPosition = FormStartPosition.CenterScreen;

                lblClave.AutoSize = true; lblClave.Location = new Point(40, 40);
                txtbClave.Location = new Point(200, 37); txtbClave.Width = 90;
                lblNombre.AutoSize = true; lblNombre.Location = new Point(40, 90);
                txtbNombre.Location = new Point(200, 87); txtbNombre.Width = 300;

                btnGuardar.Text = "Guardar"; btnGuardar.Location = new Point(40, 160);
                btnBuscar.Text = "Buscar"; btnBuscar.Location = new Point(160, 160);
                btnEliminar.Text = "Eliminar"; btnEliminar.Location = new Point(280, 160);
                btnLimpiar.Text = "Limpiar"; btnLimpiar.Location = new Point(400, 160);

                Controls.AddRange(new Control[] { lblClave, txtbClave, lblNombre, txtbNombre,
                                              btnGuardar, btnBuscar, btnEliminar, btnLimpiar });

                btnGuardar.Click += (s, e) => Registro();
                btnBuscar.Click += (s, e) => BuscarRegistro(true);
                btnEliminar.Click += (s, e) => EliminarRegistro();
                btnLimpiar.Click += (s, e) => { txtbClave.Clear(); txtbNombre.Clear(); txtbClave.Focus(); };
                txtbClave.Leave += (s, e) => BuscarRegistro(false);
            }

            // Cada formulario hijo lo llama en su constructor
            protected void Configurar(string titulo, string etiquetaClave, string etiquetaNombre)
            {
                Text = titulo;
                lblClave.Text = etiquetaClave;
                lblNombre.Text = etiquetaNombre;
                ClientSize = new Size(560, 260);
            }

            // Cada formulario hijo devuelve su clase (clTurno, clSemestre...)
            protected virtual ICatalogo Crear(int clave, string nombre)
            {
                throw new NotImplementedException();
            }

            private bool Ejecutar(string sql)
            {
                try
                {
                    new Conexion(sql).EJECUTAR();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo completar la operación:\n" + ex.Message);
                    return false;
                }
            }

            private void Registro()
            {
                int clave;
                if (!int.TryParse(txtbClave.Text.Trim(), out clave))
                {
                    MessageBox.Show("Captura una clave numérica.");
                    return;
                }
                if (txtbNombre.Text.Trim() == "")
                {
                    MessageBox.Show("Captura el nombre.");
                    return;
                }

                ICatalogo o = Crear(clave, txtbNombre.Text.Trim());
                DataSet ds = new Conexion(o.Buscar()).CONSULTAR();

                if (ds.Tables["Tabla"].Rows.Count > 0)
                {
                    if (Ejecutar(o.Modificar())) MessageBox.Show("Registro modificado con éxito");
                }
                else
                {
                    if (Ejecutar(o.Guardar())) MessageBox.Show("Registro guardado con éxito");
                }
            }

            private void BuscarRegistro(bool avisar)
            {
                int clave;
                if (!int.TryParse(txtbClave.Text.Trim(), out clave))
                {
                    if (avisar) MessageBox.Show("Captura una clave numérica.");
                    return;
                }

                DataTable t = new Conexion(Crear(clave, "").Buscar()).CONSULTAR().Tables["Tabla"];
                if (t.Rows.Count > 0)
                    txtbNombre.Text = t.Rows[0][1].ToString();   // 2ª columna = nombre
                else if (avisar)
                    MessageBox.Show("No existe este dato");
            }

            private void EliminarRegistro()
            {
                int clave;
                if (!int.TryParse(txtbClave.Text.Trim(), out clave))
                {
                    MessageBox.Show("Captura una clave numérica.");
                    return;
                }

                ICatalogo o = Crear(clave, "");
                DataSet ds = new Conexion(o.Buscar()).CONSULTAR();
                if (ds.Tables["Tabla"].Rows.Count == 0)
                {
                    MessageBox.Show("El registro no existe");
                    return;
                }

                if (MessageBox.Show("¿Desea eliminar este registro?", "Eliminar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Ejecutar(o.Eliminar()))
                    {
                        MessageBox.Show("El registro se borró correctamente");
                        txtbClave.Clear(); txtbNombre.Clear();
                    }
                }
            }
        }
    }
}
