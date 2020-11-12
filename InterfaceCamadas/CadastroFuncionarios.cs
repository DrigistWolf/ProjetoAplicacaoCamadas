using Metodo.Servicos;
using Persistencia.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Separando_aplicações_em_camadas
{
    public partial class CadastroFuncionarios : Form
    {
        private Funcionario funcionario;
        private FuncionarioService ServicoFuncionario;

        public CadastroFuncionarios()
        {
            ServicoFuncionario = new FuncionarioService();
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            funcionario = new Funcionario();

            funcionario.Nome = txtNome.Text.ToString();
            funcionario.Telefone = long.Parse(txtNroTelefone.Text);
            funcionario.DataNascimento = DateTime.Parse(txtDataNascimento.Text);
            funcionario.Registro = long.Parse(txtInscricao.Text);
            funcionario.DataAdimicao = DateTime.Parse(txtAdmissao.Text);

            try
            {
                if (ServicoFuncionario.ContratarFuncionarios(funcionario))
                {
                    MessageBox.Show("Funcionario Cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Funcionario já Contratado");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            LimpaTela();
        }

        private void btnDemissao_Click(object sender, EventArgs e)
        {
            try
            {
                ServicoFuncionario.DemiteFuncionario(txtNome.Text);
            }
            catch
            {
                MessageBox.Show("Esta Pessoa não foi empregada ainda!");
            }
            LimpaTela();
        }

        public void LimpaTela()
        {
            txtNome.Text = null;
            txtDataNascimento.Text = null;
            txtNroTelefone.Text = null;
            txtInscricao.Text = null;
            txtAdmissao.Text = null;
        }

    }
}
