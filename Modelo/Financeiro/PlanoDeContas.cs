using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Financeiro
{
    public class PlanoDeContas
    {
        public int id { get; set; }
        public bool ativo { get; set; }
        public string nome { get; set; }
        public bool entrada { get; set; }
        public bool saida { get; set; }
        public string descricao { get; set; }
    }
}
