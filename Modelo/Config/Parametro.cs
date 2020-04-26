namespace Modelo.Config
{
    public static class Parametro
    {
        public static class SQL
        {
            public static string servidor;
            public static int    porta;
            public static string banco;
            public static string userBD;
            public static string senhaBD;
        }

        public static class UsuarioLogado
        {
            public static int    empresa;
            public static string nomeEmpresa;
            public static int    idUser;
            public static string nomeUser;
        }
    }
}
