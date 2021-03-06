﻿using Metodo.Servicos;
using Persistencia.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;



namespace Separando_aplicações_em_camadas
{
    public partial class CadastroProduto : Form
    {
        private Metodos servform;
        private Produtos prod = new Produtos();

        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            servform = new Metodos();
        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            try
            {
                servform.Excluiproduto(txtNomeproduto.Text);
            }
            catch
            {
                MessageBox.Show("Este Item não existe!");
            }
            Limpatela();
        }

        private void btnAdiciona_Click(object sender, EventArgs e)
        {
            try
            {
                if (servform.AdicionaProduto(txtNomeproduto.Text.ToString(), txtValorProduto.Text.ToString(), txtQuantidadeProduto.Text.ToString()))
                {
                    MessageBox.Show("Item Cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Item já cadastrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Limpatela();
        }

        private void btnCarregaLista_Click(object sender, EventArgs e)
        {
            try
            {
                PreencheLista(servform.RetornaLista());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Limpatela()
        {
            txtNomeproduto.Clear();
            txtQuantidadeProduto.Clear();
            txtValorProduto.Clear();
        }

        private void PreencheLista(List<Produtos> prod)
        {
            if (String.IsNullOrEmpty(txtPesquisa.Text))
            {
                popularListView(prod);
            }
            else
            {
                List<Produtos> Filtrados = servform.RetornaLista(txtPesquisa.Text.ToString());

                popularListView(Filtrados);
            }
        }




        private void popularListView(List<Produtos> produtos)
        {
            lvwProdutos.Items.Clear();

            foreach (Produtos item in produtos)
            {
                ListViewItem lvp = new ListViewItem();
                lvp = lvwProdutos.Items.Add(item.NomeProduto);
                lvp.SubItems.Add(item.ValorProduto);
                lvp.SubItems.Add(item.QuantidadeProduto);

            }
        }

    }
}
