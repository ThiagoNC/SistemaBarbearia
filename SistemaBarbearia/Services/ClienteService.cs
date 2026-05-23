using SistemaBarbearia.Models;
using SistemaBarbearia.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBarbearia.Services
{
    internal class ClienteService
    {
        private readonly ClienteRepository _repository;

        public ClienteService()
        {
            _repository = new ClienteRepository();
        }

        public void Inserir(string nome, string telefone, string email, DateTime dataNascimento)
        {
            if (string.IsNullOrWhiteSpace(nome)) throw new Exception("O nome é obrigatório.");
            if (string.IsNullOrWhiteSpace(telefone)) throw new Exception("O telefone é obrigatório.");

            _repository.Inserir(new Cliente { Nome = nome, Telefone = telefone, Email = email, DataNascimento = dataNascimento });
        }

        public void Atualizar(int id, string nome, string telefone, string email, DateTime dataNascimento)
        {
            _repository.Atualizar(new Cliente { Id = id, Nome = nome, Telefone = telefone, Email = email, DataNascimento = dataNascimento});
        }

        public void Deletar(int id)
        {
            if (id <= 0) throw new Exception("Selecione um cliente válido para excluir.");
            _repository.Deletar(id);
        }

        public List<Cliente> ListarTodos() => _repository.ListarTodos();

        public List<Cliente> ListarPorNome(string nome) => _repository.ListarPorNome(nome);
    }
}
