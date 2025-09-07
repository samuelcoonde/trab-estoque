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

                string query = "INSERT INTO produto (nome_prod, preco_prod, quantidade_prod)" +
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

        public List<Produto> BuscarListaProdutos()
        {
            List<Produto> listaProdutos = new List<Produto>();

            try
            {
                using(var conn = new NpgsqlConnection(_stringconexao))
                {
                    conn.Open();

                    string query = "SELECT id_prod AS Id, nome_prod AS Nome, preco_prod AS Preco, quantidade_prod AS Quantidade FROM produto";

                    using (var comando = new NpgsqlCommand(query, conn))
                    {

                        using(NpgsqlDataReader leitor = comando.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                listaProdutos.Add(new Produto(
                                    leitor.GetInt16(leitor.GetOrdinal("Id")),
                                    leitor.GetString(leitor.GetOrdinal("Nome")),
                                    leitor.GetFloat(leitor.GetOrdinal("Preco")),
                                    leitor.GetInt32(leitor.GetOrdinal("Quantidade"))
                                    ));
                            }
                            return listaProdutos;
                        }
                    }
                }
            }catch(IOException e)
            {
                MessageBox.Show(e.Message,
                                "Mercado Paraíso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            return null;
        }

        public Produto BuscarProdutoPorId(int id)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_stringconexao))
                {
                    conn.Open();

                    string query = "SELECT id_prod AS Id, nome_prod AS Nome, preco_prod AS Preco, quantidade_prod AS Quantidade FROM produto WHERE id_prod = @RecebeId";

                    using (var comando = new NpgsqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("RecebeId", id);

                        using (NpgsqlDataReader leitor = comando.ExecuteReader())
                        {
                            if (leitor.Read())
                            {
                                return new Produto(
                                    leitor.GetInt16(leitor.GetOrdinal("Id")),
                                    leitor.GetString(leitor.GetOrdinal("Nome")),
                                    leitor.GetFloat(leitor.GetOrdinal("Preco")),
                                    leitor.GetInt32(leitor.GetOrdinal("Quantidade"))
                                    );
                            }
                        }
                    }
                }
            }catch(IOException e)
            {
                MessageBox.Show(e.Message,
                                "Mercado Paraíso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            return null;
        }

        public bool AtualizaQuantidadeProduto(Produto produto)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_stringconexao))
                {
                    conn.Open();

                    string query = "UPDATE produto SET quantidade_prod = @RecebeNovaQuantidade WHERE id_prod = @RecebeId";

                    using (var comando = new NpgsqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("RecebeNovaQuantidade", produto.Quantidade);
                        comando.Parameters.AddWithValue("RecebeId", produto.Id);

                        int linhasAfetadas = comando.ExecuteNonQuery();

                        return linhasAfetadas > 0;
                    }
                }
            }catch(IOException e)
            {
                MessageBox.Show(e.Message,
                                "Mercado Paraíso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
