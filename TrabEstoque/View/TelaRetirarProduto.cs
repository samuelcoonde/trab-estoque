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
    public partial class TelaRetirarProduto : Form
    {
        private DataGridView _tabelaProdutosRetirar;
        private ProdutoService _produtoService;
        private List<Produto> _listaProdutos;
        private Produto _produtoQueVaiSerRetirado;
        public TelaRetirarProduto()
        {
            InitializeComponent();
            pnlDadosProdRetirar.Visible = false;
            _produtoService = new ProdutoService();
            _listaProdutos = new List<Produto>();
            _produtoQueVaiSerRetirado = new Produto();
            this.ConfiguraDataGridViewRetirar();
            this.CarregarDataGridViewRetirar();
        }

        private void btnConfirmarIdProdRetirar_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtIdProdASerRetirado.Text)) // Verifica se o id informado para a busca não é nulo
            {
                try
                {
                    _produtoQueVaiSerRetirado = _produtoService.BuscaProdutoPorId(int.Parse(txtIdProdASerRetirado.Text));

                    if (_produtoQueVaiSerRetirado != null)
                    {
                        _tabelaProdutosRetirar.Visible = false;
                        pnlDadosProdRetirar.Visible = true;

                        // Colocando dados do produto buscado no panel
                        lblNomeProdRetirar.Text = "Nome: " + _produtoQueVaiSerRetirado.Nome;
                        lblPrecoProdRetirar.Text = "Preço: " + _produtoQueVaiSerRetirado.Preco.ToString("C2");
                        lblQuantidadeProdRetirar.Text = "Quantidade: " + _produtoQueVaiSerRetirado.Quantidade;

                        txtIdProdASerRetirado.Text = "";
                    }
                }
                catch (IOException ex) // Se o id informado for negativo
                {
                    MessageBox.Show(ex.Message,
                                    "Mercado Paraíso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
            else // Se o id informado for nulo
            {
                MessageBox.Show("Insira um valor válido de Id",
                                "Mercado Paraíso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btnRetirarQuantidadeProd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtQuantidadeASerRetirada.Text)) // Verificando se a quantidade a ser retirada é nula
            {
                if ((_produtoQueVaiSerRetirado.Quantidade -= int.Parse(txtQuantidadeASerRetirada.Text)) >= 0) // Verifica se a quantidade do produto vai ficar negativa e retirando a quantidade do objeto
                {
                    // Retirando quantidade do banco de dados
                    if (_produtoService.AtualizaQuantidadeDoProduto(_produtoQueVaiSerRetirado))
                    {
                        MessageBox.Show("Produto atualizado com sucesso!",
                                        "Mercado Paraíso",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);

                        txtQuantidadeASerRetirada.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar a quantidade do produto!",
                                        "Mercado Paraíso",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
                    }

                    txtQuantidadeASerRetirada.Text = "";
                    pnlDadosProdRetirar.Visible = false;
                    // atualizando a tabela (tela de exibição dos produtos)
                    txtIdProdASerRetirado.Text = "";
                    this.CarregarDataGridViewRetirar(); // Carregando o Data GridView novamente
                    _tabelaProdutosRetirar.Visible = true;
                }
                else // Se a quantidade do produto for ficar negativa
                {
                    MessageBox.Show("Insira um valor válido para ser retirado",
                                        "Mercado Paraíso",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
                }
            }
            else // Se a quantidade informada foi nula
            {
                MessageBox.Show("Insira um valor para ser retirado",
                                "Mercado Paraíso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        public void ConfiguraDataGridViewRetirar() // Configurando o DataGridView
        {
            _tabelaProdutosRetirar = new DataGridView();

            _tabelaProdutosRetirar.Dock = DockStyle.Fill;
            _tabelaProdutosRetirar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _tabelaProdutosRetirar.ReadOnly = true;
            _tabelaProdutosRetirar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _tabelaProdutosRetirar.MultiSelect = false;

            _tabelaProdutosRetirar.Columns.Add("Id", "Id");
            _tabelaProdutosRetirar.Columns.Add("Nome", "Nome");
            _tabelaProdutosRetirar.Columns.Add("Preco", "Preço");
            _tabelaProdutosRetirar.Columns.Add("Quantidade", "Quantidade");

            _tabelaProdutosRetirar.Columns["Preco"].DefaultCellStyle.Format = "C2"; // Formatando a coluna de preço para aparecer o valor com 2 casas decimais e o $

            pnlDgvRetirar.Controls.Add(_tabelaProdutosRetirar); // Adicionando tabela do form
        }

        public void CarregarDataGridViewRetirar()
        {
            _listaProdutos = _produtoService.ListarProdutos();

            _tabelaProdutosRetirar.Rows.Clear();

            foreach (Produto p in _listaProdutos)
            {
                _tabelaProdutosRetirar.Rows.Add(
                    p.Id,
                    p.Nome,
                    p.Preco,
                    p.Quantidade);
            }
        }

        private void btnSairRetirarProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoltarR_Click(object sender, EventArgs e)
        {
            pnlDadosProdRetirar.Visible = false;
            _tabelaProdutosRetirar.Visible = true;
            txtIdProdASerRetirado.Text = "";
        }
    }
}
