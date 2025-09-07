using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabEstoque.Repository;
using TrabEstoque.Model;

namespace TrabEstoque.Service
{
    public class ProdutoService
    {
        private ProdutoRepository _produtoRepository;

        public ProdutoService()
        {
            _produtoRepository = new ProdutoRepository();
        }

        public bool CadastrarProduto(Produto produto)
        {
            // Se o produto estiver com os campos preenchidos corretamente, adiciona no banco e retorna true
            return ValidaProduto(produto) ? _produtoRepository.CadastrarProduto(produto) : false;
        }

        public bool ValidaProduto(Produto produto)
        {
            // Se todos os campos estiverem corretos retorna true 
            return (!String.IsNullOrEmpty(produto.Nome) && produto.Quantidade > 0 && produto.Preco > 0);

        }
    }
}
