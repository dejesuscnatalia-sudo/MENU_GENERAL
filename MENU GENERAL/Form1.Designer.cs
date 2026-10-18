namespace MENU_GENERAL
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oPERACIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mULTIPLICACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dIVISIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cALCULADORAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fIGURASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRAPECIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rOMBOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rECTANGULOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRIANGULOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eSCOLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._carreraSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTRARMAESTROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._carreraSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dEPARTAMENTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mATERIASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPERACIONESToolStripMenuItem,
            this.fIGURASToolStripMenuItem,
            this.eSCOLARToolStripMenuItem,
            this.sALIRToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oPERACIONESToolStripMenuItem
            // 
            this.oPERACIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sUMAToolStripMenuItem,
            this.rESTAToolStripMenuItem,
            this.mULTIPLICACIONToolStripMenuItem,
            this.dIVISIONToolStripMenuItem,
            this.cALCULADORAToolStripMenuItem});
            this.oPERACIONESToolStripMenuItem.Name = "oPERACIONESToolStripMenuItem";
            this.oPERACIONESToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.oPERACIONESToolStripMenuItem.Text = "OPERACIONES";
            // 
            // sUMAToolStripMenuItem
            // 
            this.sUMAToolStripMenuItem.Name = "sUMAToolStripMenuItem";
            this.sUMAToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.sUMAToolStripMenuItem.Text = "SUMA";
            this.sUMAToolStripMenuItem.Click += new System.EventHandler(this.sUMAToolStripMenuItem_Click);
            // 
            // rESTAToolStripMenuItem
            // 
            this.rESTAToolStripMenuItem.Name = "rESTAToolStripMenuItem";
            this.rESTAToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.rESTAToolStripMenuItem.Text = "RESTA";
            this.rESTAToolStripMenuItem.Click += new System.EventHandler(this.rESTAToolStripMenuItem_Click);
            // 
            // mULTIPLICACIONToolStripMenuItem
            // 
            this.mULTIPLICACIONToolStripMenuItem.Name = "mULTIPLICACIONToolStripMenuItem";
            this.mULTIPLICACIONToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.mULTIPLICACIONToolStripMenuItem.Text = "MULTIPLICACION";
            this.mULTIPLICACIONToolStripMenuItem.Click += new System.EventHandler(this.mULTIPLICACIONToolStripMenuItem_Click);
            // 
            // dIVISIONToolStripMenuItem
            // 
            this.dIVISIONToolStripMenuItem.Name = "dIVISIONToolStripMenuItem";
            this.dIVISIONToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.dIVISIONToolStripMenuItem.Text = "DIVISION";
            this.dIVISIONToolStripMenuItem.Click += new System.EventHandler(this.dIVISIONToolStripMenuItem_Click);
            // 
            // cALCULADORAToolStripMenuItem
            // 
            this.cALCULADORAToolStripMenuItem.Name = "cALCULADORAToolStripMenuItem";
            this.cALCULADORAToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.cALCULADORAToolStripMenuItem.Text = "CALCULADORA";
            this.cALCULADORAToolStripMenuItem.Click += new System.EventHandler(this.cALCULADORAToolStripMenuItem_Click);
            // 
            // fIGURASToolStripMenuItem
            // 
            this.fIGURASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tRAPECIOToolStripMenuItem,
            this.rOMBOToolStripMenuItem,
            this.rECTANGULOToolStripMenuItem,
            this.tRIANGULOToolStripMenuItem});
            this.fIGURASToolStripMenuItem.Name = "fIGURASToolStripMenuItem";
            this.fIGURASToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.fIGURASToolStripMenuItem.Text = "FIGURAS";
            // 
            // tRAPECIOToolStripMenuItem
            // 
            this.tRAPECIOToolStripMenuItem.Name = "tRAPECIOToolStripMenuItem";
            this.tRAPECIOToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.tRAPECIOToolStripMenuItem.Text = "TRAPECIO";
            // 
            // rOMBOToolStripMenuItem
            // 
            this.rOMBOToolStripMenuItem.Name = "rOMBOToolStripMenuItem";
            this.rOMBOToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.rOMBOToolStripMenuItem.Text = "ROMBO";
            // 
            // rECTANGULOToolStripMenuItem
            // 
            this.rECTANGULOToolStripMenuItem.Name = "rECTANGULOToolStripMenuItem";
            this.rECTANGULOToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.rECTANGULOToolStripMenuItem.Text = "RECTANGULO";
            // 
            // tRIANGULOToolStripMenuItem
            // 
            this.tRIANGULOToolStripMenuItem.Name = "tRIANGULOToolStripMenuItem";
            this.tRIANGULOToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.tRIANGULOToolStripMenuItem.Text = "TRIANGULO";
            // 
            // eSCOLARToolStripMenuItem
            // 
            this.eSCOLARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._carreraSToolStripMenuItem,
            this.rEGISTRARMAESTROSToolStripMenuItem,
            this._carreraSToolStripMenuItem1,
            this.dEPARTAMENTOSToolStripMenuItem,
            this.mATERIASToolStripMenuItem});
            this.eSCOLARToolStripMenuItem.Name = "eSCOLARToolStripMenuItem";
            this.eSCOLARToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.eSCOLARToolStripMenuItem.Text = "ESCOLAR";
            // 
            // _carreraSToolStripMenuItem
            // 
            this._carreraSToolStripMenuItem.Name = "_carreraSToolStripMenuItem";
            this._carreraSToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this._carreraSToolStripMenuItem.Text = "REGISTRAR ALUMNOS";
            this._carreraSToolStripMenuItem.Click += new System.EventHandler(this._carreraSToolStripMenuItem_Click);
            // 
            // rEGISTRARMAESTROSToolStripMenuItem
            // 
            this.rEGISTRARMAESTROSToolStripMenuItem.Name = "rEGISTRARMAESTROSToolStripMenuItem";
            this.rEGISTRARMAESTROSToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.rEGISTRARMAESTROSToolStripMenuItem.Text = "REGISTRAR MAESTROS";
            this.rEGISTRARMAESTROSToolStripMenuItem.Click += new System.EventHandler(this.rEGISTRARMAESTROSToolStripMenuItem_Click);
            // 
            // _carreraSToolStripMenuItem1
            // 
            this._carreraSToolStripMenuItem1.Name = "_carreraSToolStripMenuItem1";
            this._carreraSToolStripMenuItem1.Size = new System.Drawing.Size(246, 26);
            this._carreraSToolStripMenuItem1.Text = "CARRERAS";
            this._carreraSToolStripMenuItem1.Click += new System.EventHandler(this._carreraSToolStripMenuItem1_Click);
            // 
            // dEPARTAMENTOSToolStripMenuItem
            // 
            this.dEPARTAMENTOSToolStripMenuItem.Name = "dEPARTAMENTOSToolStripMenuItem";
            this.dEPARTAMENTOSToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.dEPARTAMENTOSToolStripMenuItem.Text = "DEPARTAMENTOS";
            // 
            // mATERIASToolStripMenuItem
            // 
            this.mATERIASToolStripMenuItem.Name = "mATERIASToolStripMenuItem";
            this.mATERIASToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.mATERIASToolStripMenuItem.Text = "MATERIAS";
            this.mATERIASToolStripMenuItem.Click += new System.EventHandler(this.mATERIASToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem1
            // 
            this.sALIRToolStripMenuItem1.Name = "sALIRToolStripMenuItem1";
            this.sALIRToolStripMenuItem1.Size = new System.Drawing.Size(61, 24);
            this.sALIRToolStripMenuItem1.Text = "SALIR";
            this.sALIRToolStripMenuItem1.Click += new System.EventHandler(this.sALIRToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oPERACIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rESTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mULTIPLICACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dIVISIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cALCULADORAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fIGURASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRAPECIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rOMBOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rECTANGULOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRIANGULOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eSCOLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem _carreraSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEGISTRARMAESTROSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _carreraSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dEPARTAMENTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mATERIASToolStripMenuItem;
    }
}

