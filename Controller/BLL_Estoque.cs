using DAO;
using Modelo.Estoque;
using System.Collections.Generic;

namespace Controller
{
    public class BLL_Estoque
    {
        DAO_Estoque dao;

        public List<TipoNota> tiposDeNotas()
        {
            dao = new DAO_Estoque();
            return dao.getTiposDeNotas();
        }

        public void NovaEntrada(Entrada ent)
        {
            dao = new DAO_Estoque();
            dao.insertEntrada(ent);
        }
    }
}
