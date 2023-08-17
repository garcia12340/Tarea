namespace CrearArchivo
{
    partial class CrearArchivoForm
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnIntroducir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(30, 214);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 38);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar como";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnIntroducir
            // 
            this.btnIntroducir.Enabled = false;
            this.btnIntroducir.Location = new System.Drawing.Point(162, 214);
            this.btnIntroducir.Name = "btnIntroducir";
            this.btnIntroducir.Size = new System.Drawing.Size(84, 38);
            this.btnIntroducir.TabIndex = 9;
            this.btnIntroducir.Text = "Introducir";
            this.btnIntroducir.UseVisualStyleBackColor = true;
            this.btnIntroducir.Click += new System.EventHandler(this.BtnIntroducir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(297, 214);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 38);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // CrearArchivoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 264);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIntroducir);
            this.Controls.Add(this.btnGuardar);
            this.Name = "CrearArchivoForm";
            this.Text = "Creación de un archivo secuencial";
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnIntroducir, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnIntroducir;
        private System.Windows.Forms.Button btnSalir;
    }
}

