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
    public partial class OpcaoMenu : Form
    {
        public OpcaoMenu()
        {
            InitializeComponent();
        }

        private void btnCadastroProdutos_Click(object sender, EventArgs e)
        {
            CadastroProduto FormProduto = new CadastroProduto();
            FormProduto.ShowDialog();
        }

        private void btnCadastroFuncionario_Click(object sender, EventArgs e)
        {
            CadastroFuncionarios FormFuncionarios = new CadastroFuncionarios();
            FormFuncionarios.ShowDialog();
        }
    }
}
