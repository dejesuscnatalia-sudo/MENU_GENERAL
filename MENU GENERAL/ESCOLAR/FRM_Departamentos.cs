using MENU_GENERAL.CLASES;
using System;
using System.Data;
using System.Windows.Forms;

namespace MENU_GENERAL.ESCOLAR
{
    public partial class FRM_Departamentos : FRMCatalogoBase
    {
        private ComboBox cmbUnidad;

        public FRM_Departamentos()
        {
            InitializeComponent();
            Configurar("DEPARTAMENTOS", "Clave de departamento", "Nombre del departamento");
            cmbUnidad = AgregarCombo("Unidad académica",
                "select Id_Unid_Acad, Nombre_unidad from Tbl_Unidades_Academicas order by Nombre_unidad",
                "Id_Unid_Acad", "Nombre_unidad");
        }

        protected override bool Validar()
        {
            return !Global.SeleccionVacia(cmbUnidad, "Unidad académica");
        }

        protected override ICatalogo Crear(int clave, string nombre)
        {
            int u = cmbUnidad.SelectedValue == null ? 0 : Convert.ToInt32(cmbUnidad.SelectedValue);
            return new clDepartamentos(clave, nombre, u);
        }

        protected override void AlEncontrar(DataRow fila)
        {
            Global.SeleccionarCombo(cmbUnidad, fila["Id_Unid_Acad"]);
        }

        protected override void LimpiarExtra()
        {
            cmbUnidad.SelectedIndex = -1;
        }
    }
}