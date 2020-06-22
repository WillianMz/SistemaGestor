using Modelo.User;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAO
{
    public class DAO_Usuario
    {
        Conexao con = Conexao.GetInstancia();
        string SQL;

        private List<Usuario> retornaUsuarios(string sql)
        {
            try
            {
                DataSet ds = con.ConsultaSQL(SQL);
                List<Usuario> user = new List<Usuario>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Usuario u = new Usuario
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        login = dr["login"].ToString(),
                        nome = dr["nome"].ToString(),
                        nivel = (Nivel)int.Parse(dr["nivel"].ToString()),
                        ativo = bool.Parse(dr["ativo"].ToString())
                    };
                    user.Add(u);
                }

                return user;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private Usuario retornaUsuario(string sql)
        {
            try
            {
                DataSet ds = con.ConsultaSQL(SQL);
                Usuario user = null;

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    user = new Usuario
                    {
                        Id = int.Parse(dr["id"].ToString()),
                        login = dr["login"].ToString(),
                        nome = dr["nome"].ToString(),
                        nivel = (Nivel)int.Parse(dr["nivel"].ToString()),
                        ativo = bool.Parse(dr["ativo"].ToString())
                    };;
                }
                return user;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Usuario getDetalhes (string login, string senha)
        {
            try
            {
                SQL = string.Format("SELECT id, login, nome, nivel, ativo FROM user_usuario WHERE login = '{0}' AND senha = '{1}'", login, senha);
                return retornaUsuario(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Usuario getUsuario_ID(int id, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT id, login, nome, nivel, ativo FROM user_usuario WHERE id = {0} AND ativo = '{1}'", id, ativo);
                return retornaUsuario(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Usuario> getUsuario(string login, string senha, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT id, login, nome, nivel, ativo FROM user_usuario WHERE login = '{0}' AND senha = '{1}' AND ativo = {2}", login, senha, ativo);
                return retornaUsuarios(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Usuario> getAll(bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT id, login, nome, nivel, ativo FROM user_usuario WHERE ativo = '{0}'", ativo);
                return retornaUsuarios(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
