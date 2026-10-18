using MENU_GENERAL.CLASES;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MENU_GENERAL.ESCOLAR
{
    public partial class FRMRespaldo : Form
    {
        public FRMRespaldo()
        {
            InitializeComponent();
        }

        private async void FRMRespaldo_Load(object sender, EventArgs e)
        {
            txtBD.Text = Global.bd;
            txtCarpeta.Text = @"C:\Respaldos_BD";
            await MostrarUltimoRespaldoAsync();
        }

        // Crea el objeto de negocio con los datos actuales del formulario
        private clRespaldo CrearRespaldo()
        {
            return new clRespaldo(txtBD.Text, txtCarpeta.Text);
        }

        private async void btnRespaldar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCarpeta.Text))
            {
                MessageBox.Show("Indique la carpeta donde se guardará el respaldo.",
                    "Respaldo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Ocupado(true, "Creando respaldo completo...");
            try
            {
                clRespaldo oRespaldo = CrearRespaldo();
                clInfoRespaldo info = await Task.Run(() => oRespaldo.RespaldarCompleto());

                Registrar("Respaldo creado y verificado: " + info.Ruta);
                MessageBox.Show("Respaldo creado con éxito:\n" + info.Ruta,
                    "Respaldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblUltimo.Text = "Último respaldo: " + info;
            }
            catch (Exception ex)
            {
                Registrar("ERROR al respaldar: " + ex.Message);
                MessageBox.Show(ex.Message, "Error al respaldar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Ocupado(false, "Listo");
            }
        }

        private async void btnRestaurar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Se reemplazará TODA la base de datos '" + txtBD.Text +
                "' con el último respaldo.\nLos cambios posteriores a ese respaldo se perderán.\n\n¿Desea continuar?",
                "Restaurar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r != DialogResult.Yes) return;

            Ocupado(true, "Restaurando último respaldo...");
            try
            {
                clRespaldo oRespaldo = CrearRespaldo();
                clInfoRespaldo info = await Task.Run(() => oRespaldo.RestaurarUltimo());

                Registrar("Base de datos restaurada desde: " + info.Ruta);
                MessageBox.Show("Restauración completada con éxito.\n" + info.Ruta,
                    "Restaurar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Registrar("ERROR al restaurar: " + ex.Message);
                MessageBox.Show(ex.Message, "Error al restaurar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Ocupado(false, "Listo");
            }
        }

        private async Task MostrarUltimoRespaldoAsync()
        {
            try
            {
                clRespaldo oRespaldo = CrearRespaldo();
                clInfoRespaldo info = await Task.Run(() => oRespaldo.ObtenerUltimoRespaldo());
                lblUltimo.Text = info == null
                    ? "Último respaldo: (ninguno registrado)"
                    : "Último respaldo: " + info;
            }
            catch (Exception ex)
            {
                lblUltimo.Text = "Último respaldo: no se pudo consultar";
                Registrar("ERROR al consultar: " + ex.Message);
            }
        }

        private void Registrar(string mensaje)
        {
            lstBitacora.Items.Add(DateTime.Now.ToString("HH:mm:ss") + "  " + mensaje);
            lstBitacora.TopIndex = lstBitacora.Items.Count - 1;
        }

        private void Ocupado(bool ocupado, string estado)
        {
            btnRespaldar.Enabled = !ocupado;
            btnRestaurar.Enabled = !ocupado;
            txtCarpeta.Enabled = !ocupado;
            barra.Visible = ocupado;
            lblEstado.Text = estado;
        }
    }
}
