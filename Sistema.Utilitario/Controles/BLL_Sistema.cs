using Modelo;
using Util;

namespace Sistema.Utilitario.Controles
{
    public class BLL_Sistema
    {
        #region INICIALIZAÇÃO DO PROGRAMA

        public ParamentroDoSistema getParamentros(string software)
        {
            ParamentroDoSistema p = new ParamentroDoSistema();
            p = util_sistema.lerDadosRegistroWindows(software);
            return p;
        }

        public void salvarParamentros(string software, ParamentroDoSistema ps)
        {
            util_sistema.gravarDadosRegistroWindows(software, ps);
        }

        #endregion
    }
}
