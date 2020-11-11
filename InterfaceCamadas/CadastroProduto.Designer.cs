namespace Separando_aplicações_em_camadas
{
    partial class CadastroProduto
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblQuantida = new System.Windows.Forms.Label();
            this.txtQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.txtNomeproduto = new System.Windows.Forms.TextBox();
            this.btnAdiciona = new System.Windows.Forms.Button();
            this.btnExclui = new System.Windows.Forms.Button();
            this.btnCarregaLista = new System.Windows.Forms.Button();
            this.lvwProdutos = new System.Windows.Forms.ListView();
            this.clmNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmQuantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblBarraPesquisa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(12, 9);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(75, 13);
            this.lblNomeProduto.TabIndex = 0;
            this.lblNomeProduto.Text = "Nome Produto";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 48);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor";
            // 
            // lblQuantida
            // 
            this.lblQuantida.AutoSize = true;
            this.lblQuantida.Location = new System.Drawing.Point(164, 48);
            this.lblQuantida.Name = "lblQuantida";
            this.lblQuantida.Size = new System.Drawing.Size(62, 13);
            this.lblQuantida.TabIndex = 2;
            this.lblQuantida.Text = "Quantidade";
            // 
            // txtQuantidadeProduto
            // 
            this.txtQuantidadeProduto.Location = new System.Drawing.Point(167, 64);
            this.txtQuantidadeProduto.Name = "txtQuantidadeProduto";
            this.txtQuantidadeProduto.Size = new System.Drawing.Size(143, 20);
            this.txtQuantidadeProduto.TabIndex = 3;
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.Location = new System.Drawing.Point(15, 64);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Size = new System.Drawing.Size(143, 20);
            this.txtValorProduto.TabIndex = 4;
            // 
            // txtNomeproduto
            // 
            this.txtNomeproduto.Location = new System.Drawing.Point(15, 25);
            this.txtNomeproduto.Name = "txtNomeproduto";
            this.txtNomeproduto.Size = new System.Drawing.Size(295, 20);
            this.txtNomeproduto.TabIndex = 5;
            // 
            // btnAdiciona
            // 
            this.btnAdiciona.Location = new System.Drawing.Point(103, 280);
            this.btnAdiciona.Name = "btnAdiciona";
            this.btnAdiciona.Size = new System.Drawing.Size(58, 23);
            this.btnAdiciona.TabIndex = 6;
            this.btnAdiciona.Text = "Adiciona";
            this.btnAdiciona.UseVisualStyleBackColor = true;
            this.btnAdiciona.Click += new System.EventHandler(this.btnAdiciona_Click);
            // 
            // btnExclui
            // 
            this.btnExclui.Location = new System.Drawing.Point(167, 280);
            this.btnExclui.Name = "btnExclui";
            this.btnExclui.Size = new System.Drawing.Size(58, 23);
            this.btnExclui.TabIndex = 7;
            this.btnExclui.Text = "Exclui";
            this.btnExclui.UseVisualStyleBackColor = true;
            this.btnExclui.Click += new System.EventHandler(this.btnExclui_Click);
            // 
            // btnCarregaLista
            // 
            this.btnCarregaLista.Location = new System.Drawing.Point(233, 100);
            this.btnCarregaLista.Name = "btnCarregaLista";
            this.btnCarregaLista.Size = new System.Drawing.Size(77, 23);
            this.btnCarregaLista.TabIndex = 8;
            this.btnCarregaLista.Text = "Carrega Lista";
            this.btnCarregaLista.UseVisualStyleBackColor = true;
            this.btnCarregaLista.Click += new System.EventHandler(this.btnCarregaLista_Click);
            // 
            // lvwProdutos
            // 
            this.lvwProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNome,
            this.clmValor,
            this.clmQuantidade});
            this.lvwProdutos.HideSelection = false;
            this.lvwProdutos.Location = new System.Drawing.Point(15, 129);
            this.lvwProdutos.Name = "lvwProdutos";
            this.lvwProdutos.Size = new System.Drawing.Size(295, 145);
            this.lvwProdutos.TabIndex = 9;
            this.lvwProdutos.UseCompatibleStateImageBehavior = false;
            this.lvwProdutos.View = System.Windows.Forms.View.Details;
            // 
            // clmNome
            // 
            this.clmNome.Text = "Nome";
            this.clmNome.Width = 104;
            // 
            // clmValor
            // 
            this.clmValor.Text = "Valor";
            this.clmValor.Width = 88;
            // 
            // clmQuantidade
            // 
            this.clmQuantidade.Text = "Quantidade";
            this.clmQuantidade.Width = 98;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(15, 103);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(212, 20);
            this.txtPesquisa.TabIndex = 10;
            // 
            // lblBarraPesquisa
            // 
            this.lblBarraPesquisa.AutoSize = true;
            this.lblBarraPesquisa.Location = new System.Drawing.Point(12, 87);
            this.lblBarraPesquisa.Name = "lblBarraPesquisa";
            this.lblBarraPesquisa.Size = new System.Drawing.Size(93, 13);
            this.lblBarraPesquisa.TabIndex = 11;
            this.lblBarraPesquisa.Text = "Barra de Pesquisa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 309);
            this.Controls.Add(this.lblBarraPesquisa);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lvwProdutos);
            this.Controls.Add(this.btnCarregaLista);
            this.Controls.Add(this.btnExclui);
            this.Controls.Add(this.btnAdiciona);
            this.Controls.Add(this.txtNomeproduto);
            this.Controls.Add(this.txtValorProduto);
            this.Controls.Add(this.txtQuantidadeProduto);
            this.Controls.Add(this.lblQuantida);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblNomeProduto);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de celulares";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblQuantida;
        private System.Windows.Forms.TextBox txtQuantidadeProduto;
        private System.Windows.Forms.TextBox txtValorProduto;
        private System.Windows.Forms.TextBox txtNomeproduto;
        private System.Windows.Forms.Button btnAdiciona;
        private System.Windows.Forms.Button btnExclui;
        private System.Windows.Forms.Button btnCarregaLista;
        private System.Windows.Forms.ListView lvwProdutos;
        private System.Windows.Forms.ColumnHeader clmNome;
        private System.Windows.Forms.ColumnHeader clmValor;
        private System.Windows.Forms.ColumnHeader clmQuantidade;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblBarraPesquisa;
    }
}

