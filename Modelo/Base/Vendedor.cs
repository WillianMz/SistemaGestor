using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Base
{
    public class Vendedor : Pessoa
    {
        public double comissaoPorProduto { get; set; }
        public double comissaoPorServico { get; set; }
    }
}
