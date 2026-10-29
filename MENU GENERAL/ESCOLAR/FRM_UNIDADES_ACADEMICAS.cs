using MENU_GENERAL.CLASES;
using System;
using System.Data;
using System.Windows.Forms;

namespace MENU_GENERAL.ESCOLAR
{
    public partial class FRM_UNIDADES_ACADEMICAS : FRMCatalogoBase
    {
        private ComboBox cmbMunicipio;

        public FRM_UNIDADES_ACADEMICAS()
        {
            InitializeComponent();
            Configurar("UNIDADES ACADÉMICAS", "Clave de unidad", "Nombre de la unidad");
            cmbMunicipio = AgregarCombo("Municipio",
                "select Id_Municipio, Nombre_municipio from Tbl_Municipios order by Nombre_municipio",
                "Id_Municipio", "Nombre_municipio");
        }

        protected override bool Validar()
        {
            return !Global.SeleccionVacia(cmbMunicipio, "Municipio");
        }

        protected override ICatalogo Crear(int clave, string nombre)
        {
            int m = cmbMunicipio.SelectedValue == null ? 0 : Convert.ToInt32(cmbMunicipio.SelectedValue);
            return new clUnidAcad(clave, nombre, m);
        }

        protected override void AlEncontrar(DataRow fila)
        {
            Global.SeleccionarCombo(cmbMunicipio, fila["id_Municipio"]);
        }

        protected override void LimpiarExtra()
        {
            cmbMunicipio.SelectedIndex = -1;
        }
    }
}