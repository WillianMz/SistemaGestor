using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.User
{
    public class Usuario
    {
        public int Id { get; set; }
        public string login { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public Nivel nivel { get; set; }
        public bool ativo { get; set; }
    }
}
