namespace Modelo
{
    public class ParamentroDoSistema
    {
        //classe modelo para manipulacao de paramentros dos sistemas

        //base de dados
        public string dbServer { get; set; }
        public int dbPort { get; set; }
        public string dbBase { get; set; }
        public string dbUser { get; set; }
        public string dbPwd { get; set; }
    }
}
