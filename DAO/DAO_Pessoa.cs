using Modelo;
using Modelo.Localizacao;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAO
{
    public class DAO_Pessoa
    {
        Conexao con = Conexao.GetInstancia();
        NpgsqlCommand cmd;
        string SQL;

        #region PESSOA
        public void insert(Pessoa p)
        {
            try
            {
                cmd = new NpgsqlCommand();

                SQL = "INSERT INTO pessoa ";
                SQL += "(ativo, id_tipo, cliente, fornecedor, funcionario, transportador, outro, cpf_cnpj, nome_completo, ";
                SQL += "fantasia, rg_ie, cep, id_pais, id_uf, id_cidade, bairro, logradouro, numero, complemento, telefone, celular, contato, email, ";
                SQL += "dt_nasc, dt_cadastro, dt_alteracao) ";
                SQL += "VALUES ";
                SQL += "(@ativo, @id_tipo, @cliente, @fornecedor, @funcionario, @transportador, @outro, @cpf_cnpj, @nome_completo, ";
                SQL += "@fantasia, @rg_ie, @cep, @id_pais, @id_uf, @id_cidade, @bairro, @logradouro, @numero, @complemento, @telefone, @celular, @contato, @email, ";
                SQL += "@dt_nasc, @dt_cadastro, @dt_alteracao) ";

                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@ativo",         p.ativo);
                cmd.Parameters.AddWithValue("@id_tipo",       p.tipo.Id);
                cmd.Parameters.AddWithValue("@cliente",       p.cliente);
                cmd.Parameters.AddWithValue("@fornecedor",    p.fornecedor);
                cmd.Parameters.AddWithValue("@funcionario",   p.funcionario);
                cmd.Parameters.AddWithValue("@transportador", p.transportador);
                cmd.Parameters.AddWithValue("@outro",         p.outro);
                cmd.Parameters.AddWithValue("@cpf_cnpj",      p.CPF_CNPJ);
                cmd.Parameters.AddWithValue("@nome_completo", p.nomeCompleto);
                cmd.Parameters.AddWithValue("@fantasia",      p.fantasia);
                cmd.Parameters.AddWithValue("@rg_ie",         p.RG_IE);
                cmd.Parameters.AddWithValue("@cep",           p.CEP);
                cmd.Parameters.AddWithValue("@id_pais",       p.pais.Id);
                cmd.Parameters.AddWithValue("@id_uf",         p.uf.Id);
                cmd.Parameters.AddWithValue("@id_cidade",     p.cidade.Id);
                cmd.Parameters.AddWithValue("@bairro",        p.bairro);
                cmd.Parameters.AddWithValue("@logradouro",    p.logradouro);
                cmd.Parameters.AddWithValue("@numero",        p.numero);
                cmd.Parameters.AddWithValue("@complemento",   p.complemento);
                cmd.Parameters.AddWithValue("@telefone",      p.telefone);
                cmd.Parameters.AddWithValue("@celular",       p.celular);
                cmd.Parameters.AddWithValue("@contato",       p.contato);
                cmd.Parameters.AddWithValue("@email",         p.email);
                cmd.Parameters.AddWithValue("@dt_nasc",       p.dtNasc);
                cmd.Parameters.AddWithValue("@dt_cadastro",   p.dtCadastro);
                cmd.Parameters.AddWithValue("@dt_alteracao",  p.dtAlteracao);
                con.ComandoSQL(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void update(Pessoa p)
        {
            try
            {
                cmd = new NpgsqlCommand();

                SQL = "UPDATE pessoa ";
                SQL += "SET ativo = @ativo, id_tipo = @id_tipo, cliente = @cliente, fornecedor = @fornecedor, funcionario = @funcionario, transportador = @transportador, outro = @outro, ";
                SQL += "cpf_cnpj = @cpf_cnpj, nome_completo = @nome_completo, fantasia = @fantasia, rg_ie = @rg_ie, cep = @cep, id_pais = @id_pais, id_uf = @id_uf, id_cidade = @id_cidade, ";
                SQL += "bairro = @bairro, logradouro = @logradouro, numero = @numero, complemento = @complemento, telefone = @telefone, celular = @celular, contato = @contato, ";
                SQL += "email = @email,  dt_nasc = @dt_nasc, dt_alteracao = @dt_alteracao ";
                SQL += "WHERE id = @id";

                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@id",            p.id);
                cmd.Parameters.AddWithValue("@ativo",         p.ativo);
                cmd.Parameters.AddWithValue("@id_tipo",       p.tipo.Id);
                cmd.Parameters.AddWithValue("@cliente",       p.cliente);
                cmd.Parameters.AddWithValue("@fornecedor",    p.fornecedor);
                cmd.Parameters.AddWithValue("@funcionario",   p.funcionario);
                cmd.Parameters.AddWithValue("@transportador", p.transportador);
                cmd.Parameters.AddWithValue("@outro",         p.outro);
                cmd.Parameters.AddWithValue("@cpf_cnpj",      p.CPF_CNPJ);
                cmd.Parameters.AddWithValue("@nome_completo", p.nomeCompleto);
                cmd.Parameters.AddWithValue("@fantasia",      p.fantasia);
                cmd.Parameters.AddWithValue("@rg_ie",         p.RG_IE);
                cmd.Parameters.AddWithValue("@cep",           p.CEP);
                cmd.Parameters.AddWithValue("@id_pais",       p.pais.Id);
                cmd.Parameters.AddWithValue("@id_uf",         p.uf.Id);
                cmd.Parameters.AddWithValue("@id_cidade",     p.cidade.Id);
                cmd.Parameters.AddWithValue("@bairro",        p.bairro);
                cmd.Parameters.AddWithValue("@logradouro",    p.logradouro);
                cmd.Parameters.AddWithValue("@numero",        p.numero);
                cmd.Parameters.AddWithValue("@complemento",   p.complemento);
                cmd.Parameters.AddWithValue("@telefone",      p.telefone);
                cmd.Parameters.AddWithValue("@celular",       p.celular);
                cmd.Parameters.AddWithValue("@contato",       p.contato);
                cmd.Parameters.AddWithValue("@email",         p.email);
                cmd.Parameters.AddWithValue("@dt_nasc",       p.dtNasc);
                cmd.Parameters.AddWithValue("@dt_alteracao",  p.dtAlteracao);
                con.ComandoSQL(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ativarDesativar(bool valor, int id)//recebe como parametro true ou false e o id da pessoa.
        {
            try
            {
                cmd = new NpgsqlCommand();
                SQL = "UPDATE pessoa SET ativo=@ativo WHERE id = @id";
                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@ativo", valor);
                cmd.Parameters.AddWithValue("@id",    id);
                con.ComandoSQL(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region LISTAGEM E CONSULTAS DE PESSOA

        private List<Pessoa> retornaPessoas(string sql)
        {
            try
            {
                DataSet ds = con.ConsultaSQL(sql);
                List<Pessoa> ps = new List<Pessoa>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Pessoa p = new Pessoa
                    {
                        id           = int.Parse(dr["id"].ToString()),
                        CPF_CNPJ     = dr["cpf_cnpj"].ToString(),
                        nomeCompleto = dr["nome_completo"].ToString(),
                        fantasia     = dr["fantasia"].ToString(),
                        telefone     = long.Parse(dr["telefone"].ToString()),
                        celular      = long.Parse(dr["celular"].ToString()),
                        email        = dr["email"].ToString(),
                        local        = Convert.ToString(dr["cidade"].ToString()) + " - " + Convert.ToString(dr["uf"].ToString())
                    };
                    ps.Add(p);
                }
                return ps;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }    
        
        private Pessoa retornaPessoa(string sql)
        {
            try
            {
                DataSet ds = con.ConsultaSQL(sql);
                Pessoa p = null;

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    p = new Pessoa
                    {
                        id           = int.Parse(dr["id"].ToString()),
                        CPF_CNPJ     = dr["cpf_cnpj"].ToString(),
                        nomeCompleto = dr["nome_completo"].ToString(),
                        fantasia     = dr["fantasia"].ToString(),
                        telefone     = long.Parse(dr["telefone"].ToString()),
                        celular      = long.Parse(dr["celular"].ToString()),
                        email        = dr["email"].ToString(),
                        local        = Convert.ToString(dr["cidade"].ToString()) + " - " + Convert.ToString(dr["uf"].ToString())
                    };
                }
                return p;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<TipoPessoa> selectAllTipoPessoa()
        {
            try
            {
                SQL = string.Format("SELECT id, nome FROM pessoa_tipo");
                DataSet ds = con.ConsultaSQL(SQL);
                List<TipoPessoa> tp = new List<TipoPessoa>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    TipoPessoa t = new TipoPessoa
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        nome = dr["nome"].ToString()
                    };
                    tp.Add(t);
                }

                return tp;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public TipoPessoa getTipoPessoa(int id)
        {
            try
            {
                SQL = string.Format("SELECT id, nome FROM pessoa_tipo WHERE id = {0}", id);
                DataSet ds = con.ConsultaSQL(SQL);
                TipoPessoa t = null;

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    t = new TipoPessoa
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        nome = dr["nome"].ToString()
                    };
                }

                return t;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pessoa> selectPessoaPorCPF_CNPJ(string cpfCNPJ, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT p.id, p.cpf_cnpj, p.nome_completo, p.fantasia, p.telefone, p.celular, p.email, c.nome AS cidade, e.nome AS uf " +
                                    "FROM pessoa AS p, local_uf AS e, local_cidade AS c " +
                                    "WHERE p.id_uf = e.id " +
                                    "AND p.id_cidade = c.id " +
                                    "AND ativo = {1} " +
                                    "AND cpf_cnpj = '{0}' ORDER BY id", cpfCNPJ, ativo);
                
                return retornaPessoas(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Pessoa getPessoaPorCPF_CNPJ(string cpfCNPJ, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT p.id, p.cpf_cnpj, p.nome_completo, p.fantasia, p.telefone, p.celular, p.email, c.nome AS cidade, e.nome AS uf " +
                                    "FROM pessoa AS p, local_uf AS e, local_cidade AS c " +
                                    "WHERE p.id_uf = e.id " +
                                    "AND p.id_cidade = c.id " +
                                    "AND ativo = {1} " +
                                    "AND cpf_cnpj = '{0}' ORDER BY id", cpfCNPJ, ativo);
                return retornaPessoa(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pessoa> selectAllPessoas(bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT p.id, p.cpf_cnpj, p.nome_completo, p.fantasia, p.telefone, p.celular, p.email, c.nome AS cidade, e.nome AS uf " +
                                    "FROM pessoa AS p, local_uf AS e, local_cidade AS c " +
                                    "WHERE p.id_uf = e.id " +
                                    "AND p.id_cidade = c.id " +
                                    "AND ativo = {0} " +
                                    "ORDER BY id", ativo);

                return retornaPessoas(SQL);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pessoa> selectPorNome(string nome, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT p.id, p.cpf_cnpj, p.nome_completo, p.fantasia, p.telefone, p.celular, p.email, c.nome AS cidade, e.nome AS uf " +
                                    "FROM pessoa AS p, local_uf AS e, local_cidade AS c " +
                                    "WHERE p.id_uf = e.id " +
                                    "AND p.id_cidade = c.id " +
                                    "AND ativo = {1} " +
                                    "AND p.nome_completo LIKE '%{0}%' ORDER BY id ", nome, ativo);

                return retornaPessoas(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pessoa> selectPorID(int id, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT p.id, p.cpf_cnpj, p.nome_completo, p.fantasia, p.telefone, p.celular, p.email, c.nome AS cidade, e.nome AS uf " +
                                    "FROM pessoa AS p, local_uf AS e, local_cidade AS c " +
                                    "WHERE p.id_uf = e.id " +
                                    "AND p.id_cidade = c.id " +
                                    "AND ativo = {1} " +
                                    "AND p.id = '{0}' ORDER BY p.id", id, ativo);

                return retornaPessoas(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Pessoa getDetalhes(int id)//consulta na base de dados todos os dados da pessoa
        {
            try
            {
                SQL = string.Format("SELECT id, ativo, id_tipo, cliente, fornecedor, funcionario, transportador, outro, " +
                                    "cpf_cnpj, nome_completo, fantasia, rg_ie, cep, id_pais, id_uf, id_cidade, bairro, logradouro, numero, complemento, " +
                                    "telefone, celular, contato, email, dt_nasc, dt_cadastro, dt_alteracao " +
                                    "FROM pessoa " +
                                    "WHERE id = '{0}'", id);
                DataSet ds = con.ConsultaSQL(SQL);
                Pessoa p = null;

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    p = new Pessoa();
                    DAO_Endereco daoEnd = new DAO_Endereco();

                    p.id = int.Parse(dr["id"].ToString());
                    p.ativo = bool.Parse(dr["ativo"].ToString());
                    p.tipo.Id = int.Parse(dr["id_tipo"].ToString());
                    TipoPessoa tp = getTipoPessoa(p.tipo.Id);
                    p.tipo = tp;
                    //tipo
                    p.cliente = bool.Parse(dr["cliente"].ToString());
                    p.fornecedor = bool.Parse(dr["fornecedor"].ToString());
                    p.funcionario = bool.Parse(dr["funcionario"].ToString());
                    p.transportador = bool.Parse(dr["transportador"].ToString());
                    p.outro = bool.Parse(dr["outro"].ToString());

                    p.CPF_CNPJ = dr["cpf_cnpj"].ToString();
                    p.nomeCompleto = dr["nome_completo"].ToString();
                    p.fantasia = dr["fantasia"].ToString();
                    p.RG_IE = dr["rg_ie"].ToString();

                    p.CEP = dr["cep"].ToString();
                    //país
                    p.pais.Id = int.Parse(dr["id_pais"].ToString());
                    Pais pa = daoEnd.getPaisID(p.pais.Id);
                    p.pais = pa;
                    //estado
                    p.uf.Id = int.Parse(dr["id_uf"].ToString());
                    UF uf = daoEnd.getEstadoID(p.uf.Id);
                    p.uf = uf;
                    //cidade
                    p.cidade.Id = int.Parse(dr["id_cidade"].ToString());
                    Cidade cid = daoEnd.getCidadeID(p.cidade.Id);
                    p.cidade = cid;
                    //endereco
                    p.bairro = dr["bairro"].ToString();
                    p.logradouro = dr["logradouro"].ToString();
                    p.numero = Convert.ToInt32(dr["numero"].ToString());
                    p.complemento = dr["complemento"].ToString();
                    //contato
                    p.telefone = long.Parse(dr["telefone"].ToString());
                    p.celular = long.Parse(dr["celular"].ToString());
                    p.contato = dr["contato"].ToString();
                    p.email = dr["email"].ToString();

                    p.dtNasc = DateTime.Parse(dr["dt_nasc"].ToString());
                    p.dtCadastro = DateTime.Parse(dr["dt_cadastro"].ToString());
                    p.dtAlteracao = DateTime.Parse(dr["dt_alteracao"].ToString());
                }
                return p;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region LISTAGEM POR FILTRO DE TIPOS DE PESSOAS
        //filtrar pessoa pelo tipo: Cliente, Fornecedor, Transportador, etc...
        //utilizado em consultas especificas no sistema

        public List<Pessoa> selectClientePorNome(string filtro, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT p.id, p.cpf_cnpj, p.nome_completo, p.fantasia, p.telefone, p.celular, p.email, c.nome AS cidade, e.nome AS uf " +
                                    "FROM pessoa AS p, local_uf AS e, local_cidade AS c " +
                                    "WHERE p.id_uf = e.id " +
                                    "AND p.id_cidade = c.id " +
                                    "AND ativo = {1} " +
                                    "AND cliente = true " +
                                    "AND nome_completo LIKE '%{0}%' ORDER BY id", filtro, ativo);

                return retornaPessoas(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pessoa> getClientePorID(int ID, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT p.id, p.cpf_cnpj, p.nome_completo, p.fantasia, p.telefone, p.celular, p.email, c.nome AS cidade, e.nome AS uf " +
                                    "FROM pessoa AS p, local_uf AS e, local_cidade AS c " +
                                    "WHERE p.id_uf = e.id " +
                                    "AND p.id_cidade = c.id " +
                                    "AND ativo = {1} " +
                                    "AND cliente = true " +
                                    "AND p.id = {0} ORDER BY id", ID, ativo);

                return retornaPessoas(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<Pessoa> selectFornecedorPorNome(string filtro, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT p.id, p.cpf_cnpj, p.nome_completo, p.fantasia, p.telefone, p.celular, p.email, c.nome AS cidade, e.nome AS uf " +
                                        "FROM pessoa AS p, local_uf AS e, local_cidade AS c " +
                                    "WHERE p.id_uf = e.id " +
                                        "AND p.id_cidade = c.id " +
                                        "AND ativo = {1} " +
                                        "AND fornecedor = true " +
                                        "AND nome_completo LIKE '%{0}%' ORDER BY id", filtro, ativo);
                
                return retornaPessoas(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pessoa> getFornecedorPorID(int id, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT p.id, p.cpf_cnpj, p.nome_completo, p.fantasia, p.telefone, p.celular, p.email, c.nome AS cidade, e.nome AS uf " +
                                    "FROM pessoa AS p, local_uf AS e, local_cidade AS c " +
                                    "WHERE p.id_uf = e.id " +
                                    "AND p.id_cidade = c.id " +
                                    "AND ativo ={1} " +
                                    "AND fornecedor = true " +
                                    "AND p.id = {0} ORDER BY id", id, ativo);

                return retornaPessoas(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<Pessoa> selectTransportadorPorNome(string filtro, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT p.id, p.cpf_cnpj, p.nome_completo, p.fantasia, p.telefone, p.celular, p.email, c.nome AS cidade, e.nome AS uf " +
                                    "FROM pessoa AS p, local_uf AS e, local_cidade AS c " +
                                    "WHERE p.id_uf = e.id " +
                                    "AND p.id_cidade = c.id " +
                                    "AND ativo = {1} " +
                                    "AND transportador = true " +
                                    "AND nome_completo LIKE '%{0}%' ORDER BY id", filtro, ativo);

                return retornaPessoas(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pessoa> getTransportadorPorID(int id, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT p.id, p.cpf_cnpj, p.nome_completo, p.fantasia, p.telefone, p.celular, p.email, c.nome AS cidade, e.nome AS uf " +
                                    "FROM pessoa AS p, local_uf AS e, local_cidade AS c " +
                                    "WHERE p.id_uf = e.id " +
                                    "AND p.id_cidade = c.id " +
                                    "AND ativo = {1} " +
                                    "AND transportador = true " +
                                    "AND p.id = {0} ORDER BY id", id, ativo);

                return retornaPessoas(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<Pessoa> selectFuncionarioPorNome(string filtro, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT p.id, p.cpf_cnpj, p.nome_completo, p.fantasia, p.telefone, p.celular, p.email, c.nome AS cidade, e.nome AS uf " +
                                    "FROM pessoa AS p, local_uf AS e, local_cidade AS c " +
                                    "WHERE p.id_uf = e.id " +
                                    "AND p.id_cidade = c.id " +
                                    "AND ativo = {1} " +
                                    "AND funcionario = true " +
                                    "AND nome_completo LIKE '%{0}%' ORDER BY id", filtro, ativo);

                return retornaPessoas(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pessoa> getFuncionarioPorID(int id, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT p.id, p.cpf_cnpj, p.nome_completo, p.fantasia, p.telefone, p.celular, p.email, c.nome AS cidade, e.nome AS uf " +
                                    "FROM pessoa AS p, local_uf AS e, local_cidade AS c " +
                                    "WHERE p.id_uf = e.id " +
                                    "AND p.id_cidade = c.id " +
                                    "AND ativo = {1} " +
                                    "AND funcionario = true " +
                                    "AND p.id = {0} ORDER BY id", id, ativo);

                return retornaPessoas(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<Pessoa> selectOutrosPorNome(string filtro, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT p.id, p.cpf_cnpj, p.nome_completo, p,fantasia, p.telefone, p.celular, p.email, c.nome AS cidade, e.nome AS uf " +
                                    "FROM pessoa AS p, local_uf AS e, local_cidade AS c " +
                                    "WHERE p.id_uf = e.id " +
                                    "AND p.id_cidade = c.id " +
                                    "AND ativo ={1} " +
                                    "AND outros = true " +
                                    "AND nome_completo LIKE '%{0}%' ORDER BY id", filtro, ativo);

                return retornaPessoas(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pessoa> getOutrosPorID(int id, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT p.id, p.cpf_cnpj, p.nome_completo, p,fantasia, p.telefone, p.celular, p.email, c.nome AS cidade, e.nome AS uf " +
                                    "FROM pessoa AS p, local_uf AS e, local_cidade AS c " +
                                    "WHERE p.id_uf = e.id " +
                                    "AND p.id_cidade = c.id " +
                                    "AND ativo = {1} " +
                                    "AND outros = true " +
                                    "AND p.id = {0} ORDER BY id", id, ativo);

                return retornaPessoas(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

    }
}
