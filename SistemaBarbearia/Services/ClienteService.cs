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

        public void Inserir(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nome)) throw new Exception("O nome é obrigatório.");
            if (string.IsNullOrWhiteSpace(cliente.Telefone)) throw new Exception("O telefone é obrigatório.");

            _repository.Inserir(cliente);
        }

        public void Atualizar(Cliente cliente)
        {
            _repository.Atualizar(cliente);
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
