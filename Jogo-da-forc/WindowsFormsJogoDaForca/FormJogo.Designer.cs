namespace WindowsFormsJogoDaForca
{
    partial class FormJogo
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
            this.lbPalavraSecreta = new System.Windows.Forms.Label();
            this.txbTentativa = new System.Windows.Forms.TextBox();
            this.btnVerificarLetra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPalavraSecreta
            // 
            this.lbPalavraSecreta.AutoSize = true;
            this.lbPalavraSecreta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPalavraSecreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPalavraSecreta.Location = new System.Drawing.Point(111, 258);
            this.lbPalavraSecreta.Name = "lbPalavraSecreta";
            this.lbPalavraSecreta.Size = new System.Drawing.Size(62, 31);
            this.lbPalavraSecreta.TabIndex = 0;
            this.lbPalavraSecreta.Text = "???";
            // 
            // txbTentativa
            // 
            this.txbTentativa.Location = new System.Drawing.Point(12, 315);
            this.txbTentativa.Multiline = true;
            this.txbTentativa.Name = "txbTentativa";
            this.txbTentativa.Size = new System.Drawing.Size(230, 31);
            this.txbTentativa.TabIndex = 1;
            // 
            // btnVerificarLetra
            // 
            this.btnVerificarLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarLetra.Location = new System.Drawing.Point(277, 315);
            this.btnVerificarLetra.Name = "btnVerificarLetra";
            this.btnVerificarLetra.Size = new System.Drawing.Size(99, 31);
            this.btnVerificarLetra.TabIndex = 2;
            this.btnVerificarLetra.Text = "Verificar";
            this.btnVerificarLetra.UseVisualStyleBackColor = true;
            this.btnVerificarLetra.Click += new System.EventHandler(this.btnVerificarLetra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Qual é a Palavra Misteriosa ?";
            // 
            // FormJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsJogoDaForca.Properties.Resources.Cap;
            this.ClientSize = new System.Drawing.Size(428, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerificarLetra);
            this.Controls.Add(this.txbTentativa);
            this.Controls.Add(this.lbPalavraSecreta);
            this.Name = "FormJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Forca";
            this.Load += new System.EventHandler(this.FormJogo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPalavraSecreta;
        private System.Windows.Forms.TextBox txbTentativa;
        private System.Windows.Forms.Button btnVerificarLetra;
        private System.Windows.Forms.Label label1;
    }
}