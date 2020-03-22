using Modelo.Financeiro;
using System;
using System.Collections.Generic;

namespace Modelo.Estoque
{
    public class PedidoEstoque
    {
        public int Id { get; set; }
        public Empresa empresa { get; set; } = new Empresa();
        public Pessoa fornec { get; set; } = new Pessoa();
        public DateTime dtPedido { get; set; }
        public DateTime dtEntrega { get; set; }
        public Pessoa transp { get; set; } = new Pessoa();
        public bool freteEmitente { get; set; }
        public bool freteDestin { get; set; }
        public bool semFrete { get; set; }
        public double valorFrete { get; set; }
        public FormaPagto pagamento { get; set; } = new FormaPagto();
        public int pedFornec { get; set; }
        public double valorTotal { get; set; }
        public string obs { get; set; }
        public List<Produto> Itens { get; set; } = new List<Produto>();
    }
}
