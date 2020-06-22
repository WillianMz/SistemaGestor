using Modelo.Config;
using System.CodeDom.Compiler;

namespace Sistema.Utilitario.Controles
{
    public class BLL_Sistema
    {
        #region INICIALIZAÇÃO DO PROGRAMA

        public ConfigSistema parametrosBaseDeDados(string software)
        {
            ConfigSistema config = RegEditWindows.lerDadosDeAcessoBancoDeDados(software);
            return config;
        }

        public void salvarParametrosDeBaseDeDados(string software, ConfigSistema config)
        {
            RegEditWindows.gravarDadosDeBancoDeDados(software, config);
        }

        public ConfigSistema dadosDeLogin(string software)
        {
            ConfigSistema cf = RegEditWindows.lerDadosDeLogin(software);
            return cf;
        }

        public void salvarDadosDeLogin(string software, ConfigSistema cf)
        {
            RegEditWindows.gravarDadosDeLogin(software, cf);
        }


        #endregion

    }
}