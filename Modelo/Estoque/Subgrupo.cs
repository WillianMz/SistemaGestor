namespace Modelo.Estoque
{
    public class Subgrupo : Base
    {
        public Grupo grupo { get; set; } = new Grupo();
    }
}
