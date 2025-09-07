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

        public TelaAdicionarProduto()
        {
            InitializeComponent();
            // Instanciar a listaProduto recebdeno o retorno do service
        }

        private void btnConfirmaIdProdAdd_Click(object sender, EventArgs e)
        {
            this.ConfiguraDataGridView();
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
    }
}
