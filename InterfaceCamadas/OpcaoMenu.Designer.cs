namespace Separando_aplicações_em_camadas
{
    partial class OpcaoMenu
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
            this.btnCadastroProdutos = new System.Windows.Forms.Button();
            this.btnCadastroFuncionario = new System.Windows.Forms.Button();
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroProdutos
            // 
            this.btnCadastroProdutos.Location = new System.Drawing.Point(12, 12);
            this.btnCadastroProdutos.Name = "btnCadastroProdutos";
            this.btnCadastroProdutos.Size = new System.Drawing.Size(75, 34);
            this.btnCadastroProdutos.TabIndex = 0;
            this.btnCadastroProdutos.Text = "Cadastro de Produtos";
            this.btnCadastroProdutos.UseVisualStyleBackColor = true;
            this.btnCadastroProdutos.Click += new System.EventHandler(this.btnCadastroProdutos_Click);
            // 
            // btnCadastroFuncionario
            // 
            this.btnCadastroFuncionario.Location = new System.Drawing.Point(93, 12);
            this.btnCadastroFuncionario.Name = "btnCadastroFuncionario";
            this.btnCadastroFuncionario.Size = new System.Drawing.Size(75, 34);
            this.btnCadastroFuncionario.TabIndex = 1;
            this.btnCadastroFuncionario.Text = "Cadastro de Funcionario";
            this.btnCadastroFuncionario.UseVisualStyleBackColor = true;
            this.btnCadastroFuncionario.Click += new System.EventHandler(this.btnCadastroFuncionario_Click);
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.Location = new System.Drawing.Point(54, 52);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(75, 34);
            this.btnCadastroCliente.TabIndex = 2;
            this.btnCadastroCliente.Text = "Cadastro de Clientes";
            this.btnCadastroCliente.UseVisualStyleBackColor = true;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastroCliente_Click);
            // 
            // OpcaoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 95);
            this.Controls.Add(this.btnCadastroCliente);
            this.Controls.Add(this.btnCadastroFuncionario);
            this.Controls.Add(this.btnCadastroProdutos);
            this.Name = "OpcaoMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroProdutos;
        private System.Windows.Forms.Button btnCadastroFuncionario;
        private System.Windows.Forms.Button btnCadastroCliente;
    }
}