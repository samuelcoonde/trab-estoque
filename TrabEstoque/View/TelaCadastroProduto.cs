using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabEstoque.Service;
using TrabEstoque.Model;

namespace TrabEstoque.View
{
    public partial class TelaCadastroProduto : Form
    {
        private ProdutoService _produtoService;
        public TelaCadastroProduto()
        {
            InitializeComponent();
            _produtoService = new ProdutoService();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Produto prodCadastrar = new Produto(txtNomeProd.Text, float.Parse(txtPrecoProd.Text), int.Parse(txtQuantidadeProd.Text));
            if (_produtoService.CadastrarProduto(prodCadastrar))
            {
                MessageBox.Show("Produto cadastrado com sucesso!",
                                "Mercado Paraíso",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não foi possível cadastrar o produto",
                                "Mercado Paraíso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnSairCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();
        }
    }
}
