namespace Modelo.Config
{
    public class ConfigSistema
    {
        //classe modelo para manipulacao de paramentros dos sistemas
        public static string versao = "1.0.0 [Beta]";

        //base de dados
        public string dbServer { get; set; }
        public int    dbPort { get; set; }
        public string dbBase { get; set; }
        public string dbUser { get; set; }
        public string dbPwd { get; set; }

        public bool   lembrarSenha { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public int    empresaPadrao { get; set; }
    }
}
