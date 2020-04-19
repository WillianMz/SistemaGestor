using DAO;
using Modelo.Estoque;
using System.Collections.Generic;

namespace Sistema.Estoque.Controles
{
    public class BLL_Produto
    {
        DAO_Produto dao;

        #region PRODUTO
        public void novoProduto(Produto p)
        {
            dao = new DAO_Produto();
            dao.insertProduto(p);
        }

        public void editarProduto(Produto p)
        {
            dao = new DAO_Produto();
            dao.updateProduto(p);
        }    

        public bool codbarrasCadastrado(string cod)
        {
            dao = new DAO_Produto();
            List<Produto> produtos = dao.codigoCadastrado(cod);

            if (produtos.Count > 0)
                return true;
            else
                return false;
        }

        public void ativarDesativar(int id, bool ativo)
        {
            dao = new DAO_Produto();
            dao.ativarDesativar(id, ativo);
        }

        public List<Produto> listarTodosOsProdutos(bool ativo)
        {
            dao = new DAO_Produto();
            List<Produto> ps = dao.selectAllProdutos(ativo);
            return ps;
        }

        public Produto detalhesDoProduto(int id)
        {
            dao = new DAO_Produto();
            Produto p = dao.getDetalhesDoProduto(id);
            return p;
        }

        #endregion

        #region FILTROS DE PRODUTOS

        //FILTROS DE PRODUTOS -------------------------------------
        public Produto filtrarProduto_ID(int id, bool ativo)
        {
            dao = new DAO_Produto();
            Produto p = dao.getProdutoPorID(id, ativo);
            return p;
        }

        public Produto filtrarProduto_CODIGO(string codigo, bool ativo)
        {
            dao = new DAO_Produto();
            Produto p = dao.getProdutoPorCodigo(codigo, ativo);
            return p;
        }

        public List<Produto> filtrarProduto_NOME(string filtro, bool ativo)
        {
            dao = new DAO_Produto();
            List<Produto> produtos = dao.selectProdutosPorNome(filtro, ativo);
            return produtos;
        }

        public List<Produto> filtrarProduto_DESCRICAO(string filtro, bool ativo)
        {
            dao = new DAO_Produto();
            List<Produto> produtos = dao.selectProdutosPorDescricao(filtro, ativo);
            return produtos;
        }

        public List<Produto> filtrarProduto_MARCA(string filtro, bool ativo)
        {
            dao = new DAO_Produto();
            List<Produto> produtos = dao.selectProdutosPorMarca(filtro, ativo);
            return produtos;
        }

        public List<Produto> filtrarProduto_FABRICANTE(string filtro, bool ativo)
        {
            dao = new DAO_Produto();
            List<Produto> produtos = dao.selectProdutoPorFabricante(filtro, ativo);
            return produtos;
        }

        //-----------------------------------------------------------

        #endregion

        #region UNIDADE
        public List<Unidade> buscarUnidade()
        {
            DAO_Produto dao = new DAO_Produto();
            return dao.selectUnidades();
        }
        #endregion

        #region TIPO PRODUTO
        public List<TipoProduto> buscarTpProduto()
        {
            DAO_Produto dao = new DAO_Produto();
            return dao.selectTipoProduto();
        }
        #endregion

        #region CATEGORIA

        /// <summary>
        /// RECEBE UM OBJETO CATEGORIA E GRAVA AS ALTERAÇÕES
        /// </summary>
        /// <param name="c"></param>
        public void gravarCategoria(Categoria c)
        {
            dao = new DAO_Produto();

            if (c.Id == 0)
                dao.insertCategoria(c);
            else
                dao.updateCategoria(c);
        }

        /// <summary>
        /// RETONA UM OBJETO CATEGORIA
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Categoria detalhesCategoria(int id)
        {
            dao = new DAO_Produto();
            Categoria cat = dao.getCategoriaPorID(id);
            return cat;            
        }

        /// <summary>
        /// LISTA TODAS AS CATEGORIAS - PASSAR O PARAMETRO (True OU False)
        /// </summary>
        /// <param name="ativo"></param>
        /// <returns></returns>
        public List<Categoria> listarCategorias(bool ativo)
        {
            dao = new DAO_Produto();
            return dao.selectAllCategorias(ativo);
        }

        /// <summary>
        /// CONSULTA AS CATEGORIAS PELO NOME PASSANDO O PARAMETRO True OU False
        /// </summary>
        /// <param name="filtro"></param>
        /// <param name="ativo"></param>
        /// <returns></returns>
        public List<Categoria> filtrarCategoriasPorNome(string filtro, bool ativo)
        {
            dao = new DAO_Produto();
            List<Categoria> cs = dao.selectCategoriasPorNome(filtro, ativo);
            return cs;
        }

