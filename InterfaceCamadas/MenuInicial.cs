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
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            InitializeComponent();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            CadFuncionario FormFuncionario = new CadFuncionario();
            FormFuncionario.Show();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            CadCelular FormProduto = new CadCelular();
            FormProduto.Show();
        }
    }
}
