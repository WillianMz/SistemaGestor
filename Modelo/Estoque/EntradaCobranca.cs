using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Estoque
{
    public class EntradaCobranca
    {
        public int Id { get; set; }
        public int documento { get; set; }
        public DateTime dtVecimento { get; set; }
        public double valor { get; set; }
    }
}
