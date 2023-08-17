namespace LeerArchivoSecuencial
{
    partial class LeerArchivoSecuencialForm
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
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(61, 223);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(109, 23);
            this.btnAbrir.TabIndex = 8;
            this.btnAbrir.Text = "Abrir archivo";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Enabled = false;
            this.btnSiguiente.Location = new System.Drawing.Point(259, 223);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(109, 23);
            this.btnSiguiente.TabIndex = 9;
            this.btnSiguiente.Text = "Siguiente registro";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // LeerArchivoSecuencialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 269);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAbrir);
            this.Name = "LeerArchivoSecuencialForm";
            this.Text = "Leer un archivo secuencial";
            this.Controls.SetChildIndex(this.btnAbrir, 0);
            this.Controls.SetChildIndex(this.btnSiguiente, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnSiguiente;
    }
}

