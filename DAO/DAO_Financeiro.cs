using Modelo.Financeiro;
using Npgsql;
using System;
using System.Data;
using System.Collections.Generic;

namespace DAO
{
    public class DAO_Financeiro
    {
        Conexao con = Conexao.GetInstancia();
        NpgsqlCommand cmd;
        string SQL;


        #region PAGAR

        public void insertPagar(Pagar p)
        {
            try
            {
                cmd = new NpgsqlCommand();

                SQL = "INSERT INTO fin_pagar ";
                SQL += "(id_empresa, id_pessoa, descricao, documento, id_plano, dt_emissao, dias, dt_venc, valor, desconto, acrescimo, id_forma_pgto, id_conta, ";
                SQL += "dt_pgto, valor_pago, dt_baixa, id_situacao, observacao, id_banco, nosso_numero, cnab) ";
                SQL += "VALUES ";
                SQL += "(@id_empresa, @id_pessoa, @descricao, @documento, @id_plano, @dt_emissao, @dias, @dt_venc, ";
                SQL += "@valor, @desconto, @acrescimo, @id_forma_pgto, @id_conta, ";
                SQL += "@dt_pgto, @valor_pago, @dt_baixa, @id_situacao, @observacao, @id_banco, @nosso_numero, @cnab) ";

                cmd.CommandText = SQL;

                cmd.Parameters.AddWithValue("@id_empresa",    p.empresa.Id);
                cmd.Parameters.AddWithValue("@id_pessoa",     p.pessoa.id);
                cmd.Parameters.AddWithValue("@descricao",     p.descricao);
                cmd.Parameters.AddWithValue("@documento",     p.documento);
                cmd.Parameters.AddWithValue("@id_plano",      p.planoDeConta.id);
                cmd.Parameters.AddWithValue("@dt_emissao",    p.emissao);
                cmd.Parameters.AddWithValue("@dias",          p.dias);
                cmd.Parameters.AddWithValue("@dt_venc",       p.vencimento);
                cmd.Parameters.AddWithValue("@valor",         p.valor);
                cmd.Parameters.AddWithValue("@desconto",      p.desconto);
                cmd.Parameters.AddWithValue("@acrescimo",     p.acrescimo);
                cmd.Parameters.AddWithValue("@id_forma_pgto", p.formaPgto.Id);
                cmd.Parameters.AddWithValue("@id_conta",      p.contaBancaria.id);
                cmd.Parameters.AddWithValue("@dt_pgto",       p.dtPagamento);
                cmd.Parameters.AddWithValue("@valor_pago",    p.valorPago);
                cmd.Parameters.AddWithValue("@dt_baixa",      p.dtBaixa);
                cmd.Parameters.AddWithValue("@id_situacao",   p.situacao.Id);
                cmd.Parameters.AddWithValue("@observacao",    p.anotacao);
                cmd.Parameters.AddWithValue("@id_banco",      p.banco.id);
                cmd.Parameters.AddWithValue("@nosso_numero",  p.nossoNumero);
                cmd.Parameters.AddWithValue("@cnab",          p.cnab);
                con.ComandoSQL(cmd); 
            }            
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void updatePagar(Pagar p)
        {
            try
            {
                cmd = new NpgsqlCommand();

                SQL = "UPDATE fin_pagar ";
                SQL += "SET id_empresa = @empresa, id_pessoa = @pessoa, descricao = @descricao, documento = @documento, ";
                SQL += "id_plano = @plano, dt_emissao = @emissao, dias = @dias, dt_venc = @venc, valor = @ valor, ";
                SQL += "desconto = @desc, acrescimo = @acresc, id_forma_pgto = @pgto, id_conta = @conta, ";
                SQL += "dt_pgto = @dtpgto, valor_pago = @valorpago, dt_baixa = @baixa, id_situacao = @situacao, ";
                SQL += "observacao = @obs, id_banco = @banco, nosso_numero = @nossonumero, cnab = @cnab";

                cmd.CommandText = SQL;

                cmd.Parameters.AddWithValue("@empresa",     p.empresa.Id);
                cmd.Parameters.AddWithValue("@pessoa",      p.pessoa.id);
                cmd.Parameters.AddWithValue("@descricao",   p.descricao);
                cmd.Parameters.AddWithValue("@documento",   p.documento);
                cmd.Parameters.AddWithValue("@plano",       p.planoDeConta.id);
                cmd.Parameters.AddWithValue("@emissao",     p.emissao);
                cmd.Parameters.AddWithValue("@dias",        p.dias);
                cmd.Parameters.AddWithValue("@venc",        p.vencimento);
                cmd.Parameters.AddWithValue("@valor",       p.valor);
                cmd.Parameters.AddWithValue("@desc",        p.desconto);
                cmd.Parameters.AddWithValue("@acresc",      p.acrescimo);
                cmd.Parameters.AddWithValue("@pgto",        p.formaPgto.Id);
                cmd.Parameters.AddWithValue("@conta",       p.contaBancaria.id);
                cmd.Parameters.AddWithValue("@dtpgto",      p.dtPagamento);
                cmd.Parameters.AddWithValue("@valorpago",   p.valorPago);
                cmd.Parameters.AddWithValue("@baixa",       p.dtBaixa);
                cmd.Parameters.AddWithValue("@situacao",    p.situacao.Id);
                cmd.Parameters.AddWithValue("@obs",         p.anotacao);
                cmd.Parameters.AddWithValue("@banco",       p.banco.id);
                cmd.Parameters.AddWithValue("@nossonumero", p.nossoNumero);
                cmd.Parameters.AddWithValue("@cnab",        p.cnab);
                con.ComandoSQL(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion



        #region BANCO
        public void insertBanco(Banco b)
        {
            try
            {
                cmd = new NpgsqlCommand();

                SQL = "INSERT INTO banco ";
                SQL += "(idempresa, codbanco, nome, ativo, agencia, conta)";
                SQL += "VALUES ";
                SQL += "(@idempresa, @codbanco, @nome, @ativo, @agencia, @conta)";

                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@idempresa", b.idEmpresa);
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




        public List<Banco> listarBancos(string sql)
        {
            try
            {
                DataSet ds = con.ConsultaSQL(sql);
                List<Banco> ps = new List<Banco>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Banco b = new Banco
                    {
                        id = int.Parse(dr["id"].ToString()),
                        idEmpresa = int.Parse(dr["idempresa"].ToString()),
                        codigoBanco = int.Parse(dr["codbanco"].ToString()),
                        nome = dr["nome"].ToString(),
                        agencia = dr["agencia"].ToString(),
                        conta = dr["conta"].ToString(),
                        ativo = bool.Parse(dr["ativo"].ToString())
                    };
                    ps.Add(b);
                }
                return ps;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Banco> listaAllBanco(bool ativo)
        {
            try
            {

                SQL = "SELECT id, idempresa, nome, codbanco, agencia, conta, ativo WHERE ativo = " + ativo;

               
                return listarBancos(SQL);

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Banco> selectBancoPorNome(string nome, bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT id, nome, codbanco, agencia, conta FROM banco WHERE nome LIKE '%{0}%' AND ativo = {1} ORDER BY nome", nome, ativo);
                DataSet ds = con.ConsultaSQL(SQL);

                List<Banco> lista = new List<Banco>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Banco obj = new Banco
                    {
                        id = int.Parse(dr["id"].ToString()),
                        nome = dr["nome"].ToString(),
                        codigoBanco = int.Parse(dr["codbanco"].ToString()),
                        agencia = dr["agencia"].ToString(),
                        conta = dr["conta"].ToString()
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


        #region PLANO DE CONTAS

        public void insertPlanoContas(PlanoDeContas pc)
        {
            try
            {
                cmd = new NpgsqlCommand();

                SQL = "INSERT INTO fin_plano_conta ";
                SQL += "(nome, descricao, entrada, saida, ativo) ";
                SQL += "VALUES";
                SQL += "(@nome, @descricao, @entrada, @saida, @ativo) ";

                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@nome", pc.nome);
                cmd.Parameters.AddWithValue("@descricao", pc.descricao);
                cmd.Parameters.AddWithValue("@entrada", pc.entrada);
                cmd.Parameters.AddWithValue("@saida", pc.saida);
                cmd.Parameters.AddWithValue("@ativo", pc.ativo);
                con.ComandoSQL(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void editPlanoContas(PlanoDeContas pc)
        {
            try
            {
                cmd = new NpgsqlCommand();

                SQL = "UPDATE fin_plano_conta";
                SQL += "SET ativo = @ativo, nome = @nome, descricao = @descricao, entrada = @entrada, saida = @saida";
                SQL += "WHERE id = @id";

                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@id", pc.id);
                cmd.Parameters.AddWithValue("@ativo", pc.ativo);
                cmd.Parameters.AddWithValue("@nome", pc.nome);
                cmd.Parameters.AddWithValue("@descricao", pc.descricao);
                cmd.Parameters.AddWithValue("@entrada", pc.entrada);
                cmd.Parameters.AddWithValue("@saida", pc.saida);
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
                SQL = "UPDATE fin_plano_conta SET ativo = @ativo WHERE id = @id";
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

        public List<PlanoDeContas> selectAllPlanoContas(bool ativo)
        {
            try
            {
                SQL = string.Format("SELECT id, nome, descricao, entrada, saida FROM fin_plano_conta WHERE ativo = {0} ORDER BY id", ativo);
                return retornaAllPlanoContas(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private List<PlanoDeContas> retornaAllPlanoContas(string sql)
        {
            try
            {
                DataSet ds = con.ConsultaSQL(sql);
                List<PlanoDeContas> planoContas = new List<PlanoDeContas>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    PlanoDeContas pc = new PlanoDeContas
                    {
                        id = int.Parse(dr["id"].ToString()),
                        nome = dr["nome"].ToString(),
                        descricao = dr["descricao"].ToString(),
                        entrada = bool.Parse(dr["entrada"].ToString()),
                        saida = bool.Parse(dr["saida"].ToString())
                    };
                    planoContas.Add(pc);
                }

                return planoContas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        #endregion

    }
}
