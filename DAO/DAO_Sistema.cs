using Modelo;
using Modelo.Localizacao;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAO
{
    public class DAO_Sistema
    {
        Conexao con = Conexao.GetInstancia();
        NpgsqlCommand cmd;
        string SQL;

        #region EMPRESA

        public void insertEmpresa(Empresa e)
        {
            try
            {
                cmd = new NpgsqlCommand();

                SQL = "INSERT INTO empresa ";
                SQL += "(ativo, cnpj, razao_social, fantasia, matriz, filial, ie, im, id_crt, id_segmento, ";
                SQL += "cep, id_pais, id_uf, id_cidade, bairro, logradouro, numero, complemento, ";
                SQL += "telefone, celular, contato, email, site, dt_cadastro, dt_alteracao) ";
                SQL += "VALUES ";
                SQL += "(@ativo, @cnpj, @razao_social, @fantasia, @matriz, @filial, @ie, @im, @id_crt, @id_segmento, ";
                SQL += "@cep, @id_pais, @id_uf, @id_cidade, @bairro, @logradouro, @numero, @complemento, ";
                SQL += "@telefone, @celular, @contato, @email, @site, @dt_cadastro, @dt_alteracao) ";

                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("ativo",        e.ativo);
                cmd.Parameters.AddWithValue("cnpj",         e.cnpj);
                cmd.Parameters.AddWithValue("razao_social", e.razaoSocial);
                cmd.Parameters.AddWithValue("fantasia",     e.fantasia);
                cmd.Parameters.AddWithValue("matriz",       e.matriz);
                cmd.Parameters.AddWithValue("filial",       e.filial);
                cmd.Parameters.AddWithValue("ie",           e.ie);
                cmd.Parameters.AddWithValue("im",           e.im);
                cmd.Parameters.AddWithValue("id_crt",       e.crt);
                cmd.Parameters.AddWithValue("id_segmento",  e.segmento);
                cmd.Parameters.AddWithValue("cep",          e.cep);
                cmd.Parameters.AddWithValue("id_pais",      e.pais.Id);
                cmd.Parameters.AddWithValue("id_uf",        e.uf.Id);
                cmd.Parameters.AddWithValue("id_cidade",    e.cidade.Id);
                cmd.Parameters.AddWithValue("bairro",       e.bairro);
                cmd.Parameters.AddWithValue("logradouro",   e.logradouro);
                cmd.Parameters.AddWithValue("numero",       e.numero);
                cmd.Parameters.AddWithValue("complemento",  e.complemento);
                cmd.Parameters.AddWithValue("telefone",     e.telefone);
                cmd.Parameters.AddWithValue("celular",      e.celular);
                cmd.Parameters.AddWithValue("contato",      e.contato);
                cmd.Parameters.AddWithValue("email",        e.email);
                cmd.Parameters.AddWithValue("site",         e.site);
                cmd.Parameters.AddWithValue("dt_cadastro",  e.dtCadastro);
                cmd.Parameters.AddWithValue("dt_alteracao", e.dtAlteracao);
                con.ComandoSQL(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void updateEmpresa(Empresa e)
        {
            try
            {
                cmd = new NpgsqlCommand();

                SQL = "UPDATE empresa ";
                SQL += "SET ativo = @ativo, cnpj = @cnpj, razao_social = @razao_social, fantasia = @fantasia, matriz = @matriz, filial = @filial, ";
                SQL += "ie = @ie, im = @im, id_crt = @id_crt, id_segmento = @id_segmento, ";
                SQL += "cep = @cep, id_pais = @id_pais, id_uf = @id_uf, id_cidade = @id_cidade, bairro = @bairro, logradouro = @logradouro, numero = @numero, complemento = @complemento, "; 
                SQL += "telefone = @telefone, celular = @celular, contato = @contato, email = @email, site = @site, dt_cadastro = @dt_cadastro, dt_alteracao  =@dt_alteracao ";
                SQL += "WHERE id = @id";

                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("id",           e.Id);
                cmd.Parameters.AddWithValue("ativo",        e.ativo);
                cmd.Parameters.AddWithValue("cnpj",         e.cnpj);
                cmd.Parameters.AddWithValue("razao_social", e.razaoSocial);
                cmd.Parameters.AddWithValue("fantasia",     e.fantasia);
                cmd.Parameters.AddWithValue("matriz",       e.matriz);
                cmd.Parameters.AddWithValue("filial",       e.filial);
                cmd.Parameters.AddWithValue("ie",           e.ie);
                cmd.Parameters.AddWithValue("im",           e.im);
                cmd.Parameters.AddWithValue("id_crt",       e.crt);
                cmd.Parameters.AddWithValue("id_segmento",  e.segmento);
                cmd.Parameters.AddWithValue("cep",          e.cep);
                cmd.Parameters.AddWithValue("id_pais",      e.pais.Id);
                cmd.Parameters.AddWithValue("id_uf",        e.uf.Id);
                cmd.Parameters.AddWithValue("id_cidade",    e.cidade.Id);
                cmd.Parameters.AddWithValue("bairro",       e.bairro);
                cmd.Parameters.AddWithValue("logradouro",   e.logradouro);
                cmd.Parameters.AddWithValue("numero",       e.numero);
                cmd.Parameters.AddWithValue("complemento",  e.complemento);
                cmd.Parameters.AddWithValue("telefone",     e.telefone);
                cmd.Parameters.AddWithValue("celular",      e.celular);
                cmd.Parameters.AddWithValue("contato",      e.contato);
                cmd.Parameters.AddWithValue("email",        e.email);
                cmd.Parameters.AddWithValue("site",         e.site);
                cmd.Parameters.AddWithValue("dt_cadastro",  e.dtCadastro);
                cmd.Parameters.AddWithValue("dt_alteracao", e.dtAlteracao);
                con.ComandoSQL(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Empresa getDetalhes(int id)
        {
            try
            {
                SQL = string.Format("SELECT id, ativo, cnpj, razao_social, fantasia, matriz, filial, ie, im, id_crt, id_segmento, " +
                                    "cep, id_pais, id_uf, id_cidade, bairro, logradouro, numero, complemento, " +
                                    "telefone, celular, contato, email, site, dt_cadastro, dt_alteracao " +
                                    "FROM empresa " +
                                    "WHERE id = '{0}'", id);
                DataSet ds = con.ConsultaSQL(SQL);
                Empresa e = null;

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    e = new Empresa();
                    DAO_Endereco daoEnd = new DAO_Endereco();

                    e.Id          = int.Parse(dr["id"].ToString());
                    e.ativo       = bool.Parse(dr["ativo"].ToString());
                    e.cnpj        = dr["cnpj"].ToString();
                    e.razaoSocial = dr["razao_social"].ToString();
                    e.fantasia    = dr["fantasia"].ToString();
                    e.matriz      = bool.Parse(dr["matriz"].ToString());
                    e.filial      = bool.Parse(dr["filial"].ToString());
                    e.ie          = dr["ie"].ToString();
                    e.im          = dr["im"].ToString();
                    e.crt         = int.Parse(dr["id_crt"].ToString());
                    e.segmento    = int.Parse(dr["id_segmento"].ToString());
                    e.cep         = dr["cep"].ToString();

                    e.pais.Id = int.Parse(dr["id_pais"].ToString());
                    Pais pa   = daoEnd.getPaisID(e.pais.Id);
                    e.pais    = pa;

                    e.uf.Id = int.Parse(dr["id_uf"].ToString());
                    UF uf   = daoEnd.getEstadoID(e.uf.Id);
                    e.uf    = uf;

                    e.cidade.Id = int.Parse(dr["id_cidade"].ToString());
                    Cidade cid  = daoEnd.getCidadeID(e.cidade.Id);
                    e.cidade    = cid;

                    e.bairro      = dr["bairro"].ToString();
                    e.logradouro  = dr["logradouro"].ToString();
                    e.numero      = Convert.ToInt32(dr["numero"].ToString());
                    e.complemento = dr["complemento"].ToString();                    
                    e.telefone    = long.Parse(dr["telefone"].ToString());
                    e.celular     = long.Parse(dr["celular"].ToString());
                    e.contato     = dr["contato"].ToString();
                    e.email       = dr["email"].ToString();
                    e.site        = dr["site"].ToString();
                    e.dtCadastro  = DateTime.Parse(dr["dtcadastro"].ToString());
                    e.dtAlteracao = DateTime.Parse(dr["dtalteracao"].ToString());

                }

                return e;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Empresa> getAllEmpresa(bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT e.id, e.ativo, e.cnpj, e.razao_social, e.fantasia, e.telefone, e.contato, e.email, cidade.nome AS cidade, uf.nome AS uf " +
                                        "FROM empresa AS e, local_uf AS uf, local_cidade AS cidade " +
                                    "WHERE e.ativo = '{0}' " +
                                        "AND e.id_cidade = cidade.id " +
                                        "AND e.id_uf = uf.id ORDER BY fantasia ", ativo);
                DataSet ds = con.ConsultaSQL(SQL);
                List<Empresa> empresas = new List<Empresa>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Empresa e = new Empresa
                    {
                        Id          = int.Parse(dr["id"].ToString()),
                        ativo       = bool.Parse(dr["ativo"].ToString()),
                        cnpj        = dr["cnpj"].ToString(),
                        razaoSocial = dr["razao_social"].ToString(),
                        fantasia    = dr["fantasia"].ToString(),
                        telefone    = long.Parse(dr["telefone"].ToString()),
                        contato     = dr["contato"].ToString(),
                        email       = dr["email"].ToString(),
                        local       = Convert.ToString(dr["cidade"].ToString()) + " - " + Convert.ToString(dr["uf"].ToString())
                    };
                    empresas.Add(e);
                }
                return empresas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Empresa> selectEmpresa_ID(int id, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT e.id, e.cnpj, e.razao_social, e.fantasia, e.telefone, e.contato, e.email, cidade.nome AS cidade, uf.nome AS uf " +
                                        "FROM empresa AS e, local_uf AS uf, local_cidade AS cidade "+
                                    "WHERE e.id = {0} " +
                                        "AND e.ativo = '{1}' " +
                                        "AND e.id_cidade = cidade.id " +
                                        "AND e.id_uf = uf.id ORDER BY fantasia ", id, ativo);
                DataSet ds = con.ConsultaSQL(SQL);
                List<Empresa> empresas = new List<Empresa>();

                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    Empresa e = new Empresa
                    {
                        Id          = int.Parse(dr["id"].ToString()),
                        cnpj        = dr["cnpj"].ToString(),
                        razaoSocial = dr["razao_social"].ToString(),
                        fantasia    = dr["fantasia"].ToString(),
                        telefone    = long.Parse(dr["telefone"].ToString()),
                        contato     = dr["contato"].ToString(),
                        email       = dr["email"].ToString(),
                        local       = Convert.ToString(dr["cidade"].ToString()) + " - " + Convert.ToString(dr["uf"].ToString())
                    };
                    empresas.Add(e);
                }
                return empresas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Empresa selectEmpresa_CNPJ(string cnpj, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT e.id, e.cnpj, e.razao_social, e.fantasia, e.telefone, e.contato, e.email, cidade.nome AS cidade, uf.nome AS uf " +
                                        "FROM empresa AS e, local_uf AS uf, local_cidade AS cidade " +
                                    "WHERE e.cnpj = '{0}' " +
                                        "AND e.ativo = {1} " +
                                        "AND e.id_cidade = cidade.id " +
                                        "AND e.id_uf = uf.id ORDER BY e.fantasia ", cnpj, ativo);
                DataSet ds = con.ConsultaSQL(SQL);
                Empresa e = null;

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    e = new Empresa();
                    e.Id          = int.Parse(dr["id"].ToString());
                    e.cnpj        = dr["cnpj"].ToString();
                    e.razaoSocial = dr["razao_social"].ToString();
                    e.fantasia    = dr["fantasia"].ToString();
                    e.telefone    = long.Parse(dr["telefone"].ToString());//erro
                    e.contato     = dr["contato"].ToString();
                    e.email       = dr["email"].ToString();
                    e.local       = Convert.ToString(dr["cidade"].ToString()) + " - " + Convert.ToString(dr["uf"].ToString());
                }
                return e;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //teste
        private Empresa dadosEmpresa(string SQL)
        {
            DataSet ds = con.ConsultaSQL(SQL);
            Empresa e = null;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                e = new Empresa
                {
                    Id          = int.Parse(dr["id"].ToString()),
                    cnpj        = dr["cnpj"].ToString(),
                    razaoSocial = dr["razao_social"].ToString(),
                    fantasia    = dr["fantasia"].ToString(),
                    telefone    = long.Parse(dr["telefone"].ToString()),
                    contato     = dr["contato"].ToString(),
                    email       = dr["email"].ToString(),
                    local       = Convert.ToString(dr["cidade"].ToString()) + " - " + Convert.ToString(dr["uf"].ToString())
                };
            }
            return e;
        }

        #endregion
    }
}
