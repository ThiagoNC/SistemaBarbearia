using MySql.Data.MySqlClient;
using SistemaBarbearia.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBarbearia.Repositories
{
    internal class BarbeiroRepository
    {
        private readonly ConexaoBanco _conexaoBanco;

        public BarbeiroRepository()
        {
            _conexaoBanco = new ConexaoBanco();
        }

        public void Inserir(Barbeiro barbeiro)
        {
            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "INSERT INTO Barbeiros (Nome, Telefone, Email, DataNascimento, PercentualComissao) VALUES (@nome, @telefone, @email, @datanascimento, @percentualcomissao)";

                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", barbeiro.Nome);
                comando.Parameters.AddWithValue("@telefone", barbeiro.Telefone);
                comando.Parameters.AddWithValue("@email", barbeiro.Email);
                comando.Parameters.AddWithValue("@datanascimento", barbeiro.DataNascimento);
                comando.Parameters.AddWithValue("@percentualcomissao", barbeiro.PercentualComissao);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Atualizar(Barbeiro barbeiro)
        {
            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "UPDATE Barbeiros SET Nome = @nome, Telefone = @telefone, Email = @email, DataNascimento = @dataNascimento, PercentualComissao = @percentualcomissao WHERE Id = @id";

                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", barbeiro.Nome);
                comando.Parameters.AddWithValue("@telefone", barbeiro.Telefone);
                comando.Parameters.AddWithValue("@email", barbeiro.Email);
                comando.Parameters.AddWithValue("@dataNascimento", barbeiro.DataNascimento);
                comando.Parameters.AddWithValue("@percentualcomissao", barbeiro.PercentualComissao);
                comando.Parameters.AddWithValue("@id", barbeiro.Id);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Deletar(int id)
        {
            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "DELETE FROM Barbeiros WHERE Id = @id";

                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@id", id);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public List<Barbeiro> ListarTodos()
        {
            var lista = new List<Barbeiro>();

            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "SELECT Id, Nome, Telefone, Email, DataNascimento, PercentualComissao FROM Barbeiros";
                var comando = new MySqlCommand(sql, conexao);

                conexao.Open();
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Barbeiro
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nome = reader["Nome"].ToString(),
                            Telefone = reader["Telefone"].ToString(),
                            Email = reader["Email"].ToString(),
                            DataNascimento = Convert.ToDateTime(reader["DataNascimento"]),
                            PercentualComissao = (decimal)reader["PercentualComissao"]
                        });
                    }
                }
            }
            return lista;
        }

        public List<Barbeiro> ListarPorNome(string nome)
        {
            var lista = new List<Barbeiro>();

            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "SELECT Id, Nome, Telefone, Email, DataNascimento, PercentualComissao FROM Barbeiros WHERE Nome LIKE @nome";
                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", "%" + nome + "%");

                conexao.Open();
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Barbeiro
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nome = reader["Nome"].ToString(),
                            Telefone = reader["Telefone"].ToString(),
                            Email = reader["Email"].ToString(),
                            DataNascimento = Convert.ToDateTime(reader["DataNascimento"]),
                            PercentualComissao = (decimal)reader["PercentualComissao"]
                        });
                    }
                }
            }
            return lista;
        }
    }
}
