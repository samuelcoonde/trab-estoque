using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using TrabEstoque.Model;

namespace TrabEstoque.Repository
{
    public class ProdutoRepository
    {
        private readonly string _stringconexao = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=MercadoParaiso";
        public bool CadastrarProduto(Produto produto)
        {
            using (var conn = new NpgsqlConnection(_stringconexao))
            {
                conn.Open();

                string query = "INSERT INTO produtos (nome_prod, preco_prod, quantidade_prod)" +
                               "VALUES (@RecebeNome, @RecebePreco, @RecebeQuantidade)";

                try
                {
                    using (var comando = new NpgsqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("RecebeNome", produto.Nome);
                        comando.Parameters.AddWithValue("RecebePreco", produto.Preco);
                        comando.Parameters.AddWithValue("RecebeQuantidade", produto.Quantidade);

                        int linhasAfetadas = comando.ExecuteNonQuery();

                        return linhasAfetadas > 0; // Retorna true se foi adicionado
                    }

                }catch(IOException e)
                {
                    MessageBox.Show(e.Message,
                                    "Mercado Paraíso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            return false;
        }
    }
}
