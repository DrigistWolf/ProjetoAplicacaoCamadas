using Metodo.Servicos;
using System;
using System.Windows.Forms;

namespace Separando_aplicações_em_camadas
{
    public partial class CadastroCliente : Form
    {
        ClienteService clienteServ;

        public CadastroCliente()
        {
            clienteServ = new ClienteService();
            InitializeComponent();
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            try
            {
                if (clienteServ.AdiconaCliente(txtNome.Text, long.Parse(txtTelefone.Text), DateTime.Parse(txtDataNascimento.Text), DateTime.Parse(txtDataUltimaCompra.Text)))
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Cliente já Contratado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Limpatela();
        }

        private void btnRemoveCli_Click(object sender, EventArgs e)
        {
            clienteServ.ExcluirCliente(txtNome.Text);
        }

        private void Limpatela() 
        {
            txtNome.Text = null;
            txtTelefone.Text = null;
            txtDataNascimento.Text = null;
            txtDataUltimaCompra.Text = null;
        }
    }
}
