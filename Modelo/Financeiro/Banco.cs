using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Financeiro
{
    public class Banco
    {
        public int id { get; set; }
        public int idEmpresa { get; set; }
        public int codigo { get; set; }
        public string nome { get; set; }
        public string agencia  { get; set; }
        public string conta { get; set; }
        public bool ativo { get; set; }
    }
}
