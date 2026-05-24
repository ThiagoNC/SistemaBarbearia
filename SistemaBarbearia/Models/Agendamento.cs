using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBarbearia.Models
{
    internal class Agendamento
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int ServicoId { get; set; }
        public int BarbeiroId { get; set; }
        public DateTime DataHora { get; set; }
        public string Status { get; set; } = "Pendente";

        public string NomeCliente { get; set; }
        public string NomeServico { get; set; }
        public string NomeBarbeiro { get; set; }
        public decimal PrecoServico { get; set; }
        public int DuracaoServico { get; set; }
    }
}
