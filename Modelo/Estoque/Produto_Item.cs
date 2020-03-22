using Modelo.Tributacao;

namespace Modelo.Estoque
{
    public class Produto_Item
    {
        public int Id { get; set; }
        public int idProduto { get; set; }
        public Produto produto { get; set; } = new Produto();
        public CST cst { get; set; } = new CST();
        public CFOP cfop { get; set; } = new CFOP();
        public Unidade unid { get; set; } = new Unidade();
        public double qtd { get; set; }
        public double vlUnit { get; set; }
        public double vlDesc { get; set; }
        public double vlOutros { get; set; }
        public double vlTotal { get; set; }

        public double vlFrete { get; set; }

        //imposto
        public double bcICMS { get; set; }
        public double vlICMS { get; set; }
        public double vlIPI { get; set; }
        public double alqICMS { get; set; }
        public double alqIPI { get; set; }
    }
}
