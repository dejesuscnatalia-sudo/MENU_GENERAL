
using MENU_GENERAL.CLASES;
using System;
using System.Windows.Forms;

namespace MENU_GENERAL.ESCOLAR
{
    public partial class FRM_TURNO : FRMCatalogoBase
    {
        public FRM_TURNO()
        {
            InitializeComponent();
            Configurar("TURNOS", "Clave de turno", "Nombre del turno");
        }

        protected override ICatalogo Crear(int clave, string nombre)
        {
            return new clTurno(clave, nombre);
        }
    }
}
