using MENU_GENERAL.CLASES;
using MENU_GENERAL.ESCOLAR;
using MENU_GENERAL.REGISTRO_ALUMNOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MENU_GENERAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sUMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMSUMA oSUMA= new FRMSUMA();
            oSUMA.Show();

        }

        private void rESTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMRESTA oRESTA = new FRMRESTA();
            oRESTA.Show();
        }

        private void mULTIPLICACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMMULTIP oMulti= new FRMMULTIP();
            oMulti.Show();
        }

        private void dIVISIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMDIV oDiv= new FRMDIV();
            oDiv.Show();
        }

        private void cALCULADORAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMCALC oCalc = new FRMCALC();
            oCalc.Show();
        }

       
        private void _carreraSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMCapturaAlumno O = new FRMCapturaAlumno();
            O.Show();
        }

        private void rEGISTRARMAESTROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMMAESTROS oMaestro= new FRMMAESTROS();
            oMaestro.Show();
        }

        private void mATERIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
             FRMMaterias oMaterias= new FRMMaterias();
            oMaterias.Show();
        }

        private void _carreraSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_CARRERA oCarrera= new FRM_CARRERA();
            oCarrera.Show();
        }

        private void rESPALDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMRespaldo oRespaldo = new FRMRespaldo();
            oRespaldo.Show();
        }

        private void sALIRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dEPARTAMENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Departamentos o = new FRM_Departamentos();
            o.Show();
        }

        private void uNIDADESACADEMICASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_UNIDADES_ACADEMICAS o = new FRM_UNIDADES_ACADEMICAS();
            o.Show();
        }

        private void sEMESTRESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_SEMESTRES o = new FRM_SEMESTRES();
            o.Show();
        }

        private void tURNOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_TURNO o = new FRM_TURNO();
            o.Show();
        }
    }
}
