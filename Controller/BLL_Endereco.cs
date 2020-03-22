using DAO;
using Modelo.Localizacao;
using System.Collections.Generic;

namespace Controller
{
    public class BLL_Endereco
    {
        DAO_Endereco dao;

        public List<Pais> BuscaPais()
        {
            dao = new DAO_Endereco();
            return dao.getPaises();
        }

        public List<UF> BuscaUF(Pais pais)
        {
            dao = new DAO_Endereco();
            return dao.getEstados(pais);
        }

        public List<Cidade> BuscaCidade(UF uf)
        {
            dao = new DAO_Endereco();
            return dao.getCidades(uf);
        }

    }
}
