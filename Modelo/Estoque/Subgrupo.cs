namespace Modelo.Estoque
{
    public class Subgrupo : ModeloBase
    {
        public Grupo grupo { get; set; } = new Grupo();
    }
}
