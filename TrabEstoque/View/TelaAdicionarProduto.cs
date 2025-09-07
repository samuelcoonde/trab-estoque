using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabEstoque.Model;
using TrabEstoque.Service;

namespace TrabEstoque.View
{
    public partial class TelaAdicionarProduto : Form
    {
        private DataGridView _tabelaProdutos;
        private List<Produto> _listaProdutos;
        private ProdutoService _produtoService;
        private Produto _prodQueVaiSerAtualizado;

        public TelaAdicionarProduto()
        {
            InitializeComponent();
            // Instanciar a listaProduto recebendo o retorno do service
            _produtoService = new ProdutoService();
            _prodQueVaiSerAtualizado = new Produto();
            pnlDadosProdAdd.Visible = false;
            this.ConfiguraDataGridView(); // Colocando DataGridView na tela
            this.CarregarDataGridView(); // Carregando o Data GridView
        }

        private void btnConfirmaIdProdAdd_Click(object sender, EventArgs e)
        {
            _tabelaProdutos.Visible = false;
            _prodQueVaiSerAtualizado = _produtoService.BuscaProdutoPorId(int.Parse(txtIdProdAdd.Text));

            if (_prodQueVaiSerAtualizado != null)
            {
                pnlDadosProdAdd.Visible = true;
                lblNomeProdAdd.Text = "Nome: " + _prodQueVaiSerAtualizado.Nome;
                lblPrecoProdAdd.Text = "Preço: " + _prodQueVaiSerAtualizado.Preco.ToString("C2"); // Convertendo para string
                lblQuantidadeProd.Text = "Quantidade: " + _prodQueVaiSerAtualizado.Quantidade.ToString();
            }
        }


        private void btnAddQuantidadeProd_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtQuantidadeASerAdd.Text) < 0)
            {
                MessageBox.Show("Não foi possível atualizar a quantidade do produto!\nNão é possível adicionar uma quantidade negativa",
                                "Mercado Paraíso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                // Atualizando a quantidade no objeto
                _prodQueVaiSerAtualizado.Quantidade += int.Parse(txtQuantidadeASerAdd.Text);

                //Atualizando a quantidade no banco de dados
                if (_produtoService.AtualizaQuantidadeDoProduto(_prodQueVaiSerAtualizado))
                {
                    MessageBox.Show("Produto atualizado com sucesso!",
                                    "Mercado Paraíso",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);

                    txtQuantidadeASerAdd.Text = "";
                }
                else
                {
                    MessageBox.Show("Não foi possível atualizar a quantidade do produto!",
                                    "Mercado Paraíso",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                }

                txtQuantidadeASerAdd.Text = "";
                pnlDadosProdAdd.Visible = false;
                // atualizando a tabela (tela de exibição dos produtos)
                txtIdProdAdd.Text = "";
                this.CarregarDataGridView(); // Carregando o Data GridView novamente
                _tabelaProdutos.Visible = true;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            pnlDadosProdAdd.Visible = false;
            _tabelaProdutos.Visible = true;
            txtIdProdAdd.Text = "";
        }

        public void ConfiguraDataGridView()
        {
            _tabelaProdutos = new DataGridView(); // Instanciando o datagridview
            _tabelaProdutos.Dock = DockStyle.Fill;
            _tabelaProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _tabelaProdutos.ReadOnly = true;
            _tabelaProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _tabelaProdutos.MultiSelect = false;

            _tabelaProdutos.Columns.Add("Id", "Id");
            _tabelaProdutos.Columns.Add("Nome", "Nome");
            _tabelaProdutos.Columns.Add("Preco", "Preço");
            _tabelaProdutos.Columns.Add("Quantidade", "Quantidade");

            _tabelaProdutos.Columns["Preco"].DefaultCellStyle.Format = "C2"; // Formatando a coluna de preço para aparecer o valor com 2 casas decimais e o $

            pnlDgv.Controls.Add(_tabelaProdutos); // Adicionando tabela do form
        }

        public void CarregarDataGridView()
        {
            // Carregando lista de produtos

            _listaProdutos = _produtoService.ListarProdutos();

            // Limpando a tabela
            _tabelaProdutos.Rows.Clear();

            foreach (Produto p in _listaProdutos)
            {
                _tabelaProdutos.Rows.Add(
                    p.Id,
                    p.Nome,
                    p.Preco,
                    p.Quantidade);
            }
        }

        private void btnSairAddProd_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.ShowDialog();
        }

       
    }
}
