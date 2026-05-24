using SistemaBarbearia.Models;
using SistemaBarbearia.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBarbearia.Services
{
    internal class UsuarioService
    {
        private readonly UsuarioRepository _repository;

        public UsuarioService()
        {
            _repository = new UsuarioRepository();
        }

        public Usuario FazerLogin(string login, string senha)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha)) throw new Exception("Por favor, preencha o login e a senha.");

            Usuario usuario = _repository.ValidarLogin(login, senha);

            if (usuario == null) throw new Exception("Login ou senha incorretos.");

            return usuario;
        }
    }
}
