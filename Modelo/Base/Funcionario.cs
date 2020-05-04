using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Base
{
    public class Funcionario : Pessoa
    {
        public string carteiraTrab { get; set; }
        public string CNH { get; set; }
        public string catCNH { get; set; }
    }
}
