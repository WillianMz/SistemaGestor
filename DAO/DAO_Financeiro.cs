using Modelo.Financeiro;
using Npgsql;
using System;

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
                cmd.Parameters.AddWithValue("@id_pessoa",     p.pessoa.Id);
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
                cmd.Parameters.AddWithValue("@pessoa",      p.pessoa.Id);
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


    }
}
