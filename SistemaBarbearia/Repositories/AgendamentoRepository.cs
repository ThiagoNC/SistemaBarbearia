using MySql.Data.MySqlClient;
using SistemaBarbearia.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBarbearia.Repositories
{
    internal class AgendamentoRepository
    {
        private readonly ConexaoBanco _conexaoBanco;

        public AgendamentoRepository()
        {
            _conexaoBanco = new ConexaoBanco();
        }

        public void Inserir(Agendamento agendamento)
        {
            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "INSERT INTO Agendamentos (ClienteId, ServicoId, BarbeiroId, DataHora, Status) VALUES (@ClienteId, @ServicoId, @BarbeiroId, @DataHora, @Status)";

                using (var comando = new MySqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@ClienteId", agendamento.ClienteId);
                    comando.Parameters.AddWithValue("@ServicoId", agendamento.ServicoId);
                    comando.Parameters.AddWithValue("@BarbeiroId", agendamento.BarbeiroId);
                    comando.Parameters.AddWithValue("@DataHora", agendamento.DataHora);
                    comando.Parameters.AddWithValue("@Status", agendamento.Status);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Agendamento agendamento)
        {
            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "UPDATE Agendamentos SET ClienteId = @ClienteId, ServicoId = @ServicoId, BarbeiroId = @BarbeiroId, DataHora = @DataHora, Status = @Status WHERE Id = @Id";

                using (var comando = new MySqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@Id", agendamento.Id);
                    comando.Parameters.AddWithValue("@ClienteId", agendamento.ClienteId);
                    comando.Parameters.AddWithValue("@ServicoId", agendamento.ServicoId);
                    comando.Parameters.AddWithValue("@BarbeiroId", agendamento.BarbeiroId);
                    comando.Parameters.AddWithValue("@DataHora", agendamento.DataHora);
                    comando.Parameters.AddWithValue("@Status", agendamento.Status);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Deletar(int id)
        {
            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "DELETE FROM Agendamentos WHERE Id = @Id";

                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@Id", id);
                
                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public List<Agendamento> ListarTodos()
        {
            var lista = new List<Agendamento>();

            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = @"
            SELECT a.Id, a.ClienteId, a.ServicoId, a.BarbeiroId, a.DataHora, a.Status, 
                   c.Nome AS NomeCliente, s.Nome AS NomeServico, b.Nome AS NomeBarbeiro,
                   s.Preco AS PrecoServico, s.DuracaoMinutos AS DuracaoServico
            FROM Agendamentos a
            INNER JOIN Clientes c ON a.ClienteId = c.Id
            INNER JOIN Servicos s ON a.ServicoId = s.Id
            INNER JOIN Barbeiros b ON a.BarbeiroId = b.Id
            ORDER BY a.DataHora DESC";
                var comando = new MySqlCommand(sql, conexao);
                
                conexao.Open();
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(MapearAgendamento(reader));
                    }
                } 
            }
            return lista;
        }

        public List<Agendamento> ListarPorNome(string nomeCliente)
        {
            var lista = new List<Agendamento>();

            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = @"
            SELECT a.Id, a.ClienteId, a.ServicoId, a.BarbeiroId, a.DataHora, a.Status, 
                   c.Nome AS NomeCliente, s.Nome AS NomeServico, b.Nome AS NomeBarbeiro,
                   s.Preco AS PrecoServico, s.DuracaoMinutos AS DuracaoServico
            FROM Agendamentos a
            INNER JOIN Clientes c ON a.ClienteId = c.Id
            INNER JOIN Servicos s ON a.ServicoId = s.Id
            INNER JOIN Barbeiros b ON a.BarbeiroId = b.Id
            WHERE c.Nome LIKE @NomeCliente
            ORDER BY a.DataHora DESC";
                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@NomeCliente", "%" + nomeCliente + "%");
                
                conexao.Open();
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(MapearAgendamento(reader));
                    }
                }
            }
            return lista;
        }

        public List<Agendamento> ListarAgendamentosDeHoje()
        {
            var lista = new List<Agendamento>();

            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = @"
            SELECT a.Id, a.ClienteId, a.ServicoId, a.BarbeiroId, a.DataHora, a.Status, 
                   c.Nome AS NomeCliente, s.Nome AS NomeServico, b.Nome AS NomeBarbeiro,
                   s.Preco AS PrecoServico, s.DuracaoMinutos AS DuracaoServico
            FROM Agendamentos a
            INNER JOIN Clientes c ON a.ClienteId = c.Id
            INNER JOIN Servicos s ON a.ServicoId = s.Id
            INNER JOIN Barbeiros b ON a.BarbeiroId = b.Id
            WHERE DATE(a.DataHora) = CURDATE() AND a.Status = 'Pendente'
            ORDER BY a.DataHora ASC";

                var comando = new MySqlCommand(sql, conexao);
                conexao.Open();
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(MapearAgendamento(reader));
                    }
                }
            }
            return lista;
        }

        public bool ExisteConflitoDeHorario(int barbeiroId, DateTime dataHoraInicio, int servicoId, int idAgendamentoAtual = 0)
        {
            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = @"
            SELECT COUNT(1) 
            FROM Agendamentos a
            INNER JOIN Servicos s ON a.ServicoId = s.Id
            WHERE a.BarbeiroId = @BarbeiroId 
              AND a.Status != 'Cancelado' 
              AND a.Id != @IdAgendamento
              AND @NovaHoraInicio < DATE_ADD(a.DataHora, INTERVAL s.DuracaoMinutos MINUTE)
              AND DATE_ADD(@NovaHoraInicio, INTERVAL (SELECT DuracaoMinutos FROM Servicos WHERE Id = @ServicoId) MINUTE) > a.DataHora";

                using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@BarbeiroId", barbeiroId);
                    comando.Parameters.AddWithValue("@NovaHoraInicio", dataHoraInicio);
                    comando.Parameters.AddWithValue("@ServicoId", servicoId);
                    comando.Parameters.AddWithValue("@IdAgendamento", idAgendamentoAtual);

                    conexao.Open();
                    int quantidade = Convert.ToInt32(comando.ExecuteScalar());

                    return quantidade > 0;
                }
            }
        }

        private Agendamento MapearAgendamento(MySqlDataReader reader)
        {
            return new Agendamento
            {
                Id = Convert.ToInt32(reader["Id"]),
                ClienteId = Convert.ToInt32(reader["ClienteId"]),
                ServicoId = Convert.ToInt32(reader["ServicoId"]),
                BarbeiroId = Convert.ToInt32(reader["BarbeiroId"]),
                DataHora = Convert.ToDateTime(reader["DataHora"]),
                Status = reader["Status"].ToString(),
                NomeCliente = reader["NomeCliente"].ToString(),
                NomeServico = reader["NomeServico"].ToString(),
                NomeBarbeiro = reader["NomeBarbeiro"].ToString(),
                PrecoServico = Convert.ToDecimal(reader["PrecoServico"]),
                DuracaoServico = Convert.ToInt32(reader["DuracaoServico"])
            };
        }
    }
}
