using Util;

namespace Sistema.Utilitario.Controles
{
    public class BLL_Sistema
    {
        #region INICIALIZAÇÃO DO PROGRAMA

        public ConfigSistema getParamentros(string software)
        {
            //ConfigSistema config = util_sistema.lerDadosRegistroWindows(software);
            ConfigSistema config = RegEditWindows.lerDadosRegistroWindows(software);
            return config;
        }

        public void salvarParamentros(string software, ConfigSistema config)
        {
            //util_sistema.gravarDadosRegistroWindows(software, config);
            RegEditWindows.gravarDadosRegistroWindows(software, config);
        }
        #endregion

    }
}