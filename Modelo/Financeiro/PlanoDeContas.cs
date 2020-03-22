using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Financeiro
{
    public class PlanoDeContas
    {
        public int id { get; set; }
        public int codigo { get; set; }
        public string nome { get; set; }
        public bool entrada { get; set; }
        public bool saida { get; set; }
    }
}
