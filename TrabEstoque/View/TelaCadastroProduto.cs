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
            if (!(String.IsNullOrEmpty(txtNomeProd.Text) && String.IsNullOrEmpty(txtPrecoProd.Text) && String.IsNullOrEmpty(txtQuantidadeProd.Text))) // Verifica se todos os campos foram preenchidos
            {
                try
                {
                    Produto prodCadastrar = new Produto(txtNomeProd.Text, float.Parse(txtPrecoProd.Text), int.Parse(txtQuantidadeProd.Text));

                    if (_produtoService.CadastrarProduto(prodCadastrar)) // Testa se deu certo cadastrar no banco
                    {
                        MessageBox.Show("Produto cadastrado com sucesso!",
                                        "Mercado Paraíso",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);

                        txtNomeProd.Text = "";
                        txtPrecoProd.Text = "";
                        txtQuantidadeProd.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar o produto",
                                        "Mercado Paraíso",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
                catch(FormatException ex)
                {
                    MessageBox.Show("Insira os valores em seus devidos formatos",
                                    "Mercado Paraíso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }   
            }
            else
            {
                MessageBox.Show("Preencha todos os campos de texto",
                                "Mercado Paraíso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btnSairCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
