using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBarbearia.Models
{
    internal class Barbeiro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal PercentualComissao { get; set; }
    }
}
