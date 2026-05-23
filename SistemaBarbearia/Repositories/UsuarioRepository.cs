using MySql.Data.MySqlClient;
using SistemaBarbearia.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBarbearia.Repositories
{
    internal class UsuarioRepository
    {
        private readonly ConexaoBanco _conexaoBanco;

        public UsuarioRepository()
        {
            _conexaoBanco = new ConexaoBanco();
        }

        public Usuario ValidarLogin(string login, string senha)
        {
            Usuario usuarioAutenticado = null;

            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "SELECT Id, Nome, Login, Perfil FROM Usuarios WHERE Login = @login AND Senha = @senha";

                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@login", login);
                comando.Parameters.AddWithValue("@senha", senha);

                conexao.Open();
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        usuarioAutenticado = new Usuario
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nome = reader["Nome"].ToString(),
                            Login = reader["Login"].ToString(),
                            Perfil = reader["Perfil"].ToString()
                        };
                    }
                }
            }
            return usuarioAutenticado;
        }
    }
}
