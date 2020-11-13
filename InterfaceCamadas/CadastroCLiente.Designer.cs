namespace Separando_aplicações_em_camadas
{
    partial class CadastroCliente
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblUltDataCompra = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDataUltimaCompra = new System.Windows.Forms.TextBox();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.btnCadastra = new System.Windows.Forms.Button();
            this.btnRemoveCli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(12, 48);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 1;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblUltDataCompra
            // 
            this.lblUltDataCompra.AutoSize = true;
            this.lblUltDataCompra.Location = new System.Drawing.Point(161, 87);
            this.lblUltDataCompra.Name = "lblUltDataCompra";
            this.lblUltDataCompra.Size = new System.Drawing.Size(116, 13);
            this.lblUltDataCompra.TabIndex = 2;
            this.lblUltDataCompra.Text = "Data da Ultima Compra";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(12, 87);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(104, 13);
            this.lblDataNascimento.TabIndex = 3;
            this.lblDataNascimento.Text = "Data de Nascimento";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(294, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtDataUltimaCompra
            // 
            this.txtDataUltimaCompra.Location = new System.Drawing.Point(164, 103);
            this.txtDataUltimaCompra.Name = "txtDataUltimaCompra";
            this.txtDataUltimaCompra.Size = new System.Drawing.Size(145, 20);
            this.txtDataUltimaCompra.TabIndex = 5;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(15, 103);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(143, 20);
            this.txtDataNascimento.TabIndex = 6;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(15, 64);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(143, 20);
            this.txtTelefone.TabIndex = 7;
            // 
            // btnCadastra
            // 
            this.btnCadastra.Location = new System.Drawing.Point(83, 129);
            this.btnCadastra.Name = "btnCadastra";
            this.btnCadastra.Size = new System.Drawing.Size(75, 23);
            this.btnCadastra.TabIndex = 8;
            this.btnCadastra.Text = "Cadastrar";
            this.btnCadastra.UseVisualStyleBackColor = true;
            this.btnCadastra.Click += new System.EventHandler(this.btnCadastra_Click);
            // 
            // btnRemoveCli
            // 
            this.btnRemoveCli.Location = new System.Drawing.Point(164, 129);
            this.btnRemoveCli.Name = "btnRemoveCli";
            this.btnRemoveCli.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveCli.TabIndex = 9;
            this.btnRemoveCli.Text = "Descadastro";
            this.btnRemoveCli.UseVisualStyleBackColor = true;
            this.btnRemoveCli.Click += new System.EventHandler(this.btnRemoveCli_Click);
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 161);
            this.Controls.Add(this.btnRemoveCli);
            this.Controls.Add(this.btnCadastra);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtDataUltimaCompra);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblUltDataCompra);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNome);
            this.Name = "CadastroCliente";
            this.Text = "Cadastro de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblUltDataCompra;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDataUltimaCompra;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button btnCadastra;
        private System.Windows.Forms.Button btnRemoveCli;
    }
}