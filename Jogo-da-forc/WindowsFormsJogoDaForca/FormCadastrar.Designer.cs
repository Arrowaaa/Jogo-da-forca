namespace WindowsFormsJogoDaForca
{
    partial class FormCadastrar
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
            this.listViewCadastro = new System.Windows.Forms.ListView();
            this.txbCadastro = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbEditar = new System.Windows.Forms.TextBox();
            this.txbRemover = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewCadastro
            // 
            this.listViewCadastro.BackColor = System.Drawing.SystemColors.Window;
            this.listViewCadastro.BackgroundImage = global::WindowsFormsJogoDaForca.Properties.Resources.Captura_de_tela_2024_02_20_213459;
            this.listViewCadastro.BackgroundImageTiled = true;
            this.listViewCadastro.HideSelection = false;
            this.listViewCadastro.Location = new System.Drawing.Point(4, 1);
            this.listViewCadastro.Name = "listViewCadastro";
            this.listViewCadastro.Size = new System.Drawing.Size(137, 229);
            this.listViewCadastro.TabIndex = 0;
            this.listViewCadastro.TileSize = new System.Drawing.Size(180, 30);
            this.listViewCadastro.UseCompatibleStateImageBehavior = false;
            this.listViewCadastro.View = System.Windows.Forms.View.List;
            // 
            // txbCadastro
            // 
            this.txbCadastro.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txbCadastro.Location = new System.Drawing.Point(145, 245);
            this.txbCadastro.Name = "txbCadastro";
            this.txbCadastro.Size = new System.Drawing.Size(134, 20);
            this.txbCadastro.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastrar.Location = new System.Drawing.Point(301, 245);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(90, 23);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "ADICIONAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRemover.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemover.Location = new System.Drawing.Point(301, 327);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(90, 23);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "REMOVER";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditar.Location = new System.Drawing.Point(301, 284);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbEditar
            // 
            this.txbEditar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txbEditar.Location = new System.Drawing.Point(145, 284);
            this.txbEditar.Name = "txbEditar";
            this.txbEditar.Size = new System.Drawing.Size(135, 20);
            this.txbEditar.TabIndex = 6;
            // 
            // txbRemover
            // 
            this.txbRemover.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txbRemover.Location = new System.Drawing.Point(145, 327);
            this.txbRemover.Name = "txbRemover";
            this.txbRemover.Size = new System.Drawing.Size(135, 20);
            this.txbRemover.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(1, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "DIGITE PARA ADICIONAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "DIGITE A NOVA PALAVRA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(1, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "DIGITE O ID DA PALAVRA";
            // 
            // FormCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsJogoDaForca.Properties.Resources.Captura_de_tela_2024_02_20_213459;
            this.ClientSize = new System.Drawing.Size(403, 359);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbRemover);
            this.Controls.Add(this.txbEditar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txbCadastro);
            this.Controls.Add(this.listViewCadastro);
            this.Name = "FormCadastrar";
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.FormCadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCadastro;
        private System.Windows.Forms.TextBox txbCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbEditar;
        private System.Windows.Forms.TextBox txbRemover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}