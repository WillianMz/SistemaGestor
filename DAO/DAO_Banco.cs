using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Modelo.Financeiro;
using Modelo;

namespace DAO
{
    public class DAO_Banco
    {
        Conexao con = Conexao.GetInstancia();
        NpgsqlCommand cmd;
        string SQL;

        public void insert(Banco b)
        {
            try
            {
                cmd = new NpgsqlCommand();

                SQL = "INSERT INTO banco ";
                SQL += "(codbanco, nome, ativo, agencia, conta ";
                SQL += "VALUES ";
                SQL += "(@codigo, @nome, @ativo, @agencia, @conta";

                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@codbanco", b.codigoBanco);
                cmd.Parameters.AddWithValue("@nome", b.nome);
                cmd.Parameters.AddWithValue("@ativo", b.ativo);
                cmd.Parameters.AddWithValue("@agencia", b.agencia);
                cmd.Parameters.AddWithValue("@conta", b.conta);
                con.ComandoSQL(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



    }

    
}
