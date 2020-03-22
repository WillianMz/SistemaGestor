using DAO;
using Modelo.Financeiro;

namespace Controller
{
    public class BLL_Financeiro
    {
        DAO_Financeiro dao;

        public void novoPagar(Pagar p)
        {
            dao = new DAO_Financeiro();
            dao.insertPagar(p);
        }
    }
}
