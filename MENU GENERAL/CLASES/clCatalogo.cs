using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MENU_GENERAL.CLASES
{
    public interface ICatalogo
    {
        string Guardar();
        string Modificar();
        string Buscar();
        string Eliminar();
        string Existe();   // ¿existe la clave? (decide entre INSERT y UPDATE)
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
            lblNombre.AutoSize = true; lblNombre.Location = new Point(40, 85);
            txtbNombre.Location = new Point(200, 82); txtbNombre.Width = 300;

            btnGuardar.Text = "Guardar"; btnGuardar.Location = new Point(40, 190);
            btnBuscar.Text = "Buscar"; btnBuscar.Location = new Point(160, 190);
            btnEliminar.Text = "Eliminar"; btnEliminar.Location = new Point(280, 190);
            btnLimpiar.Text = "Limpiar"; btnLimpiar.Location = new Point(400, 190);

            Controls.AddRange(new Control[] { lblClave, txtbClave, lblNombre, txtbNombre,
                                              btnGuardar, btnBuscar, btnEliminar, btnLimpiar });

            btnGuardar.Click += (s, e) => Global.Proteger(Registro);
            btnBuscar.Click += (s, e) => Global.Proteger(() => BuscarRegistro(true));
            btnEliminar.Click += (s, e) => Global.Proteger(EliminarRegistro);
            btnLimpiar.Click += (s, e) => Limpiar();
            txtbClave.Leave += (s, e) => Global.Proteger(() => BuscarRegistro(false));
        }

        // Cada formulario hijo lo llama en su constructor
        protected void Configurar(string titulo, string etiquetaClave, string etiquetaNombre)
        {
            Text = titulo;
            lblClave.Text = etiquetaClave;
            lblNombre.Text = etiquetaNombre;
        }

        // Agrega un combo con el registro "padre" (relación 1 a N)
        protected ComboBox AgregarCombo(string etiqueta, string sql, string valor, string texto)
        {
            Label lbl = new Label();
            lbl.Text = etiqueta; lbl.AutoSize = true; lbl.Location = new Point(40, 130);
            ComboBox cmb = new ComboBox();
            cmb.Location = new Point(200, 127); cmb.Width = 300;
            Controls.Add(lbl);
            Controls.Add(cmb);
            Global.Proteger(() => new Conexion(sql).LlenarCombo(cmb, valor, texto));
            return cmb;
        }

        // ---- Puntos de extensión para los formularios hijos ----
        protected virtual ICatalogo Crear(int clave, string nombre)
        {
            throw new NotImplementedException();
        }
        protected virtual bool Validar() { return true; }
        protected virtual void AlEncontrar(DataRow fila) { }
        protected virtual void LimpiarExtra() { }

        private void Limpiar()
        {
            txtbClave.Clear();
            txtbNombre.Clear();
            LimpiarExtra();
            txtbClave.Focus();
        }

        private void Registro()
        {
            int clave;
            if (!Global.LeerEntero(txtbClave, "Clave", out clave)) return;
            if (Global.CampoVacio(txtbNombre, "Nombre")) return;
            if (!Validar()) return;

            ICatalogo o = Crear(clave, txtbNombre.Text.Trim());
            bool existe = new Conexion(o.Existe()).CONSULTAR().Tables["Tabla"].Rows.Count > 0;

            if (existe)
            {
                new Conexion(o.Modificar()).EJECUTAR();
                MessageBox.Show("Registro modificado con éxito");
            }
            else
            {
                new Conexion(o.Guardar()).EJECUTAR();
                MessageBox.Show("Registro guardado con éxito");
            }
        }

        private void BuscarRegistro(bool avisar)
        {
            int clave;
            if (!int.TryParse(txtbClave.Text.Trim(), out clave))
            {
                if (avisar) MessageBox.Show("Capture una clave numérica.");
                return;
            }

            DataTable t = new Conexion(Crear(clave, "").Buscar()).CONSULTAR().Tables["Tabla"];
            if (t.Rows.Count > 0)
            {
                txtbNombre.Text = t.Rows[0][1].ToString();   // 2ª columna = nombre
                AlEncontrar(t.Rows[0]);
            }
            else if (avisar)
            {
                MessageBox.Show("No existe este dato");
            }
        }

        private void EliminarRegistro()
        {
            int clave;
            if (!Global.LeerEntero(txtbClave, "Clave", out clave)) return;

            ICatalogo o = Crear(clave, "");
            if (new Conexion(o.Buscar()).CONSULTAR().Tables["Tabla"].Rows.Count == 0)
            {
                MessageBox.Show("El registro no existe");
                return;
            }

            if (MessageBox.Show("¿Desea eliminar este registro?", "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new Conexion(o.Eliminar()).EJECUTAR();
                MessageBox.Show("El registro se borró correctamente");
                Limpiar();
            }
        }
    }
}