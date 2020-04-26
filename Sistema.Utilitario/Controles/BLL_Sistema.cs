using Modelo.Config;

namespace Sistema.Utilitario.Controles
{
    public class BLL_Sistema
    {
        #region INICIALIZAÇÃO DO PROGRAMA

        public ConfigSistema getParamentros(string software)
        {
            ConfigSistema config = RegEditWindows.lerDadosRegistroWindows(software);
            return config;
        }

        public void salvarParamentros(string software, ConfigSistema config)
        {
            RegEditWindows.gravarDadosRegistroWindows(software, config);
        }
        #endregion

    }
}