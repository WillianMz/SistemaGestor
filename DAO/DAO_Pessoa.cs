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
                cmd.Parameters.AddWithValue("@ativo",         p.Ativo);
                cmd.Parameters.AddWithValue("@id_tipo",       p.Tipo.Id);
                cmd.Parameters.AddWithValue("@cliente",       p.Cliente);
                cmd.Parameters.AddWithValue("@fornecedor",    p.Fornecedor);
                cmd.Parameters.AddWithValue("@funcionario",   p.Funcionario);
                cmd.Parameters.AddWithValue("@transportador", p.Transportador);
                cmd.Parameters.AddWithValue("@outro",         p.Outro);
                cmd.Parameters.AddWithValue("@cpf_cnpj",      p.CPF_CNPJ);
                cmd.Parameters.AddWithValue("@nome_completo", p.NomeCompleto);
                cmd.Parameters.AddWithValue("@fantasia",      p.Fantasia);
                cmd.Parameters.AddWithValue("@rg_ie",         p.RG_IE);
                cmd.Parameters.AddWithValue("@cep",           p.CEP);
                cmd.Parameters.AddWithValue("@id_pais",       p.Pais.Id);
                cmd.Parameters.AddWithValue("@id_uf",         p.UF.Id);
                cmd.Parameters.AddWithValue("@id_cidade",     p.Cidade.Id);
                cmd.Parameters.AddWithValue("@bairro",        p.Bairro);
                cmd.Parameters.AddWithValue("@logradouro",    p.Logradouro);
                cmd.Parameters.AddWithValue("@numero",        p.Numero);
                cmd.Parameters.AddWithValue("@complemento",   p.Complemento);
                cmd.Parameters.AddWithValue("@telefone",      p.Telefone);
                cmd.Parameters.AddWithValue("@celular",       p.Celular);
                cmd.Parameters.AddWithValue("@contato",       p.Contato);
                cmd.Parameters.AddWithValue("@email",         p.Email);
                cmd.Parameters.AddWithValue("@dt_nasc",       p.DtNasc);
                cmd.Parameters.AddWithValue("@dt_cadastro",   p.DtCadastro);
                cmd.Parameters.AddWithValue("@dt_alteracao",  p.DtAlteracao);
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
                cmd.Parameters.AddWithValue("@id",            p.Id);
                cmd.Parameters.AddWithValue("@ativo",         p.Ativo);
                cmd.Parameters.AddWithValue("@id_tipo",       p.Tipo.Id);
                cmd.Parameters.AddWithValue("@cliente",       p.Cliente);
                cmd.Parameters.AddWithValue("@fornecedor",    p.Fornecedor);
                cmd.Parameters.AddWithValue("@funcionario",   p.Funcionario);
                cmd.Parameters.AddWithValue("@transportador", p.Transportador);
                cmd.Parameters.AddWithValue("@outro",         p.Outro);
                cmd.Parameters.AddWithValue("@cpf_cnpj",      p.CPF_CNPJ);
                cmd.Parameters.AddWithValue("@nome_completo", p.NomeCompleto);
                cmd.Parameters.AddWithValue("@fantasia",      p.Fantasia);
                cmd.Parameters.AddWithValue("@rg_ie",         p.RG_IE);
                cmd.Parameters.AddWithValue("@cep",           p.CEP);
                cmd.Parameters.AddWithValue("@id_pais",       p.Pais.Id);
                cmd.Parameters.AddWithValue("@id_uf",         p.UF.Id);
                cmd.Parameters.AddWithValue("@id_cidade",     p.Cidade.Id);
                cmd.Parameters.AddWithValue("@bairro",        p.Bairro);
                cmd.Parameters.AddWithValue("@logradouro",    p.Logradouro);
                cmd.Parameters.AddWithValue("@numero",        p.Numero);
                cmd.Parameters.AddWithValue("@complemento",   p.Complemento);
                cmd.Parameters.AddWithValue("@telefone",      p.Telefone);
                cmd.Parameters.AddWithValue("@celular",       p.Celular);
                cmd.Parameters.AddWithValue("@contato",       p.Contato);
                cmd.Parameters.AddWithValue("@email",         p.Email);
                cmd.Parameters.AddWithValue("@dt_nasc",       p.DtNasc);
                cmd.Parameters.AddWithValue("@dt_alteracao",  p.DtAlteracao);
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
                        Id           = int.Parse(dr["id"].ToString()),
                        CPF_CNPJ     = dr["cpf_cnpj"].ToString(),
                        NomeCompleto = dr["nome_completo"].ToString(),
                        Fantasia     = dr["fantasia"].ToString(),
                        Telefone     = long.Parse(dr["telefone"].ToString()),
                        Celular      = long.Parse(dr["celular"].ToString()),
                        Email        = dr["email"].ToString(),
                        Local        = Convert.ToString(dr["cidade"].ToString()) + " - " + Convert.ToString(dr["uf"].ToString())
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
                        Id           = int.Parse(dr["id"].ToString()),
                        CPF_CNPJ     = dr["cpf_cnpj"].ToString(),
                        NomeCompleto = dr["nome_completo"].ToString(),
                        Fantasia     = dr["fantasia"].ToString(),
                        Telefone     = long.Parse(dr["telefone"].ToString()),
                        Celular      = long.Parse(dr["celular"].ToString()),
                        Email        = dr["email"].ToString(),
                        Local        = Convert.ToString(dr["cidade"].ToString()) + " - " + Convert.ToString(dr["uf"].ToString())
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
                        Nome = dr["nome"].ToString()
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
                        Nome = dr["nome"].ToString()
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

                    p.Id = int.Parse(dr["id"].ToString());
                    p.Ativo = bool.Parse(dr["ativo"].ToString());
                    p.Tipo.Id = int.Parse(dr["id_tipo"].ToString());
                    TipoPessoa tp = getTipoPessoa(p.Tipo.Id);
                    p.Tipo = tp;
                    //tipo
                    p.Cliente = bool.Parse(dr["cliente"].ToString());
                    p.Fornecedor = bool.Parse(dr["fornecedor"].ToString());
                    p.Funcionario = bool.Parse(dr["funcionario"].ToString());
                    p.Transportador = bool.Parse(dr["transportador"].ToString());
                    p.Outro = bool.Parse(dr["outro"].ToString());

                    p.CPF_CNPJ = dr["cpf_cnpj"].ToString();
                    p.NomeCompleto = dr["nome_completo"].ToString();
                    p.Fantasia = dr["fantasia"].ToString();
                    p.RG_IE = dr["rg_ie"].ToString();

                    p.CEP = dr["cep"].ToString();
                    //país
                    p.Pais.Id = int.Parse(dr["id_pais"].ToString());
                    Pais pa = daoEnd.getPaisID(p.Pais.Id);
                    p.Pais = pa;
                    //estado
                    p.UF.Id = int.Parse(dr["id_uf"].ToString());
                    UF uf = daoEnd.getEstadoID(p.UF.Id);
                    p.UF = uf;
                    //cidade
                    p.Cidade.Id = int.Parse(dr["id_cidade"].ToString());
                    Cidade cid = daoEnd.getCidadeID(p.Cidade.Id);
                    p.Cidade = cid;
                    //endereco
                    p.Bairro = dr["bairro"].ToString();
                    p.Logradouro = dr["logradouro"].ToString();
                    p.Numero = Convert.ToInt32(dr["numero"].ToString());
                    p.Complemento = dr["complemento"].ToString();
                    //contato
                    p.Telefone = long.Parse(dr["telefone"].ToString());
                    p.Celular = long.Parse(dr["celular"].ToString());
                    p.Contato = dr["contato"].ToString();
                    p.Email = dr["email"].ToString();

                    p.DtNasc = DateTime.Parse(dr["dt_nasc"].ToString());
                    p.DtCadastro = DateTime.Parse(dr["dt_cadastro"].ToString());
                    p.DtAlteracao = DateTime.Parse(dr["dt_alteracao"].ToString());
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
