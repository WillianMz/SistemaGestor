using System;

namespace Modelo.Financeiro
{
    public class Receber
    {
        public int id { get; set; }
        public Empresa empresa { get; set; } = new Empresa();
        public Pessoa pessoa { get; set; } = new Pessoa();
        public string descricao { get; set; }
        public string documento { get; set; }
        public PlanoDeContas planoDeConta { get; set; }
        public DateTime emissao { get; set; }
        public int dias { get; set; }
        public DateTime vencimento { get; set; }
        public double valor { get; set; }
        public double desconto { get; set; }
        public double acrescimo { get; set; }
        public FormaPagto formaPgto { get; set; } = new FormaPagto();
        public ContaBancaria contaBancaria { get; set; } = new ContaBancaria();
        public DateTime dtPagamento { get; set; }
        public double valorPago { get; set; }
        public DateTime dtBaixa { get; set; }
        public Situacao situacao { get; set; } = new Situacao();
        public string anotacao { get; set; }

        //boletos
        public Banco banco { get; set; }
        public int nossoNumero { get; set; }
        public int cnab { get; set; }
    }
}
