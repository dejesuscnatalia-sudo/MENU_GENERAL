namespace MENU_GENERAL.ESCOLAR
{
    partial class FRMAsignacionMaestroMateria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMAsignacionMaestroMateria));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxIdAsignacion = new System.Windows.Forms.TextBox();
            this.textBoxGrupo = new System.Windows.Forms.TextBox();
            this.textBoxSalon = new System.Windows.Forms.TextBox();
            this.cmbMaestros = new System.Windows.Forms.ComboBox();
            this.cmbMaterias = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.dtpFechaAsig = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.savebtn = new System.Windows.Forms.ToolStripButton();
            this.registrarbtn = new System.Windows.Forms.ToolStripButton();
            this.borrarbtn = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Asignación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maestro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Materia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grupo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salón";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Asignación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha Fin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "(Marque si hay fecha fin)";
            // 
            // textBoxIdAsignacion
            // 
            this.textBoxIdAsignacion.Location = new System.Drawing.Point(172, 110);
            this.textBoxIdAsignacion.Name = "textBoxIdAsignacion";
            this.textBoxIdAsignacion.Size = new System.Drawing.Size(100, 22);
            this.textBoxIdAsignacion.TabIndex = 9;
            // 
            // textBoxGrupo
            // 
            this.textBoxGrupo.Location = new System.Drawing.Point(172, 227);
            this.textBoxGrupo.Name = "textBoxGrupo";
            this.textBoxGrupo.Size = new System.Drawing.Size(150, 22);
            this.textBoxGrupo.TabIndex = 10;
            // 
            // textBoxSalon
            // 
            this.textBoxSalon.Location = new System.Drawing.Point(464, 227);
            this.textBoxSalon.Name = "textBoxSalon";
            this.textBoxSalon.Size = new System.Drawing.Size(150, 22);
            this.textBoxSalon.TabIndex = 11;
            // 
            // cmbMaestros
            // 
            this.cmbMaestros.FormattingEnabled = true;
            this.cmbMaestros.Location = new System.Drawing.Point(172, 149);
            this.cmbMaestros.Name = "cmbMaestros";
            this.cmbMaestros.Size = new System.Drawing.Size(328, 24);
            this.cmbMaestros.TabIndex = 12;
            // 
            // cmbMaterias
            // 
            this.cmbMaterias.FormattingEnabled = true;
            this.cmbMaterias.Location = new System.Drawing.Point(172, 188);
            this.cmbMaterias.Name = "cmbMaterias";
            this.cmbMaterias.Size = new System.Drawing.Size(328, 24);
            this.cmbMaterias.TabIndex = 13;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(172, 305);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(150, 24);
            this.cmbEstado.TabIndex = 14;
            // 
            // dtpFechaAsig
            // 
            this.dtpFechaAsig.Location = new System.Drawing.Point(172, 266);
            this.dtpFechaAsig.Name = "dtpFechaAsig";
            this.dtpFechaAsig.Size = new System.Drawing.Size(150, 22);
            this.dtpFechaAsig.TabIndex = 15;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Checked = false;
            this.dtpFechaFin.Location = new System.Drawing.Point(464, 266);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.ShowCheckBox = true;
            this.dtpFechaFin.Size = new System.Drawing.Size(150, 22);
            this.dtpFechaFin.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.registrarToolStripMenuItem.Text = "Registrar";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savebtn,
            this.registrarbtn,
            this.borrarbtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // savebtn
            // 
            this.savebtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.savebtn.Image = ((System.Drawing.Image)(resources.GetObject("savebtn.Image")));
            this.savebtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(39, 39);
            this.savebtn.Text = "toolStripButton1";
            this.savebtn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // registrarbtn
            // 
            this.registrarbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.registrarbtn.Image = ((System.Drawing.Image)(resources.GetObject("registrarbtn.Image")));
            this.registrarbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.registrarbtn.Name = "registrarbtn";
            this.registrarbtn.Size = new System.Drawing.Size(39, 39);
            this.registrarbtn.Text = "toolStripButton2";
            // 
            // borrarbtn
            // 
            this.borrarbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.borrarbtn.Image = ((System.Drawing.Image)(resources.GetObject("borrarbtn.Image")));
            this.borrarbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.borrarbtn.Name = "borrarbtn";
            this.borrarbtn.Size = new System.Drawing.Size(39, 39);
            this.borrarbtn.Text = "toolStripButton3";
            this.borrarbtn.Click += new System.EventHandler(this.borrarbtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(78, 20);
            this.toolStripStatusLabel1.Text = "USUARIO: ";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=E5\\\\S1;Initial Catalog=BD_ESCOLAR;User ID=sa;Password=hola1234;Encrypt" +
    "=False";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // FRMAsignacionMaestroMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaAsig);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbMaterias);
            this.Controls.Add(this.cmbMaestros);
            this.Controls.Add(this.textBoxSalon);
            this.Controls.Add(this.textBoxGrupo);
            this.Controls.Add(this.textBoxIdAsignacion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRMAsignacionMaestroMateria";
            this.Text = "ASIGNACIÓN MAESTRO - MATERIA";
            this.Load += new System.EventHandler(this.FRMAsignacionMaestroMateria_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxIdAsignacion;
        private System.Windows.Forms.TextBox textBoxGrupo;
        private System.Windows.Forms.TextBox textBoxSalon;
        private System.Windows.Forms.ComboBox cmbMaestros;
        private System.Windows.Forms.ComboBox cmbMaterias;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DateTimePicker dtpFechaAsig;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton savebtn;
        private System.Windows.Forms.ToolStripButton registrarbtn;
        private System.Windows.Forms.ToolStripButton borrarbtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
    }
}
