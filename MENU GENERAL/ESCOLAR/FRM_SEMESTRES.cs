using MENU_GENERAL.CLASES;
using System;
using System.Windows.Forms;

namespace MENU_GENERAL.ESCOLAR
{
    public partial class FRM_SEMESTRES : FRMCatalogoBase
    {
        public FRM_SEMESTRES()
        {
            InitializeComponent();
            Configurar("SEMESTRES", "Clave de semestre", "Nombre del semestre");
        }

        protected override ICatalogo Crear(int clave, string nombre)
        {
            return new clSemestres(clave, nombre);
        }
    }
}