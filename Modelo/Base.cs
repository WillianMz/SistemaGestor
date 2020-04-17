namespace Modelo
{
    public abstract class Base
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public bool ativo { get; set; }

        public string Descricao
        {
            get { return nome; }
        }
    }
}
