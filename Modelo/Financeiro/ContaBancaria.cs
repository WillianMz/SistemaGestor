using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Financeiro
{
    public class ContaBancaria
    {
        public int id { get; set; }
        public Empresa empresa { get; set; } = new Empresa();
        public Banco banco { get; set; } = new Banco();
        public int agencia { get; set; }
        public int conta { get; set; }
        public string titular { get; set; }
    }
}
