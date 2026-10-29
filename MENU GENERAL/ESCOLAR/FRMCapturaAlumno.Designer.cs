namespace MENU_GENERAL.REGISTRO_ALUMNOS
{
    partial class FRMCapturaAlumno
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
            this.nombre = new System.Windows.Forms.TextBox();
            this.matrícula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.carrera = new System.Windows.Forms.ComboBox();
            this.guardar = new System.Windows.Forms.Button();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.teléfono = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(251, 45);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 22);
            this.nombre.TabIndex = 0;
            // 
            // matrícula
            // 
            this.matrícula.Location = new System.Drawing.Point(251, 88);
            this.matrícula.Name = "matrícula";
            this.matrícula.Size = new System.Drawing.Size(100, 22);
            this.matrícula.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Matrícula";
            // 
            // carrera
            // 
            this.carrera.FormattingEnabled = true;
            this.carrera.Items.AddRange(new object[] {
            "Ingeniería en Sistemas",
            "Ingeniería Industrial",
            "Ingeniería en Software",
            "Ingeniería Ambiental"});
            this.carrera.Location = new System.Drawing.Point(251, 128);
            this.carrera.Name = "carrera";
            this.carrera.Size = new System.Drawing.Size(200, 24);
            this.carrera.TabIndex = 4;
            this.carrera.Text = "Seleccionar carrera";
            // 
            // guardar
            // 
            this.guardar.AutoSize = true;
            this.guardar.Location = new System.Drawing.Point(507, 84);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(114, 26);
            this.guardar.TabIndex = 5;
            this.guardar.Text = "Guardar Alumno";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // lstHistorial
            // 
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.ItemHeight = 16;
            this.lstHistorial.Location = new System.Drawing.Point(123, 328);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(300, 84);
            this.lstHistorial.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Carrera";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Correo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(251, 176);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(100, 22);
            this.correo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Teléfono";
            // 
            // teléfono
            // 
            this.teléfono.Location = new System.Drawing.Point(251, 215);
            this.teléfono.Name = "teléfono";
            this.teléfono.Size = new System.Drawing.Size(100, 22);
            this.teléfono.TabIndex = 10;
            // 
            // FRMCapturaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.teléfono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstHistorial);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.carrera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matrícula);
            this.Controls.Add(this.nombre);
            this.Name = "FRMCapturaAlumno";
            this.Text = "FRMCapturaAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox matrícula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox carrera;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.ListBox lstHistorial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox teléfono;
    }
}