using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Base
{
    public class Cliente : Pessoa
    {
        public string nomePai { get; set; }
        public string nomeMae { get; set; }
        public string nomeConjugue { get; set; }

        public int meioPagamento { get; set; }
        
    }
}
