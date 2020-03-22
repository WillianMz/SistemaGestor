using System;

namespace Modelo.Estoque
{
    public class Produto
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public TipoProduto TipoProduto { get; set; } = new TipoProduto();
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Unidade Unidade { get; set; } = new Unidade();
        public bool Balanca { get; set; }
        public string Marca { get; set; }
        public string Fabricante { get; set; }
        public int CodFabricante { get; set; }
        //estrutura mercadologica
        public Categoria Categoria { get; set; } = new Categoria();
        public Grupo Grupo { get; set; } = new Grupo();
        public Subgrupo Subgrupo { get; set; } = new Subgrupo();
        //custo e venda
        public double Custo { get; set; }
        //VENDA ----------------------------------------
        public double VendaComissao { get; set; }
        public double VendaPorcCom { get; set; }
        public double VendaAcrescimo { get; set; }
        public double VendaPorcAcresc { get; set; }
        public double VendaDesconto { get; set; }
        public double VendaPorcDesc { get; set; }
        public double VendaOutros { get; set; }
        public double VendaPorcOutros { get; set; }
        public double VendaMargem { get; set; }
        public double VendaLucro { get; set; }
        public double VendaPMZ { get; set; }//Preço margem zero - Sem margem de venda
        public double PrecoVenda { get; set; }

        //estoque
        public double QtdMinina { get; set; }
        public double QtdMaxima { get; set; }
        public Unidade UnidCompra { get; set; } = new Unidade();
        public double QtdEmb { get; set; }
        public double PesoBruto { get; set; }
        public double PesoLiquido { get; set; }
        public double Altura { get; set; }
        public double Largura { get; set; }
        public double Comprimento { get; set; }
        public string Localizacao { get; set; }

        public DateTime DtCadastro { get; set; }
        public DateTime DtAlteracao { get; set; }

        public string Imagem { get; set; }


        //entrada

    }
}
