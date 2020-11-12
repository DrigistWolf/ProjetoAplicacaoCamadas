namespace Separando_aplicações_em_camadas
{
    partial class CadastroFuncionarios
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
            this.lblNroTelefone = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblAdmissao = new System.Windows.Forms.Label();
            this.lblInscricao = new System.Windows.Forms.Label();
            this.txtAdmissao = new System.Windows.Forms.TextBox();
            this.txtInscricao = new System.Windows.Forms.TextBox();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.txtNroTelefone = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnDemissao = new System.Windows.Forms.Button();
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
            // lblNroTelefone
            // 
            this.lblNroTelefone.AutoSize = true;
            this.lblNroTelefone.Location = new System.Drawing.Point(12, 51);
            this.lblNroTelefone.Name = "lblNroTelefone";
            this.lblNroTelefone.Size = new System.Drawing.Size(69, 13);
            this.lblNroTelefone.TabIndex = 1;
            this.lblNroTelefone.Text = "Nro.Telefone";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(140, 48);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(104, 13);
            this.lblDataNascimento.TabIndex = 2;
            this.lblDataNascimento.Text = "Data de Nascimento";
            // 
            // lblAdmissao
            // 
            this.lblAdmissao.AutoSize = true;
            this.lblAdmissao.Location = new System.Drawing.Point(141, 90);
            this.lblAdmissao.Name = "lblAdmissao";
            this.lblAdmissao.Size = new System.Drawing.Size(54, 13);
            this.lblAdmissao.TabIndex = 3;
            this.lblAdmissao.Text = "Adimissão";
            // 
            // lblInscricao
            // 
            this.lblInscricao.AutoSize = true;
            this.lblInscricao.Location = new System.Drawing.Point(12, 90);
            this.lblInscricao.Name = "lblInscricao";
            this.lblInscricao.Size = new System.Drawing.Size(50, 13);
            this.lblInscricao.TabIndex = 4;
            this.lblInscricao.Text = "Inscrição";
            // 
            // txtAdmissao
            // 
            this.txtAdmissao.Location = new System.Drawing.Point(143, 106);
            this.txtAdmissao.Name = "txtAdmissao";
            this.txtAdmissao.Size = new System.Drawing.Size(116, 20);
            this.txtAdmissao.TabIndex = 5;
            // 
            // txtInscricao
            // 
            this.txtInscricao.Location = new System.Drawing.Point(15, 106);
            this.txtInscricao.Name = "txtInscricao";
            this.txtInscricao.Size = new System.Drawing.Size(120, 20);
            this.txtInscricao.TabIndex = 6;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(143, 66);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(116, 20);
            this.txtDataNascimento.TabIndex = 7;
            // 
            // txtNroTelefone
            // 
            this.txtNroTelefone.Location = new System.Drawing.Point(15, 67);
            this.txtNroTelefone.Name = "txtNroTelefone";
            this.txtNroTelefone.Size = new System.Drawing.Size(120, 20);
            this.txtNroTelefone.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(244, 20);
            this.txtNome.TabIndex = 9;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(60, 137);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnCadastro.TabIndex = 10;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnDemissao
            // 
            this.btnDemissao.Location = new System.Drawing.Point(144, 137);
            this.btnDemissao.Name = "btnDemissao";
            this.btnDemissao.Size = new System.Drawing.Size(75, 23);
            this.btnDemissao.TabIndex = 11;
            this.btnDemissao.Text = "Demissão";
            this.btnDemissao.UseVisualStyleBackColor = true;
            this.btnDemissao.Click += new System.EventHandler(this.btnDemissao_Click);
            // 
            // CadastroFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 172);
            this.Controls.Add(this.btnDemissao);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtNroTelefone);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtInscricao);
            this.Controls.Add(this.txtAdmissao);
            this.Controls.Add(this.lblInscricao);
            this.Controls.Add(this.lblAdmissao);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblNroTelefone);
            this.Controls.Add(this.lblNome);
            this.Name = "CadastroFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNroTelefone;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblAdmissao;
        private System.Windows.Forms.Label lblInscricao;
        private System.Windows.Forms.TextBox txtAdmissao;
        private System.Windows.Forms.TextBox txtInscricao;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.TextBox txtNroTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnDemissao;
    }
}