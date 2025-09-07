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

        public List<Produto> ListarProdutos()
        {
            return _produtoRepository.BuscarListaProdutos();
        }

        public Produto BuscaProdutoPorId(int id)
        {
            if(id > 0)
            {
                return _produtoRepository.BuscarProdutoPorId(id);
            }
            else
            {
                throw new IOException("Não é possível haver um produto com id negativo!");
            }
        }

        public bool AtualizaQuantidadeDoProduto(Produto produto)
        {
            return _produtoRepository.AtualizaQuantidadeProduto(produto);
        }

        public bool ValidaProduto(Produto produto)
        {
            // Se todos os campos estiverem corretos retorna true 
            return (!String.IsNullOrEmpty(produto.Nome) && produto.Quantidade > 0 && produto.Preco > 0);

        }
    }
}
