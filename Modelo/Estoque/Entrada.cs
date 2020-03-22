using System;
using System.Collections.Generic;

namespace Modelo.Estoque
{
    public class Entrada
    {
        public int Id { get; set; }
        public Empresa empresa { get; set; } = new Empresa();//destinatario
        public TipoNota tipoNota { get; set; } = new TipoNota();
        public DateTime dhEntrada { get; set; }//data hora de entrada no sistema
        public Pessoa fornec { get; set; } = new Pessoa();//emitente
        //cabecalho nota fiscal
        public int cfop { get; set; }
        public string natOperacao { get; set; }
        public string chaveNFE { get; set; }
        public string versaoNFE { get; set; }
        public string protAutorizacao { get; set; }
        public int numeroNota { get; set; }
        public int serieNota { get; set; }
        public int modelo { get; set; }
        public DateTime dhEmissao { get; set; }
        public DateTime dhSaiEnt { get; set; }

        //calculo do imposto
        public double vBCICMS { get; set; }
        public double vICMS { get; set; }
        public double vICMSDeson { get; set; }
        public double vFCP { get; set; }
        public double vBCST { get; set; }
        public double vST { get; set; }
        public double vFCPST { get; set; }
        public double vFCPSTRet { get; set; }
        public double vProd { get; set; }
        public double vFrete { get; set; }
        public double vSeguro { get; set; }
        public double vDesc { get; set; }
        public double vII { get; set; }
        public double vIPI { get; set; }
        public double vIPIDevol { get; set; }
        public double vPIS { get; set; }
        public double vCOFINS { get; set; }
        public double vOutro { get; set; }
        public double totalNF { get; set; }

        //transporte
        public Pessoa transp { get; set; } = new Pessoa();
        public int modFrete { get; set; }

        //volumes
        public double qVol { get; set; }
        public string especie { get; set; }
        public double pesoBruto { get; set; }
        public double pesoLiquido { get; set; }

        //cobranca
        public List<EntradaCobranca> cobranca { get; set; } = new List<EntradaCobranca>();
        public List<EntradaCobranca> frete { get; set; } = new List<EntradaCobranca>();

        //produtos
        public List<EntradaItens> itens { get; set; } = new List<EntradaItens>();
        public List<Produto_Item> item { get; set; } = new List<Produto_Item>();

        //dados adicionais
        public string anotacao { get; set; }
        public string obsFisco { get; set; }

        public bool confirmada { get; set; }
        public DateTime? dtConfirmada { get; set; }
        public bool cancelada { get; set; }
        public DateTime? dtCancelada { get; set; }
        public string motivoCancelamento { get; set; }

        public int pedido { get; set; }

        public string arquivoXML { get; set; }
    }
}
