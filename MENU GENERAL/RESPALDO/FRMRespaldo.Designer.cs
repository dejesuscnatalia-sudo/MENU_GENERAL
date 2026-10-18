namespace MENU_GENERAL.ESCOLAR
{
    partial class FRMRespaldo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBD = new System.Windows.Forms.TextBox();
            this.txtCarpeta = new System.Windows.Forms.TextBox();
            this.btnRespaldar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.lblUltimo = new System.Windows.Forms.Label();
            this.lstBitacora = new System.Windows.Forms.ListBox();
            this.barra = new System.Windows.Forms.ProgressBar();
            this.lblEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base de datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carpeta de respaldos (servidor)";
            // 
            // txtBD
            // 
            this.txtBD.Location = new System.Drawing.Point(250, 25);
            this.txtBD.Name = "txtBD";
            this.txtBD.ReadOnly = true;
            this.txtBD.Size = new System.Drawing.Size(200, 22);
            this.txtBD.TabIndex = 2;
            this.txtBD.TextChanged += new System.EventHandler(this.txtBD_TextChanged);
            // 
            // txtCarpeta
            // 
            this.txtCarpeta.Location = new System.Drawing.Point(250, 65);
            this.txtCarpeta.Name = "txtCarpeta";
            this.txtCarpeta.Size = new System.Drawing.Size(320, 22);
            this.txtCarpeta.TabIndex = 3;
            // 
            // btnRespaldar
            // 
            this.btnRespaldar.Location = new System.Drawing.Point(33, 110);
            this.btnRespaldar.Name = "btnRespaldar";
            this.btnRespaldar.Size = new System.Drawing.Size(250, 36);
            this.btnRespaldar.TabIndex = 4;
            this.btnRespaldar.Text = "Crear respaldo completo";
            this.btnRespaldar.UseVisualStyleBackColor = true;
            this.btnRespaldar.Click += new System.EventHandler(this.btnRespaldar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(320, 110);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(250, 36);
            this.btnRestaurar.TabIndex = 5;
            this.btnRestaurar.Text = "Restaurar último respaldo";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // lblUltimo
            // 
            this.lblUltimo.AutoSize = true;
            this.lblUltimo.Location = new System.Drawing.Point(30, 165);
            this.lblUltimo.Name = "lblUltimo";
            this.lblUltimo.Size = new System.Drawing.Size(117, 16);
            this.lblUltimo.TabIndex = 6;
            this.lblUltimo.Text = "Último respaldo: ...";
            // 
            // lstBitacora
            // 
            this.lstBitacora.FormattingEnabled = true;
            this.lstBitacora.HorizontalScrollbar = true;
            this.lstBitacora.ItemHeight = 16;
            this.lstBitacora.Location = new System.Drawing.Point(33, 195);
            this.lstBitacora.Name = "lstBitacora";
            this.lstBitacora.Size = new System.Drawing.Size(537, 148);
            this.lstBitacora.TabIndex = 7;
            // 
            // barra
            // 
            this.barra.Location = new System.Drawing.Point(33, 360);
            this.barra.MarqueeAnimationSpeed = 30;
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(537, 18);
            this.barra.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.barra.TabIndex = 8;
            this.barra.Visible = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(30, 390);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(35, 16);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Listo";
            // 
            // FRMRespaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(610, 425);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.lstBitacora);
            this.Controls.Add(this.lblUltimo);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnRespaldar);
            this.Controls.Add(this.txtCarpeta);
            this.Controls.Add(this.txtBD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FRMRespaldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Respaldo y recuperación de BD";
            this.Load += new System.EventHandler(this.FRMRespaldo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBD;
        private System.Windows.Forms.TextBox txtCarpeta;
        private System.Windows.Forms.Button btnRespaldar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Label lblUltimo;
        private System.Windows.Forms.ListBox lstBitacora;
        private System.Windows.Forms.ProgressBar barra;
        private System.Windows.Forms.Label lblEstado;
    }
}
