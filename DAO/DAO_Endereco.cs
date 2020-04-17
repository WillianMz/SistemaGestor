using Modelo.Localizacao;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAO
{
    public class DAO_Endereco
    {
        Conexao con = Conexao.GetInstancia();
        string SQL;

        #region PAÍS
        public List<Pais> getPaises()
        {
            try
            {
                SQL = "SELECT id, nome FROM local_pais ORDER BY nome";
                DataSet ds = con.ConsultaSQL(SQL);
                List<Pais> ps = new List<Pais>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Pais p = new Pais
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        nome = dr["nome"].ToString()
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

        public Pais getPaisID(int id)
        {
            try
            {
                SQL = string.Format("SELECT id, nome FROM local_pais WHERE id = {0}", id);
                DataSet ds = con.ConsultaSQL(SQL);
                Pais p = null;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    p = new Pais
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        nome = dr["nome"].ToString()
                    };
                }
                return p;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region ESTADOS

        public List<UF> getEstados(Pais pais)
        {
            try
            {
                SQL = string.Format("SELECT id, nome FROM local_uf WHERE id_pais = '{0}'", pais.Id);
                DataSet ds = con.ConsultaSQL(SQL);
                List<UF> uf = new List<UF>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    UF u = new UF
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        nome = dr["nome"].ToString()
                    };
                    uf.Add(u);
                }
                return uf;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public UF getEstadoID(int id)
        {
            try
            {
                SQL = string.Format("SELECT id, nome FROM local_uf WHERE id = {0}", id);
                DataSet ds = con.ConsultaSQL(SQL);
                UF p = null;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    p = new UF
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        nome = dr["nome"].ToString()
                    };
                }
                return p;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region CIDADES

        public List<Cidade> getCidades(UF uf)
        {
            try
            {
                SQL = string.Format("SELECT id, nome FROM local_cidade WHERE id_uf = '{0}'", uf.Id);
                DataSet ds = con.ConsultaSQL(SQL);
                List<Cidade> cd = new List<Cidade>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Cidade c = new Cidade
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        nome = dr["nome"].ToString()
                    };
                    cd.Add(c);
                }
                return cd;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Cidade getCidadeID(int id)
        {
            try
            {
                SQL = string.Format("SELECT id, nome FROM local_cidade WHERE id = {0}", id);
                DataSet ds = con.ConsultaSQL(SQL);
                Cidade c = null;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    c = new Cidade
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        nome = dr["nome"].ToString()
                    };
                }
                return c;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
