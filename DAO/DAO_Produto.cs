using Modelo.Estoque;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAO
{
    public class DAO_Produto
    {
        Conexao con = Conexao.GetInstancia();
        NpgsqlCommand cmd;
        string SQL;

        #region PRODUTO
        public void insertProduto(Produto p)
        {
            try
            {
                cmd = new NpgsqlCommand();

                SQL = "INSERT INTO produto ";
                SQL += "(ativo, tp_produto, codigo, nome, descricao, id_unid, balanca, marca, fabricante, id_categ, id_grupo, id_subgrupo, ";
                SQL += "custo, v_com, v_com_p, v_desc, v_desc_p, v_outros, v_outros_p, v_margem, v_lucro, venda, ";
                SQL += "qtd_min, qtd_max, tp_un_compra, qtd_emb, pbruto, pliquido, altura, largura, comprimento, ";
                SQL += "localizacao, dtcadastro, dtalteracao, imagem) ";
                SQL += "VALUES";
                SQL += "(@ativo, @tp_produto, @codigo, @nome, @descricao, @id_unid, @balanca, @marca, @fabricante, @id_categ, @id_grupo, @id_subgrupo,  ";
                SQL += "@custo, @v_com, @v_com_p, @v_desc, @v_desc_p, @v_outros, @v_outros_p, @v_margem, @v_lucro, @venda, ";
                SQL += "@qtd_min, @qtd_max, @tp_un_compra, @qtd_emb, @pbruto, @pliquido, @altura, @largura, @comprimento, ";
                SQL += "@localizacao, @dtcadastro, @dtalteracao, @imagem) ";

                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@ativo",        p.Ativo);
                cmd.Parameters.AddWithValue("@tp_produto",   p.TipoProduto.Id);
                cmd.Parameters.AddWithValue("@codigo",       p.Codigo);
                cmd.Parameters.AddWithValue("@nome",         p.Nome);
                cmd.Parameters.AddWithValue("@descricao",    p.Descricao);
                cmd.Parameters.AddWithValue("@id_unid",      p.Unidade.Id);
                cmd.Parameters.AddWithValue("@balanca",      p.Balanca);
                cmd.Parameters.AddWithValue("@marca",        p.Marca);
                cmd.Parameters.AddWithValue("@fabricante",   p.Fabricante);
                cmd.Parameters.AddWithValue("@id_categ",     p.Categoria.Id);
                cmd.Parameters.AddWithValue("@id_grupo",     p.Grupo.Id);
                cmd.Parameters.AddWithValue("@id_subgrupo",  p.Subgrupo.Id);
                cmd.Parameters.AddWithValue("@custo",        p.Custo);
                cmd.Parameters.AddWithValue("@v_com",        p.VendaComissao);
                cmd.Parameters.AddWithValue("@v_com_p",      p.VendaPorcCom);
                cmd.Parameters.AddWithValue("@v_desc",       p.VendaDesconto);
                cmd.Parameters.AddWithValue("@v_desc_p",     p.VendaPorcDesc);
                cmd.Parameters.AddWithValue("@v_outros",     p.VendaOutros);
                cmd.Parameters.AddWithValue("@v_outros_p",   p.VendaPorcOutros);
                cmd.Parameters.AddWithValue("@v_margem",     p.VendaMargem);
                cmd.Parameters.AddWithValue("@v_lucro",      p.VendaLucro);
                cmd.Parameters.AddWithValue("@venda",        p.PrecoVenda);
                cmd.Parameters.AddWithValue("@qtd_min",      p.QtdMinina);
                cmd.Parameters.AddWithValue("@qtd_max",      p.QtdMaxima);
                cmd.Parameters.AddWithValue("@tp_un_compra", p.UnidCompra.Id);
                cmd.Parameters.AddWithValue("@qtd_emb",      p.QtdEmb);
                cmd.Parameters.AddWithValue("@pbruto",       p.PesoBruto);
                cmd.Parameters.AddWithValue("@pliquido",     p.PesoLiquido);
                cmd.Parameters.AddWithValue("@altura",       p.Altura);
                cmd.Parameters.AddWithValue("@largura",      p.Largura);
                cmd.Parameters.AddWithValue("@comprimento",  p.Comprimento);
                cmd.Parameters.AddWithValue("@localizacao",  p.Localizacao);
                cmd.Parameters.AddWithValue("@dtcadastro",   p.DtCadastro);
                cmd.Parameters.AddWithValue("@dtalteracao",  p.DtAlteracao);
                cmd.Parameters.AddWithValue("@imagem",       p.Imagem);
                con.ComandoSQL(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void updateProduto(Produto p)
        {
            try
            {
                cmd = new NpgsqlCommand();

                SQL = "UPDATE produto ";
                SQL += "SET ativo = @ativo, tp_produto = @tp_produto, codigo = @codigo, nome = @nome, descricao = @descricao, id_unid = @id_unid, balanca = @balanca, ";
                SQL += "marca = @marca, fabricante = @fabricante, id_categ = @id_categ, id_grupo = @id_grupo, id_subgrupo = @id_subgrupo, ";
                SQL += "custo = @custo, v_com = @v_com, v_com_p = @v_com_p, v_desc = @v_desc, v_desc_p = @v_desc_p, ";
                SQL += "v_outros = @v_outros, v_outros_p = @v_outros_p, v_margem = @v_margem, v_lucro = @v_lucro, venda = @venda, ";
                SQL += "qtd_min = @qtd_min, qtd_max = @qtd_max, tp_un_compra = @tp_un_compra, qtd_emb = @qtd_emb, pbruto = @pbruto, pliquido = @pliquido, ";
                SQL += "altura = @altura, largura = @largura, comprimento = @comprimento, localizacao = @local, dtalteracao = @dtalteracao, imagem = @imagem ";
                SQL += "WHERE id = @id";

                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@id",           p.Id);
                cmd.Parameters.AddWithValue("@ativo",        p.Ativo);
                cmd.Parameters.AddWithValue("@tp_produto",   p.TipoProduto.Id);
                cmd.Parameters.AddWithValue("@codigo",       p.Codigo);
                cmd.Parameters.AddWithValue("@nome",         p.Nome);
                cmd.Parameters.AddWithValue("@descricao",    p.Descricao);
                cmd.Parameters.AddWithValue("@id_unid",      p.Unidade.Id);
                cmd.Parameters.AddWithValue("@balanca",      p.Balanca);
                cmd.Parameters.AddWithValue("@marca",        p.Marca);
                cmd.Parameters.AddWithValue("@fabricante",   p.Fabricante);
                cmd.Parameters.AddWithValue("@id_categ",     p.Categoria.Id);
                cmd.Parameters.AddWithValue("@id_grupo",     p.Grupo.Id);
                cmd.Parameters.AddWithValue("@id_subgrupo",  p.Subgrupo.Id);
                cmd.Parameters.AddWithValue("@custo",        p.Custo);
                cmd.Parameters.AddWithValue("@v_com",        p.VendaComissao);
                cmd.Parameters.AddWithValue("@v_com_p",      p.VendaPorcCom);
                cmd.Parameters.AddWithValue("@v_desc",       p.VendaDesconto);
                cmd.Parameters.AddWithValue("@v_desc_p",     p.VendaPorcDesc);
                cmd.Parameters.AddWithValue("@v_outros",     p.VendaOutros);
                cmd.Parameters.AddWithValue("@v_outros_p",   p.VendaPorcOutros);
                cmd.Parameters.AddWithValue("@v_margem",     p.VendaMargem);
                cmd.Parameters.AddWithValue("@v_lucro",      p.VendaLucro);
                cmd.Parameters.AddWithValue("@venda",        p.PrecoVenda);
                cmd.Parameters.AddWithValue("@qtd_min",      p.QtdMinina);
                cmd.Parameters.AddWithValue("@qtd_max",      p.QtdMaxima);
                cmd.Parameters.AddWithValue("@tp_un_compra", p.UnidCompra.Id);
                cmd.Parameters.AddWithValue("@qtd_emb",      p.QtdEmb);
                cmd.Parameters.AddWithValue("@pbruto",       p.PesoBruto);
                cmd.Parameters.AddWithValue("@pliquido",     p.PesoLiquido);
                cmd.Parameters.AddWithValue("@altura",       p.Altura);
                cmd.Parameters.AddWithValue("@largura",      p.Largura);
                cmd.Parameters.AddWithValue("@comprimento",  p.Comprimento);
                cmd.Parameters.AddWithValue("@local",        p.Localizacao);
                cmd.Parameters.AddWithValue("@dtalteracao",  p.DtAlteracao);
                cmd.Parameters.AddWithValue("@imagem",       p.Imagem);
                con.ComandoSQL(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ativarDesativar(int id, bool ativo)
        {
            try
            {
                cmd = new NpgsqlCommand();
                SQL = "UPDATE produto SET ativo = @ativo WHERE id = @id";
                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@ativo", ativo);
                con.ComandoSQL(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Produto> codigoCadastrado(string Codigo)//Busca na base se o código de barras já esta cadastrado
        {
            try
            {
                SQL = string.Format("SELECT codigo FROM produto WHERE codigo = '{0}'", Codigo);
                DataSet ds = con.ConsultaSQL(SQL);
                List<Produto> produtos = new List<Produto>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Produto p = new Produto();
                    p.Codigo = dr["codigo"].ToString();
                    produtos.Add(p);
                }
                return produtos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region CONSULTAS

        /// <summary>
        /// Retorna uma lista de objetos(Produtos)
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private List<Produto> retornaProdutos(string sql)
        {
            try
            {
                DataSet ds = con.ConsultaSQL(sql);
                List<Produto> produtos = new List<Produto>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Produto p = new Produto
                    {
                        Id          = int.Parse(dr["id"].ToString()),
                        Codigo      = dr["codigo"].ToString(),
                        Nome        = dr["nome"].ToString(),
                        Descricao   = dr["descricao"].ToString(),
                        Custo       = double.Parse(dr["custo"].ToString()),
                        PrecoVenda  = double.Parse(dr["venda"].ToString()),
                        VendaMargem = double.Parse(dr["v_margem"].ToString()),
                        Marca       = dr["marca"].ToString(),
                        Fabricante  = dr["fabricante"].ToString(),
                        Imagem      = dr["imagem"].ToString()
                    };
                    produtos.Add(p);
                }

                return produtos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Retorna um objeto Pessoa
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private Produto retornaProduto(string sql)
        {
            try
            {
                DataSet ds = con.ConsultaSQL(sql);
                Produto p = null;

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    p = new Produto
                    {
                        Id          = int.Parse(dr["id"].ToString()),
                        Codigo      = dr["codigo"].ToString(),
                        Nome        = dr["nome"].ToString(),
                        Descricao   = dr["descricao"].ToString(),
                        Custo       = double.Parse(dr["custo"].ToString()),
                        PrecoVenda  = double.Parse(dr["venda"].ToString()),
                        VendaMargem = double.Parse(dr["v_margem"].ToString()),
                        Marca       = dr["marca"].ToString(),
                        Fabricante  = dr["fabricante"].ToString(),
                        Imagem      = dr["imagem"].ToString()
                    };
                }
                return p;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Produto> selectAllProdutos(bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT id, codigo, nome, descricao, custo, venda, v_margem FROM produto WHERE ativo = {0} ORDER BY id", ativo);
                return retornaProdutos(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Produto getProdutoPorID(int id, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT id, codigo, nome, descricao, custo, venda, v_margem, marca, fabricante, imagem FROM produto WHERE id = {0} AND ativo = {1}", id, ativo);
                return retornaProduto(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Produto getProdutoPorCodigo(string codigo, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT id, codigo, nome, descricao, custo, venda, v_margem, marca, fabricante, imagem FROM produto WHERE codigo = {0} AND ativo = {1}", codigo, ativo);
                return retornaProduto(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Produto> selectProdutosPorNome(string nome, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT id, codigo, nome, descricao, custo, venda, v_margem, marca, fabricante, imagem FROM produto WHERE nome LIKE '%{0}%' AND ativo = {1}", nome, ativo);
                return retornaProdutos(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Produto> selectProdutosPorDescricao(string descricao, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT id, codigo, nome, descricao, custo, venda, v_margem, marca, fabricante, imagem FROM produto WHERE descricao LIKE '%{0}%' AND ativo = {1}", descricao, ativo);
                return retornaProdutos(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Produto> selectProdutosPorMarca(string marca, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT id, codigo, nome, descricao, custo, venda, v_margem, marca, fabricante, imagem FROM produto WHERE marca LIKE '%{0}%' AND ativo = {1}", marca, ativo);
                return retornaProdutos(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Produto> selectProdutoPorFabricante(string fabricante, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT id, codigo, nome, descricao, custo, venda, v_margem, marca, fabricante, imagem FROM produto WHERE fabricante LIKE '%{0}%' AND ativo = {1}", fabricante, ativo);
                return retornaProdutos(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Produto getDetalhesDoProduto(int id)
        {
            try
            {
                SQL = string.Format("SELECT id, ativo, tp_produto, codigo, nome, descricao, id_unid, balanca, marca, fabricante, " +
                                     "id_categ, id_grupo, id_subgrupo, " +
                                     "custo, v_com, v_com_p, v_desc, v_desc_p, v_outros, v_outros_p, v_margem, v_lucro, venda, " +
                                     "qtd_min, qtd_max, tp_un_compra, qtd_emb, pbruto, pliquido, " +
                                     "altura, largura, comprimento, localizacao, dtcadastro, dtalteracao, imagem " +
                                     "FROM produto " +
                                     "WHERE id = {0}", id);

                DataSet ds = con.ConsultaSQL(SQL);
                Produto p = null;

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    p = new Produto();
                    Unidade unid     = new Unidade();
                    Unidade unCompra = new Unidade();
                    Categoria categ  = new Categoria();
                    Grupo grupo      = new Grupo();
                    Subgrupo subg    = new Subgrupo();
                    TipoProduto tipo = new TipoProduto();

                    p.Id             = int.Parse(dr["id"].ToString());
                    p.Ativo          = bool.Parse(dr["ativo"].ToString());
                    //tipo produto
                    p.TipoProduto.Id = int.Parse(dr["tp_produto"].ToString());
                    tipo             = getTpProdutoPorID(p.TipoProduto.Id);
                    p.TipoProduto    = tipo;

                    p.Codigo         = dr["codigo"].ToString();
                    p.Nome           = dr["nome"].ToString();
                    p.Descricao      = dr["descricao"].ToString();
                    //unidade
                    p.Unidade.Id     = int.Parse(dr["id_unid"].ToString());
                    unid             = getUnidadePorID(p.Unidade.Id);
                    p.Unidade        = unid;

                    p.Balanca        = bool.Parse(dr["balanca"].ToString());
                    p.Marca          = dr["marca"].ToString();
                    p.Fabricante     = dr["fabricante"].ToString();
                    //categoria
                    p.Categoria.Id   = int.Parse(dr["id_categ"].ToString());
                    categ            = getCategoriaPorID(p.Categoria.Id);
                    p.Categoria      = categ;
                    //grupo
                    p.Grupo.Id       = int.Parse(dr["id_grupo"].ToString());
                    grupo            = getGrupoID(p.Grupo.Id);
                    p.Grupo          = grupo;
                    //subgrupo
                    p.Subgrupo.Id    = int.Parse(dr["id_subgrupo"].ToString());
                    subg             = getSubgrupoID(p.Subgrupo.Id);
                    p.Subgrupo       = subg;

                    p.Custo           = double.Parse(dr["custo"].ToString());
                    p.VendaComissao   = double.Parse(dr["v_com"].ToString());
                    p.VendaPorcCom    = double.Parse(dr["v_com_p"].ToString());
                    p.VendaDesconto   = double.Parse(dr["v_desc"].ToString());
                    p.VendaPorcDesc   = double.Parse(dr["v_desc_p"].ToString());
                    p.VendaOutros     = double.Parse(dr["v_outros"].ToString());
                    p.VendaPorcOutros = double.Parse(dr["v_outros_p"].ToString());
                    p.VendaMargem     = double.Parse(dr["v_margem"].ToString());
                    p.VendaLucro      = double.Parse(dr["v_lucro"].ToString());
                    p.PrecoVenda      = double.Parse(dr["venda"].ToString());
                    p.QtdMinina       = double.Parse(dr["qtd_min"].ToString());
                    p.QtdMaxima       = double.Parse(dr["qtd_max"].ToString());

                    //unidade de compra
                    p.UnidCompra.Id = int.Parse(dr["tp_un_compra"].ToString());
                    unCompra = getUnidadePorID(p.UnidCompra.Id);
                    p.UnidCompra = unCompra;

                    p.QtdEmb      = double.Parse(dr["qtd_emb"].ToString());
                    p.PesoBruto   = double.Parse(dr["pbruto"].ToString());
                    p.PesoLiquido = double.Parse(dr["pliquido"].ToString());
                    p.Altura      = double.Parse(dr["altura"].ToString());
                    p.Largura     = double.Parse(dr["largura"].ToString());
                    p.Comprimento = double.Parse(dr["comprimento"].ToString());
                    p.Localizacao = dr["localizacao"].ToString();
                    p.DtCadastro  = DateTime.Parse(dr["dtcadastro"].ToString());
                    p.DtAlteracao = DateTime.Parse(dr["dtalteracao"].ToString());
                    p.Imagem      = dr["imagem"].ToString();
                }
                return p;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region UNIDADE
        public List<Unidade> selectUnidades()
        {
            try
            {
                SQL = string.Format("SELECT id, nome FROM produto_unid ORDER BY id");
                DataSet ds = con.ConsultaSQL(SQL);

                List<Unidade> unid = new List<Unidade>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Unidade u = new Unidade
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        Nome = dr["nome"].ToString()
                    };
                    unid.Add(u);
                }

                return unid;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Unidade getUnidadePorID(int id)
        {
            try
            {
                SQL = string.Format("SELECT id, nome FROM produto_unid WHERE id = {0}", id);
                DataSet ds = con.ConsultaSQL(SQL);
                Unidade u = null;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    u = new Unidade
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        Nome = dr["nome"].ToString()
                    };
                }
                return u;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region TIPO PRODUTO
        public List<TipoProduto> selectTipoProduto()
        {
            try
            {
                SQL = string.Format("SELECT id, nome FROM produto_tipo ORDER BY id");
                DataSet ds = con.ConsultaSQL(SQL);

                List<TipoProduto> lista = new List<TipoProduto>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    TipoProduto obj = new TipoProduto
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        Nome = dr["nome"].ToString()
                    };
                    lista.Add(obj);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public TipoProduto getTpProdutoPorID(int id)
        {
            try
            {
                SQL = string.Format("SELECT id, nome FROM produto_tipo WHERE id = {0}", id);
                DataSet ds = con.ConsultaSQL(SQL);
                TipoProduto obj = null;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    obj = new TipoProduto
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        Nome = dr["nome"].ToString()
                    };
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region CATEGORIA
        public void insertCategoria(Categoria cat)
        {
            try
            {
                cmd = new NpgsqlCommand();
                SQL = "INSERT INTO produto_categ(nome) VALUES (@nome)";
                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@nome", cat.Nome);
                con.ComandoSQL(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void updateCategoria(Categoria cat)
        {
            try
            {
                cmd = new NpgsqlCommand();
                SQL = "UPDATE produto_categ SET nome = @nome WHERE id = @id";
                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@nome", cat.Nome);
                cmd.Parameters.AddWithValue("@id", cat.Id);
                con.ComandoSQL(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Categoria> selectAllCategorias()
        {
            try
            {
                SQL = "SELECT id, nome FROM produto_categ";
                DataSet ds = con.ConsultaSQL(SQL);

                List<Categoria> lista = new List<Categoria>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Categoria obj = new Categoria
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        Nome = dr["nome"].ToString()
                    };
                    lista.Add(obj);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Categoria getCategoriaPorID(int id)
        {
            try
            {
                SQL = string.Format("SELECT id, nome FROM produto_categ WHERE id = {0}", id);
                DataSet ds = con.ConsultaSQL(SQL);
                Categoria obj = null;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    obj = new Categoria
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        Nome = dr["nome"].ToString()
                    };
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Categoria> selectCategoriasPorNome(string nome, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT id, nome FROM produto_categ WHERE nome LIKE '%{0}%' AND ativo = {1} ORDER BY nome", nome, ativo);
                DataSet ds = con.ConsultaSQL(SQL);

                List<Categoria> lista = new List<Categoria>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Categoria obj = new Categoria
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        Nome = dr["nome"].ToString()
                    };
                    lista.Add(obj);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region GRUPO
        public void insertGrupo(Grupo g)
        {
            try
            {
                cmd = new NpgsqlCommand();
                SQL = "INSERT INTO produto_grupo(nome, id_categ) VALUES (@nome, @id_categ)";
                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@nome", g.Nome);
                cmd.Parameters.AddWithValue("@id_categ", g.categ.Id);
                con.ComandoSQL(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void updateGrupo(Grupo g)
        {
            try
            {
                cmd = new NpgsqlCommand();
                SQL = "UPDATE produto_grupo SET nome = @nome, id_categ = @id_categ WHERE id = @id";
                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@nome", g.Nome);
                cmd.Parameters.AddWithValue("id_Categ", g.categ.Id);
                cmd.Parameters.AddWithValue("@id", g.Id);
                con.ComandoSQL(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Grupo> selectAllGrupos()
        {
            try
            {
                SQL = string.Format("SELECT id, nome FROM produto_grupo ");
                DataSet ds = con.ConsultaSQL(SQL);
                List<Grupo> lista = new List<Grupo>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Grupo obj = new Grupo
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        Nome = dr["nome"].ToString()
                    };
                    lista.Add(obj);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Grupo getGrupoID(int id)
        {
            try
            {
                SQL = string.Format("SELECT id, nome FROM produto_grupo WHERE id = {0}", id);
                DataSet ds = con.ConsultaSQL(SQL);
                Grupo obj = null;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    obj = new Grupo();
                    obj.Id = int.Parse(dr["id"].ToString());
                    obj.Nome = dr["nome"].ToString();
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Grupo> selectGruposPorNome(string nome, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT id, nome, ativo FROM produto_grupo WHERE nome LIKE '%{0}%' AND ativo = {1} ORDER BY nome", nome, ativo);
                DataSet ds = con.ConsultaSQL(SQL);
                List<Grupo> lista = new List<Grupo>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Grupo obj = new Grupo
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        Nome = dr["nome"].ToString()
                    };
                    lista.Add(obj);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region SUBGRUPO
        public void insertSubgrupo(Subgrupo s)
        {
            try
            {
                cmd = new NpgsqlCommand();
                SQL = "INSERT INTO produto_subgrupo(nome, id_grupo) VALUES (@nome, @grupo)";
                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@nome", s.Nome);
                cmd.Parameters.AddWithValue("@grupo", s.grupo.Id);
                con.ComandoSQL(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void updateSubgrupo(Subgrupo s)
        {
            try
            {
                cmd = new NpgsqlCommand();
                SQL = "UPDATE produto_subgrupo SET nome = @nome, id_grupo = @grupo WHERE id = @id";
                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@nome", s.Nome);
                cmd.Parameters.AddWithValue("@grupo", s.grupo.Id);
                cmd.Parameters.AddWithValue("@id", s.Id);
                con.ComandoSQL(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Subgrupo> selectSubgrupos(Grupo grupo)
        {
            try
            {
                SQL = string.Format("SELECT id, nome, id_grupo FROM produto_subgrupo WHERE id_grupo = {0}", grupo.Id);
                DataSet ds = con.ConsultaSQL(SQL);
                List<Subgrupo> lista = new List<Subgrupo>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Subgrupo obj = new Subgrupo
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        Nome = dr["nome"].ToString()
                    };
                    lista.Add(obj);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Subgrupo getSubgrupoID(int id)
        {
            try
            {
                SQL = string.Format("SELECT id, nome, id_grupo FROM produto_subgrupo WHERE id = {0}", id);
                DataSet ds = con.ConsultaSQL(SQL);

                Subgrupo sub = null;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    sub = new Subgrupo();
                    Grupo grupo = new Grupo();
                    sub.Id = int.Parse(dr["id"].ToString());
                    sub.Nome = dr["nome"].ToString();
                    //grupo
                    sub.grupo.Id = int.Parse(dr["id_grupo"].ToString());
                    grupo = getGrupoID(sub.grupo.Id);
                    sub.grupo = grupo;
                }
                return sub;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Subgrupo> selectSubgruposPorNome(string nome, bool ativo, int idGrupo)
        {
            try
            {
                SQL = string.Format("SELECT id, nome FROM produto_subgrupo WHERE nome LIKE '%{0}%' AND ativo = {1} AND  id_grupo = {2} ORDER BY id", nome, ativo, idGrupo);
                DataSet ds = con.ConsultaSQL(SQL);

                List<Subgrupo> lista = new List<Subgrupo>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Subgrupo obj = new Subgrupo();
                    obj.Id = int.Parse(dr["id"].ToString());
                    obj.Nome = dr["nome"].ToString();
                    lista.Add(obj);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

    }
}
