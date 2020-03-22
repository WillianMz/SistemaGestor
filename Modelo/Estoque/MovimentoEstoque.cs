using System;

namespace Modelo.Estoque
{
    public class MovimentoEstoque
    {
        public int id { get; set; }
        public Produto produto { get; set; } = new Produto();
        public Empresa empresa { get; set; } = new Empresa();
        public DateTime data { get; set; }
        public string descricao { get; set; }

        public double qtdEntrada { get; set; }
        public double qtdSaida { get; set; }
        public double saldoAtual { get; set; }

        public double entradaTroca { get; set; }
        public double saidaTroca { get; set; }
        public double saldoTroca { get; set; }

        public double entradaReserva { get; set; }
        public double saidaReserva { get; set; }
        public double saldoReserva { get; set; }

        public double entradaOutros { get; set; }
        public double saidaOutros { get; set; }
        public double  saldoOutros { get; set; }

        public double totalEmEstoque { get; set; }
    }
}
