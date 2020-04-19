using Modelo.Tributacao;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Tributacao
    {
        Conexao con = Conexao.GetInstancia();
       // NpgsqlCommand cmd;
        DataSet ds;
        string SQL;

        public List<Origem> selectOrigem()
        {
            try
            {
                SQL = "SELECT id, nome FROM fiscal_origem ORDER BY id";
                ds = con.ConsultaSQL(SQL);
                List<Origem> ls = new List<Origem>();

                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    Origem o = new Origem();
                    o.Id = int.Parse(dr["id"].ToString());
                    o.nome = dr["nome"].ToString();
                    ls.Add(o);
                }
                return ls;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Origem getOrigemID(int id)
        {
            try
            {
                SQL = string.Format("SELECT id, nome FROM fiscal_origem WHERE id = {0} ", id);
                ds = con.ConsultaSQL(SQL);
                Origem origem = null;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    origem = new Origem();
                    origem.Id = int.Parse(dr["id"].ToString());
                    origem.nome = dr["nome"].ToString();                   
                }
                return origem;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<CST> selectCST()
        {
            try
            {
                SQL = "SELECT id, nome FROM fiscal_cst ORDER BY id";
                ds = con.ConsultaSQL(SQL);
                List<CST> ls = new List<CST>();

                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    CST c = new CST();
                    c.Id = int.Parse(dr["id"].ToString());
                    c.nome = dr["nome"].ToString();
                    ls.Add(c);
                }
                return ls;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public CST getCST_ID(int id)
        {
            try
            {
                SQL = string.Format("SELECT id, nome FROM fiscal_cst WHERE id = {0} ", id);
                ds = con.ConsultaSQL(SQL);
                CST obj = null;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    obj = new CST();
                    obj.Id = int.Parse(dr["id"].ToString());
                    obj.nome = dr["nome"].ToString();
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<CFOP> selectCFOP()
        {
            try
            {
                SQL = "SELECT * FROM fical_cfop ORDER BY id";
                ds = con.ConsultaSQL(SQL);
                List<CFOP> ls = new List<CFOP>();

                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    CFOP cfop = new CFOP();
                    cfop.Id = int.Parse(dr["id"].ToString());
                    cfop.nome = dr["nome"].ToString();
                    ls.Add(cfop);
                }
                return ls;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public CFOP getCFOP_ID(int id)
        {
            try
            {
                SQL = string.Format("SELECT id, nome FROM fiscal_cfop WHERE id = {0} ", id);
                ds = con.ConsultaSQL(SQL);
                CFOP obj = null;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    obj = new CFOP();
                    obj.Id = int.Parse(dr["id"].ToString());
                    obj.nome = dr["nome"].ToString();
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<NCM> selectNCM()
        {
            try
            {
                SQL = "SELECT * FROM fical_ncm ORDER BY id";
                ds = con.ConsultaSQL(SQL);
                List<NCM> ls = new List<NCM>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    NCM ncm = new NCM();
                    ncm.Id = int.Parse(dr["id"].ToString());
                    ncm.nome = dr["nome"].ToString();
                    ls.Add(ncm);
                }
                return ls;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public NCM getNCM_ID(int id)
        {
            try
            {
                SQL = string.Format("SELECT id, nome FROM fiscal_cfop WHERE id = {0} ", id);
                ds = con.ConsultaSQL(SQL);
                NCM obj = null;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    obj = new NCM();
                    obj.Id = int.Parse(dr["id"].ToString());
                    obj.nome = dr["nome"].ToString();
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
