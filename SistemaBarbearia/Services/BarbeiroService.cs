using SistemaBarbearia.Models;
using SistemaBarbearia.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBarbearia.Services
{
    internal class BarbeiroService
    {
        private readonly BarbeiroRepository _repository;

        public BarbeiroService()
        {
            _repository = new BarbeiroRepository();
        }

        public void Inserir(string nome, string telefone, string email, DateTime dataNascimento, decimal percentualComissao)
        {
            if (string.IsNullOrWhiteSpace(nome)) throw new Exception("O nome é obrigatório.");
            if (string.IsNullOrWhiteSpace(telefone)) throw new Exception("O telefone é obrigatório.");
            if (percentualComissao <= 0) throw new Exception("O comissão deve ser maior que zero.");

            _repository.Inserir(new Barbeiro { Nome = nome, Telefone = telefone, Email = email, DataNascimento = dataNascimento, PercentualComissao = percentualComissao });
        }

        public void Atualizar(int id, string nome, string telefone, string email, DateTime dataNascimento, decimal percentualComissao)
        {
            _repository.Atualizar(new Barbeiro { Id = id, Nome = nome, Telefone = telefone, Email = email, DataNascimento = dataNascimento, PercentualComissao = percentualComissao });
        }

        public void Deletar(int id)
        {
            if (id <= 0) throw new Exception("Selecione um barbeiro válido para excluir.");
            _repository.Deletar(id);
        }

        public List<Barbeiro> ListarTodos() => _repository.ListarTodos();

        public List<Barbeiro> ListarPorNome(string nome) => _repository.ListarPorNome(nome);
    }
}
