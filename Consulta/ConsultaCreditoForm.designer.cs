namespace Consulta
{
    partial class ConsultaCredito
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
            this.btnCredito = new System.Windows.Forms.Button();
            this.btnSaldoCero = new System.Windows.Forms.Button();
            this.btnDebito = new System.Windows.Forms.Button();
            this.terminarButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(12, 222);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(109, 36);
            this.btnAbrir.TabIndex = 10;
            this.btnAbrir.Text = "Abrir  Archivo";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnCredito
            // 
            this.btnCredito.Enabled = false;
            this.btnCredito.Location = new System.Drawing.Point(157, 222);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(109, 36);
            this.btnCredito.TabIndex = 11;
            this.btnCredito.Text = "Saldos con credito";
            this.btnCredito.UseVisualStyleBackColor = true;
            // 
            // btnSaldoCero
            // 
            this.btnSaldoCero.Enabled = false;
            this.btnSaldoCero.Location = new System.Drawing.Point(458, 222);
            this.btnSaldoCero.Name = "btnSaldoCero";
            this.btnSaldoCero.Size = new System.Drawing.Size(109, 36);
            this.btnSaldoCero.TabIndex = 12;
            this.btnSaldoCero.Text = "Saldos en cero";
            this.btnSaldoCero.UseVisualStyleBackColor = true;
            // 
            // btnDebito
            // 
            this.btnDebito.Enabled = false;
            this.btnDebito.Location = new System.Drawing.Point(308, 222);
            this.btnDebito.Name = "btnDebito";
            this.btnDebito.Size = new System.Drawing.Size(109, 36);
            this.btnDebito.TabIndex = 13;
            this.btnDebito.Text = "Saldos con debito";
            this.btnDebito.UseVisualStyleBackColor = true;
            // 
            // terminarButton
            // 
            this.terminarButton.Enabled = false;
            this.terminarButton.Location = new System.Drawing.Point(605, 222);
            this.terminarButton.Name = "terminarButton";
            this.terminarButton.Size = new System.Drawing.Size(109, 36);
            this.terminarButton.TabIndex = 14;
            this.terminarButton.Text = "Salir";
            this.terminarButton.UseVisualStyleBackColor = true;
            this.terminarButton.Click += new System.EventHandler(this.terminarButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(702, 203);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // ConsultaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 276);
            this.Controls.Add(this.terminarButton);
            this.Controls.Add(this.btnDebito);
            this.Controls.Add(this.btnSaldoCero);
            this.Controls.Add(this.btnCredito);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.richTextBox1);
            this.Name = "ConsultaCredito";
            this.Text = "ConsultaCreditoForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnCredito;
        private System.Windows.Forms.Button btnSaldoCero;
        private System.Windows.Forms.Button btnDebito;
        private System.Windows.Forms.Button terminarButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}