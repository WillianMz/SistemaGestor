using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Modelo.Financeiro;



namespace Sistema.Financeiro.Controles
{
    public class BLL_Banco
    {
        DAO_Banco dao;
        public void novo(Banco b)
        {
            dao = new DAO_Banco();
            dao.insert(b);
        }
    }
}
