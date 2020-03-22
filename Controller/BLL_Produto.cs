using DAO;
using Modelo.Estoque;
using System.Collections.Generic;

namespace Controller
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
        public void novaCategoria(Categoria c)
        {
            dao = new DAO_Produto();
            dao.insertCategoria(c);
        }

        public void editarCategoria(Categoria c)
        {
            dao = new DAO_Produto();
            dao.updateCategoria(c);
        }

        public Categoria detalhesCategoria(int id)
        {
            dao = new DAO_Produto();
            Categoria cat = dao.getCategoriaPorID(id);
            return cat;            
        }

        public List<Categoria> listarCategorias()
        {
            dao = new DAO_Produto();
            return dao.selectAllCategorias();
        }

        public List<Categoria> filtrarCategorias(string filtro, bool ativo)
        {
            dao = new DAO_Produto();
            List<Categoria> cs = dao.selectCategoriasPorNome(filtro, ativo);
            return cs;
        }

        public bool categoriaCadastrada(string nome)
        {
            dao = new DAO_Produto();
            List<Categoria> catg = dao.selectCategoriasPorNome(nome,true);

            if (catg.Count > 0)
                return true;
            else
                return false;
        }

        #endregion

        #region GRUPO
        public void novoGrupo(Grupo g)
        {
            dao = new DAO_Produto();
            dao.insertGrupo(g);
        }

        public void editarGrupo(Grupo g)
        {
            dao = new DAO_Produto();
            dao.updateGrupo(g);
        }

        public Grupo detalhesGrupo(int id)
        {
            dao = new DAO_Produto();
            Grupo g = dao.getGrupoID(id);
            return g;
        }

        public List<Grupo> listarGrupos()
        {
            dao = new DAO_Produto();
            return dao.selectAllGrupos();
        }

        public List<Grupo> filtrarGrupos(string filtro, bool ativo)
        {
            dao = new DAO_Produto();
            List<Grupo> gs = dao.selectGruposPorNome(filtro, ativo);
            return gs;
        }
        
        public bool grupoCadastrado(string nome)
        {
            dao = new DAO_Produto();
            List<Grupo> gr = dao.selectGruposPorNome(nome, true);

            if (gr.Count > 0)
                return true;
            else
                return false;
        }

        #endregion

        #region SUBGRUPO
        public void novoSubgrupo(Subgrupo s)
        {
            dao = new DAO_Produto();
            dao.insertSubgrupo(s);
        }

        public void editarSubgrupo(Subgrupo s)
        {
            dao = new DAO_Produto();
            dao.updateSubgrupo(s);
        }

        public List<Subgrupo> listarSubgrupos(Grupo grupo)
        {
            dao = new DAO_Produto();
            return dao.selectSubgrupos(grupo);
        }

        public List<Subgrupo> filtrarSubgrupos(string filtro, bool ativo, Grupo g)
        {
            dao = new DAO_Produto();
            List<Subgrupo> sg = dao.selectSubgruposPorNome(filtro, ativo, g.Id);
            return sg;
        }

        public Subgrupo detalhesSubgrupo(int id)
        {
            dao = new DAO_Produto();
            Subgrupo s = dao.getSubgrupoID(id);
            return s;
        }

        public bool subgrupoCadastrado(string nome, Grupo g)
        {
            dao = new DAO_Produto();
            List<Subgrupo> sub = dao.selectSubgruposPorNome(nome, true, g.Id);

            if (sub.Count > 0)
                return true;
            else
                return false;
        }

        #endregion
    }
}
