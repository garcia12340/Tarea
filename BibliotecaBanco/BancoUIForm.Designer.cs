namespace BibliotecaBanco
{
    partial class BancoUIForm
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
            this.lblCuenta = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(48, 34);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(44, 13);
            this.lblCuenta.TabIndex = 0;
            this.lblCuenta.Text = "Cuenta:";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(162, 31);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(227, 20);
            this.txtCuenta.TabIndex = 1;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Location = new System.Drawing.Point(162, 74);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(227, 20);
            this.txtPrimerNombre.TabIndex = 3;
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.Location = new System.Drawing.Point(48, 77);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(79, 13);
            this.lblPrimerNombre.TabIndex = 2;
            this.lblPrimerNombre.Text = "Primer Nombre:";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(162, 120);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(227, 20);
            this.txtApellidoPaterno.TabIndex = 5;
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(48, 123);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(87, 13);
            this.lblApellidoPaterno.TabIndex = 4;
            this.lblApellidoPaterno.Text = "Apellido Paterno:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(162, 164);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(227, 20);
            this.txtSaldo.TabIndex = 7;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(48, 167);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 6;
            this.lblSaldo.Text = "Saldo:";
            // 
            // BancoUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 269);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.lblApellidoPaterno);
            this.Controls.Add(this.txtPrimerNombre);
            this.Controls.Add(this.lblPrimerNombre);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.lblCuenta);
            this.Name = "BancoUIForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.Label lblPrimerNombre;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblSaldo;
    }
}