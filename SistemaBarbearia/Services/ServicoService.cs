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

        public void Inserir(string nome, decimal preco, int duracao)
        {
            if (string.IsNullOrWhiteSpace(nome)) throw new Exception("Nome do serviço é obrigatório.");
            if (preco <= 0) throw new Exception("O preço deve ser maior que zero.");

            _repository.Inserir(new Servico { Nome = nome, Preco = preco, DuracaoMinutos = duracao });
        }

        public void Atualizar(int id, string nome, decimal preco, int duracao)
        {
            _repository.Atualizar(new Servico { Id = id, Nome = nome, Preco = preco, DuracaoMinutos = duracao });
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