        /// <summary>
        /// VERIFICA SE JA EXISTE ALGUMA CATEGORIA CADASTRADA
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public bool categoriaCadastrada(string nome)
        {
            dao = new DAO_Produto();
            List<Categoria> catg = dao.selectAllCategoriasPorNome(nome);

            if (catg.Count > 0)
                return true;
            else
                return false;
        }

        #endregion

        #region GRUPO

        /// <summary>
        /// GRAVA AS ALTERAÇÕES FEITA NO OBJETO GRUPO
        /// </summary>
        /// <param name="g"></param>
        public void gravarGrupo(Grupo g)
        {
            dao = new DAO_Produto();

            if (g.Id == 0)
                dao.insertGrupo(g);
            else
                dao.updateGrupo(g);
        }

        /// <summary>
        /// RETORNA UM OBJETO GRUPO
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Grupo detalhesGrupo(int id)
        {
            dao = new DAO_Produto();
            Grupo g = dao.getGrupoID(id);
            return g;
        }

        /// <summary>
        /// RETORNA UMA LISTA DE GRUPOS DE DETERMINADA CATEGORIA
        /// </summary>
        /// <param name="categ"></param>
        /// <param name="ativo"></param>
        /// <returns></returns>
        public List<Grupo> listarGrupos(Categoria categ, bool ativo)
        {
            dao = new DAO_Produto();
            return dao.selectGruposPorCateg(categ.Id, ativo);
        }

        /// <summary>
        /// RETONA UMA LISTA DE GRUPOS DE UMA CATEGORIA BUSCANDO PELO NOME
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="c"></param>
        /// <param name="ativo"></param>
        /// <returns></returns>
        public List<Grupo> filtrarGrupos(string nome, Categoria c, bool ativo)
        {
            dao = new DAO_Produto();
            List<Grupo> gs = dao.selectGruposPorNome(nome, c.Id, ativo);
            return gs;
        }
        
        /// <summary>
        /// VERIFICA SE UM GRUPO JÁ ESTA CADASTRADO - RETONA TRUE OU FALSE
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public bool grupoCadastrado(string nome)
        {
            dao = new DAO_Produto();
            List<Grupo> gr = dao.selectAllGruposPorNome(nome);

            if (gr.Count > 0)
                return true;
            else
                return false;
        }

        #endregion

        #region SUBGRUPO

        /// <summary>
        /// GRAVA UM OBJETO SUBGRUPO
        /// </summary>
        /// <param name="s"></param>
        public void gravarSubgrupo(Subgrupo s)
        {
            dao = new DAO_Produto();

            if (s.Id == 0)
                dao.insertSubgrupo(s);
            else
                dao.updateSubgrupo(s);
        }

        /// <summary>
        /// RETORNA UM OBJETO SUBGRUPO
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Subgrupo detalhesSubgrupo(int id)
        {
            dao = new DAO_Produto();
            Subgrupo s = dao.getSubgrupoID(id);
            return s;
        }

        /// <summary>
        /// RETONA UMA LISTA DE SUBGRUPOS DE DETERMINADO GRUPO
        /// </summary>
        /// <param name="grupo"></param>
        /// <param name="ativo"></param>
        /// <returns></returns>
        public List<Subgrupo> listarSubgrupos(Grupo grupo, bool ativo)
        {
            dao = new DAO_Produto();
            return dao.selectSubgruposPorGrupo(grupo.Id, ativo);
        }

        /// <summary>
        /// RETORNA UMA LISTA DE SUBGRUPOS DE UM GRUPO BUSCANDO PELO NOME
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="g"></param>
        /// <param name="ativo"></param>
        /// <returns></returns>
        public List<Subgrupo> filtrarSubgrupos(string nome, Grupo g, bool ativo)
        {
            dao = new DAO_Produto();
            List<Subgrupo> sg = dao.selectSubgruposPorNome(nome, g.Id, ativo);
            return sg;
        }        

        /// <summary>
        /// VERIFICA SE O SUBGRUPO JÁ ESTÁ CADASTRADO
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public bool subgrupoCadastrado(string nome)
        {
            dao = new DAO_Produto();
            List<Subgrupo> sub = dao.selectAllSubgrupoPorNome(nome);

            if (sub.Count > 0)
                return true;
            else
                return false;
        }

        #endregion
    }
}
