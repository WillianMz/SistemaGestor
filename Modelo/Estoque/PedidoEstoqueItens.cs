namespace Modelo.Estoque
{
    public class PedidoEstoqueItens
    {
        public int idPedido { get; set; }
        public Produto produto { get; set; } = new Produto();
        public Unidade unid { get; set; } = new Unidade();
        public double qtd { get; set; }
        public double desconto { get; set; }
        public double porcDesc { get; set; }
    }
}
