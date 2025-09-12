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
            this.Hide();
            TelaCadastroProduto telaCadastro = new TelaCadastroProduto();
            telaCadastro.ShowDialog();
            this.Show();
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaAdicionarProduto telaAddProd = new TelaAdicionarProduto();
            telaAddProd.ShowDialog();
            this.Show();
        }

        private void btnRemoverProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaRetirarProduto telaRetirarProd = new TelaRetirarProduto();
            telaRetirarProd.ShowDialog();
            this.Show();
        }

        private void btnAddProd_MouseHover(object sender, EventArgs e)
        {
            btnAddProd.BackColor = Color.White;
        }

        private void btnCadastrarProd_MouseHover(object sender, EventArgs e)
        {
            btnCadastrarProd.BackColor = Color.White;
        }

        private void btnRemoverProd_MouseHover(object sender, EventArgs e)
        {
            btnRemoverProd.BackColor = Color.White;
        }
    }
}
