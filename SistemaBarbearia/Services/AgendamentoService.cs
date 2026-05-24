using SistemaBarbearia.Models;
using SistemaBarbearia.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBarbearia.Services
{
    internal class AgendamentoService
    {
        private readonly AgendamentoRepository _repository;

        public AgendamentoService()
        {
            _repository = new AgendamentoRepository();
        }

        public void Inserir(Agendamento agendamento)
        {
            ValidarAgendamento(agendamento);

            if (agendamento.DataHora < DateTime.Now) throw new Exception("Não é possível realizar agendamentos retroativos.");
            if (_repository.ExisteConflitoDeHorario(agendamento.BarbeiroId, agendamento.DataHora, agendamento.ServicoId)) throw new Exception("Conflito de horário: Este barbeiro já estará atendendo outro cliente neste período.");
            _repository.Inserir(agendamento);
        }

        public void Atualizar(Agendamento agendamento)
        {
            if (agendamento.Id <= 0) throw new Exception("Selecione um agendamento válido para atualizar.");

            ValidarAgendamento(agendamento);

            if (_repository.ExisteConflitoDeHorario(agendamento.BarbeiroId, agendamento.DataHora, agendamento.ServicoId, agendamento.Id)) throw new Exception("Conflito de horário: Este barbeiro já estará atendendo outro cliente neste período.");
            _repository.Atualizar(agendamento);
        }

        public void Deletar(int id)
        {
            if (id <= 0) throw new Exception("Selecione um agendamento válido para excluir.");
            _repository.Deletar(id);
        }

        public List<Agendamento> ListarTodos() => _repository.ListarTodos();

        public List<Agendamento> ListarPorNome(string nomeCliente)
        {
            if (string.IsNullOrWhiteSpace(nomeCliente)) return ListarTodos();
            return _repository.ListarPorNome(nomeCliente);
        }

        public List<Agendamento> ListarAgendamentosDeHoje() => _repository.ListarAgendamentosDeHoje();

        private void ValidarAgendamento(Agendamento agendamento)
        {
            if (agendamento.ClienteId <= 0) throw new Exception("Selecione um cliente válido.");
            if (agendamento.ServicoId <= 0) throw new Exception("Selecione um serviço válido.");
            if (agendamento.BarbeiroId <= 0) throw new Exception("Selecione um barbeiro válido.");
            if (string.IsNullOrWhiteSpace(agendamento.Status)) throw new Exception("O status do agendamento é obrigatório.");
        }
    }
}
