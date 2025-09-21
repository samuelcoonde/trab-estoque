using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabEstoque.Model;

namespace TrabEstoque.Interfaces
{
    public interface IProdutoDAO
    {
        public bool CadastrarProduto(Produto produto);
        public List<Produto> BuscarListaProdutos();
        public Produto BuscarProdutoPorId(int id);
        public bool AtualizaQuantidadeProduto(Produto produto);
    }
}
