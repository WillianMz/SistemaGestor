using System;

namespace Modelo.Base
{
    public abstract class Pedido
    {
        public int id { get; set; }
        public Empresa empresa { get; set; }
        public DateTime data { get; set; }
        public DateTime MyProperty { get; set; }
    }
}
