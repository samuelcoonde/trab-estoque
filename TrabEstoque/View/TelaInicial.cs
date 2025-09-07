using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabEstoque.View
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnCadastrarProd_Click(object sender, EventArgs e)
        {
            TelaCadastroProduto telaCadastro = new TelaCadastroProduto();
            telaCadastro.Show();
            this.Hide();
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            TelaAdicionarProduto telaAddProd = new TelaAdicionarProduto();
            telaAddProd.Show();
            this.Close(); // Fechar igual o do PIM, que dá para voltar dps
        }
    }
}
