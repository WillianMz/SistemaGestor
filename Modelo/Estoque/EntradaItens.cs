using Modelo.Tributacao;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Estoque
{
    public class EntradaItens
    {
        public int Id { get; set; }
        public int idEntrada { get; set; }
        public Entrada entrada { get; set; } = new Entrada();
        public Produto produto { get; set; } = new Produto();
        public CST cst { get; set; } = new CST();
        public CFOP cfop { get; set; } = new CFOP();
        public Unidade unid { get; set; } = new Unidade();
        public double qtd { get; set; }
        public double vlUnit { get; set; }
        public double vlDesc { get; set; }  
        public double vlOutros { get; set; }
        public double vlTotal { get; set; }
        
        //imposto
        public double bcICMS { get; set; }
        public double vlICMS { get; set; }
        public double vlIPI { get; set; }
        public double alqICMS { get; set; }
        public double alqIPI { get; set; }
    }
}
