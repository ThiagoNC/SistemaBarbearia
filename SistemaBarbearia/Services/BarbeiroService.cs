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

        public void Inserir(Barbeiro barbeiro)
        {
            if (string.IsNullOrWhiteSpace(barbeiro.Nome)) throw new Exception("O nome é obrigatório.");
            if (string.IsNullOrWhiteSpace(barbeiro.Telefone)) throw new Exception("O telefone é obrigatório.");
            if (barbeiro.PercentualComissao <= 0) throw new Exception("O comissão deve ser maior que zero.");

            _repository.Inserir(barbeiro);
        }

        public void Atualizar(Barbeiro barbeiro)
        {
            _repository.Atualizar(barbeiro);
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
