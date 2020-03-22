namespace Modelo
{
    public abstract class Base
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Descricao
        {
            get { return Nome; }
        }
    }
}
