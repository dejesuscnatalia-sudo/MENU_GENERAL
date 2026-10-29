using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MENU_GENERAL.CLASES
{
    internal class Global
    {
        static public string bd = "BD_ESCOLAR";
        static public string server = @"E5\S1";
        static public string User = "sa";
        static public string Password = "hola1234";
        static public string seguridad = "Persist Security Info=True";
        static public string miconexion = "Data Source=" + server + ";Initial Catalog=" + bd + ";" +
            seguridad + ";User ID=" + User + ";Password=" + Password + ";Encrypt=False";

        // Evita que un apóstrofe (O'Brien) rompa el INSERT/UPDATE
        static public string Esc(string s)
        {
            return (s ?? "").Replace("'", "''");
        }

        // Traduce los errores SQL más comunes (relaciones uno a muchos)
        static public string MensajeError(Exception ex)
        {
            SqlException sql = ex as SqlException;
            if (sql != null)
            {
                if (sql.Number == 547)
                    return "No se puede completar la operación por la relación con otros registros.\n" +
                           "- Al GUARDAR: verifique que el registro 'padre' (combo) exista.\n" +
                           "- Al ELIMINAR: primero elimine o reasigne los registros que dependen de éste.";
                if (sql.Number == 2627 || sql.Number == 2601)
                    return "Ya existe un registro con esa clave.";
            }
            return ex.Message;
        }

        // Ejecuta una acción y muestra el error amigable en vez de tumbar la aplicación
        static public void Proteger(Action accion)
        {
            try { accion(); }
            catch (Exception ex)
            {
                if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
                MessageBox.Show(MensajeError(ex), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static public void SeleccionarCombo(ComboBox cmb, object valor)
        {
            int id;
            if (valor == null || valor == DBNull.Value ||
                !int.TryParse(Convert.ToString(valor), out id))
            {
                cmb.SelectedIndex = -1;
                return;
            }
            cmb.SelectedValue = id;
        }

        static public bool LeerEntero(TextBox txt, string campo, out int valor)
        {
            if (!int.TryParse(txt.Text.Trim(), out valor))
            {
                MessageBox.Show("Capture un número válido en: " + campo, "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Focus();
                return false;
            }
            return true;
        }

        static public bool CampoVacio(Control ctl, string campo)
        {
            if (string.IsNullOrWhiteSpace(ctl.Text))
            {
                MessageBox.Show("Capture: " + campo, "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ctl.Focus();
                return true;
            }
            return false;
        }

        static public bool SeleccionVacia(ComboBox cmb, string campo)
        {
            if (cmb.SelectedIndex < 0 || cmb.SelectedValue == null)
            {
                MessageBox.Show("Seleccione: " + campo, "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb.Focus();
                return true;
            }
            return false;
        }
    }
}