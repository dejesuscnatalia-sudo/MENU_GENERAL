using MENU_GENERAL.CLASES;
using MENU_GENERAL.ESCOLAR;
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
    public partial class FRM_SEMESTRES : FRMCatalogoBase
    {
        public FRM_SEMESTRES()
        {
            InitializeComponent();
            Configurar("SEMESTRES", "Clave de semestre", "Nombre del semestre");
        }

        protected override ICatalogo Crear(int clave, string nombre)
        {
            return new clSemestre(clave, nombre);
        }
    }
}