using SistemaBarbearia.Models;
using SistemaBarbearia.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBarbearia.Services
{
    internal class ServicoService
    {
        private readonly ServicoRepository _repository;

        public ServicoService()
        {
            _repository = new ServicoRepository();
        }

        public void Inserir(Servico servico)
        {
            if (string.IsNullOrWhiteSpace(servico.Nome)) throw new Exception("Nome do serviço é obrigatório.");
            if (servico.Preco <= 0) throw new Exception("O preço deve ser maior que zero.");

            _repository.Inserir(servico);
        }

        public void Atualizar(Servico servico)
        {
            _repository.Atualizar(servico);
        }

        public void Deletar(int id)
        {
            if (id <= 0) throw new Exception("Selecione um serviço válido para excluir.");
            _repository.Deletar(id);
        }

        public List<Servico> ListarTodos() => _repository.ListarTodos();

        public List<Servico> ListarPorNome(string nome) => _repository.ListarPorNome(nome);
    }
}
