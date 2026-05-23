using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBarbearia.Models
{
    internal class Servico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int DuracaoMinutos { get; set; }
    }
}
