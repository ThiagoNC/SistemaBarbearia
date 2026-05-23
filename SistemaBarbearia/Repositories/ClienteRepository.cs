using MySql.Data.MySqlClient;
using SistemaBarbearia.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBarbearia.Repositories
{
    internal class ClienteRepository
    {
        private readonly ConexaoBanco _conexaoBanco;

        public ClienteRepository()
        {
            _conexaoBanco = new ConexaoBanco();
        }

        public void Inserir(Cliente cliente)
        {
            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "INSERT INTO Clientes (Nome, Telefone, Email, DataNascimento, DataCadastro) VALUES (@nome, @telefone, @email, @datanascimento, NOW())";
                
                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", cliente.Nome);
                comando.Parameters.AddWithValue("@telefone", cliente.Telefone);
                comando.Parameters.AddWithValue("@email", cliente.Email);
                comando.Parameters.AddWithValue("@datanascimento", cliente.DataNascimento);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Atualizar(Cliente cliente)
        {
            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "UPDATE Clientes SET Nome = @nome, Telefone = @telefone, Email = @email, DataNascimento = @dataNascimento WHERE Id = @id";

                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", cliente.Nome);
                comando.Parameters.AddWithValue("@telefone", cliente.Telefone);
                comando.Parameters.AddWithValue("@email", cliente.Email);
                comando.Parameters.AddWithValue("@dataNascimento", cliente.DataNascimento);
                comando.Parameters.AddWithValue("@id", cliente.Id);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Deletar(int id)
        {
            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "DELETE FROM Clientes WHERE Id = @id";
                
                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@id", id);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public List<Cliente> ListarTodos()
        {
            var lista = new List<Cliente>();

            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "SELECT Id, Nome, Telefone, Email, DataNascimento, DataCadastro FROM Clientes";
                var comando = new MySqlCommand(sql, conexao);

                conexao.Open();
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Cliente
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nome = reader["Nome"].ToString(),
                            Telefone = reader["Telefone"].ToString(),
                            Email = reader["Email"].ToString(),
                            DataNascimento = Convert.ToDateTime(reader["DataNascimento"]),
                            DataCadastro = Convert.ToDateTime(reader["DataCadastro"])
                        });
                    }
                }
            }
            return lista;
        }

        public List<Cliente> ListarPorNome(string nome)
        {
            var lista = new List<Cliente>();

            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "SELECT Id, Nome, Telefone, Email, DataNascimento, DataCadastro FROM Clientes WHERE Nome LIKE @nome";
                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", "%" + nome + "%");

                conexao.Open();
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Cliente
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nome = reader["Nome"].ToString(),
                            Telefone = reader["Telefone"].ToString(),
                            Email = reader["Email"].ToString(),
                            DataNascimento = Convert.ToDateTime(reader["DataNascimento"]),
                            DataCadastro = Convert.ToDateTime(reader["DataCadastro"])
                        });
                    }
                }
            }
            return lista;
        }
    }
}
