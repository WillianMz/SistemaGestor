using Npgsql;
using System;
using System.Data;
using static Modelo.Config.Parametro;

namespace DAO
{
    public class Conexao
    {
        NpgsqlConnection conexao;
        NpgsqlTransaction Trans;
        private static NpgsqlConnection Conn;
        private static Conexao Instancia;

        private static readonly string URL = ("Server=" + SQL.servidor + ";Port=" + SQL.porta + ";Database=" + SQL.banco + ";User Id=" + SQL.userBD + ";Password=" + SQL.senhaBD + ";");

        private Conexao()
        {
            Conn = new NpgsqlConnection(URL);
        }

        public static Conexao GetInstancia()
        {
            if (Instancia == null)
                Instancia = new Conexao();

            return Instancia;
        }

        public void TestarConexao()
        {
            try
            {
                Conn.Open();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Conn.Close();
            }

        }

        public void Conectar()
        {
            try
            {
                conexao = new NpgsqlConnection(URL);
                conexao.Open();
            }
            catch (NpgsqlException ex)
            {
                throw new Exception("Motivo do erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Motivo do erro: " + ex.Message);
            }
        }

        public void Desconectar()
        {
            try
            {
                conexao.Close();
                conexao.Dispose();
            }
            catch (NpgsqlException ex)
            {
                throw new Exception("Motivo do erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Motivo do erro: " + ex.Message);
            }
        }

        public int ComandoID(NpgsqlCommand cmd)
        {
            try
            {
                Conectar();
                Trans = conexao.BeginTransaction();
                cmd.Transaction = Trans;
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;
                Trans.Commit();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (NpgsqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                Trans.Rollback();
                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public void ComandoSQL(NpgsqlCommand cmd)
        {
            try
            {
                Conectar();
                Trans = conexao.BeginTransaction();
                cmd.Transaction = Trans;
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                Trans.Commit();
            }
            catch (NpgsqlException ex)
            {
                Trans.Rollback();
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                //Trans.Rollback();
                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public DataSet ConsultaSQL(string qry)
        {
            try
            {
                Conectar();
                NpgsqlCommand cmd = new NpgsqlCommand(qry, Conn);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ds.Clear();
                da.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

    }
}
