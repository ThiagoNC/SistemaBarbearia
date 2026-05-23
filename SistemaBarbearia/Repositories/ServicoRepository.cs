using MySql.Data.MySqlClient;
using SistemaBarbearia.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBarbearia.Repositories
{
    internal class ServicoRepository
    {
        private readonly ConexaoBanco _conexaoBanco;

        public ServicoRepository()
        {
            _conexaoBanco = new ConexaoBanco();
        }

        public void Inserir(Servico servico)
        {
            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "INSERT INTO Servicos (Nome, Preco, DuracaoMinutos) VALUES (@nome, @preco, @duracao)";

                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", servico.Nome);
                comando.Parameters.AddWithValue("@preco", servico.Preco);
                comando.Parameters.AddWithValue("@duracao", servico.DuracaoMinutos);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Atualizar(Servico servico)
        {
            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "UPDATE Servicos SET Nome = @nome, Preco = @preco, DuracaoMinutos = @duracao WHERE Id = @id";

                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", servico.Nome);
                comando.Parameters.AddWithValue("@preco", servico.Preco);
                comando.Parameters.AddWithValue("@duracao", servico.DuracaoMinutos);
                comando.Parameters.AddWithValue("@id", servico.Id);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Deletar(int id)
        {
            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "DELETE FROM Servicos WHERE Id = @id";

                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@id", id);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public List<Servico> ListarTodos()
        {
            var lista = new List<Servico>();

            using (var conexao = _conexaoBanco.GetConexao())
            {
                string sql = "SELECT * FROM Servicos";
                var comando = new MySqlCommand(sql, conexao);

                conexao.Open();
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Servico
                        {
                            Id = (int)reader["Id"],
                            Nome = reader["Nome"].ToString(),
                            Preco = (decimal)reader["Preco"],
                            DuracaoMinutos = (int)reader["DuracaoMinutos"]
                        });
                    }
                }
            }
            return lista;
        }

        public List<Servico> ListarPorNome(string nome)
        {
            var lista = new List<Servico>();

            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "SELECT Id, Nome, Preco, DuracaoMinutos FROM Servicos WHERE Nome LIKE @nome";
                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", "%" + nome + "%");

                conexao.Open();
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Servico
                        {
                            Id = (int)reader["Id"],
                            Nome = reader["Nome"].ToString(),
                            Preco = (decimal)reader["Preco"],
                            DuracaoMinutos = (int)reader["DuracaoMinutos"]
                        });
                    }
                }
            }
            return lista;
        }
    }
}
