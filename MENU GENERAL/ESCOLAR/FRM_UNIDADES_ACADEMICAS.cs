using MENU_GENERAL.CLASES;
using MENU_GENERAL.ESCOLAR.MENU_GENERAL.CLASES;
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
    public partial class FRM_UNIDADES_ACADEMICAS : FRMCatalogoBase
    {
        public FRM_UNIDADES_ACADEMICAS()
        {
            InitializeComponent();
            Configurar("UNIDADES ACADÉMICAS", "Clave de unidad", "Nombre de la unidad");
        }

        protected override ICatalogo Crear(int clave, string nombre)
        {
            return new clUnidadAcademica(clave, nombre);
        }
    }
}