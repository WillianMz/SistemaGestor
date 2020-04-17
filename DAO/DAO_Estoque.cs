using Modelo.Estoque;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Estoque
    {
        Conexao con = Conexao.GetInstancia();
        NpgsqlCommand cmd;
        string SQL;

        //private List<> retornaLista(string sql)C:\WN\Projetos\Gestor\DAO\DAO_Estoque.cs
        //{

        //}

        public List<TipoNota> getTiposDeNotas()
        {
            try
            {
                SQL = "SELECT id, nome FROM estoque_tp_nota";
                DataSet ds = con.ConsultaSQL(SQL);
                List<TipoNota> tn = new List<TipoNota>();

                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    TipoNota t = new TipoNota();
                    t.Id = int.Parse(dr["id"].ToString());
                    t.nome = dr["nome"].ToString();
                    tn.Add(t);
                };
                return tn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        #region ENTRADA

        public int insertEntrada(Entrada entrada)
        {
            try
            {
                cmd = new NpgsqlCommand();

                SQL = "INSERT INTO estoque_entrada ";
                SQL += "(id_empresa, id_tpnota, dh_entrada, id_fornec, id_cfop, ";
                SQL += "chave_nfe, versao_nfe, nat_oper, prot_autor, num_nota, serie_nota, modelo, emissao, sai_ent, ";
                SQL += "bc_icms, vl_icms, icms_deson, v_fcp, fcp_st, fcp_st_ret, v_prod, ";
                SQL += "v_frete, v_seguro, vol_pbruto, vol_pliquido, anotacao, fisco, ";
                SQL += "confirmada, dt_confirmada, cancelada, dt_cancelada, motivo_canc, id_pedido, arquivo) ";
                SQL += "VALUES ";
                SQL += "(@id_empresa, @id_tpnota, @dh_entrada, @id_fornec, @id_cfop, ";
                SQL += "@chave_nfe, @versao_nfe, @nat_oper, @prot_autor, @num_nota, @serie_nota, @modelo, @emissao, @sai_ent, ";
                SQL += "@bc_icms, @vl_icms, @icms_deson, @v_fcp, @fcp_st, @fcp_st_ret, @v_prod, ";
                SQL += "@v_frete, @v_seguro, @v_desc, @v_ipi, @ipi_devol, @v_pis, @v_cofins, @v_outro, @total_nf, ";
                SQL += "@id_transp, @mod_frente, @vol_pbruto, @vol_pliquido, @anotacao, @fisco, ";
                SQL += "@confirmada, @dt_confirmada, @cancelada, @dt_cancelada, @motivo_canc, @id_pedido, @arquivo) ";

                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@id_empresa",    entrada.empresa.Id);
                cmd.Parameters.AddWithValue("@id_tpnota",     entrada.tipoNota.Id);
                cmd.Parameters.AddWithValue("@dh_entrada",    entrada.dhEntrada);
                cmd.Parameters.AddWithValue("@id_fornec",     entrada.fornec.Id);
                cmd.Parameters.AddWithValue("@id_cfop",       entrada.cfop);
                cmd.Parameters.AddWithValue("@chave_nfe",     entrada.chaveNFE);
                cmd.Parameters.AddWithValue("@versao_nfe",    entrada.versaoNFE);
                cmd.Parameters.AddWithValue("@nat_oper",      entrada.natOperacao);
                cmd.Parameters.AddWithValue("@prot_autor",    entrada.protAutorizacao);
                cmd.Parameters.AddWithValue("@num_nota",      entrada.numeroNota);
                cmd.Parameters.AddWithValue("@serie_nota",    entrada.serieNota);
                cmd.Parameters.AddWithValue("@modelo",        entrada.modelo);
                cmd.Parameters.AddWithValue("@emissao",       entrada.dhEmissao);
                cmd.Parameters.AddWithValue("@sai_ent",       entrada.dhSaiEnt);
                cmd.Parameters.AddWithValue("@bc_icms",       entrada.vBCICMS);
                cmd.Parameters.AddWithValue("@vl_icms",       entrada.vICMS);
                cmd.Parameters.AddWithValue("@icms_deson",    entrada.vICMSDeson);
                cmd.Parameters.AddWithValue("@v_fcp",         entrada.vFCP);
                cmd.Parameters.AddWithValue("@fcp_st",        entrada.vFCPST);
                cmd.Parameters.AddWithValue("@fcp_st_ret",    entrada.vFCPSTRet);
                cmd.Parameters.AddWithValue("@v_prod",        entrada.vProd);
                cmd.Parameters.AddWithValue("@v_frete",       entrada.vFrete);
                cmd.Parameters.AddWithValue("@v_seguro",      entrada.vSeguro);
                cmd.Parameters.AddWithValue("@v_desc",        entrada.vDesc);
                cmd.Parameters.AddWithValue("@v_ipi",         entrada.vIPI);
                cmd.Parameters.AddWithValue("@ipi_devol",     entrada.vIPIDevol);
                cmd.Parameters.AddWithValue("@v_pis",         entrada.vPIS);
                cmd.Parameters.AddWithValue("@v_cofins",      entrada.vCOFINS);
                cmd.Parameters.AddWithValue("@v_outro",       entrada.vOutro);
                cmd.Parameters.AddWithValue("@total_nf",      entrada.totalNF);
                cmd.Parameters.AddWithValue("@id_transp",     entrada.transp.Id);
                cmd.Parameters.AddWithValue("@mod_frente",    entrada.modFrete);
                cmd.Parameters.AddWithValue("@vol_pbruto",    entrada.pesoBruto);
                cmd.Parameters.AddWithValue("@vol_pliquido",  entrada.pesoLiquido);
                cmd.Parameters.AddWithValue("@anotacao",      entrada.anotacao);
                cmd.Parameters.AddWithValue("@fisco",         entrada.obsFisco);
                cmd.Parameters.AddWithValue("@confirmada",    entrada.confirmada);              
                cmd.Parameters.AddWithValue("@dt_confirmada", entrada.dtConfirmada);
                cmd.Parameters.AddWithValue("@cancelada",     entrada.cancelada);
                cmd.Parameters.AddWithValue("@dt_cancelada",  entrada.dtCancelada);
                cmd.Parameters.AddWithValue("@motivo_canc",   entrada.motivoCancelamento);
                cmd.Parameters.AddWithValue("@id_pedido",     entrada.pedido);
                cmd.Parameters.AddWithValue("@arquivo",       entrada.arquivoXML);

                entrada.Id = con.ComandoID(cmd);

                #region INSERT ITENS DA ENTRADA

                if (entrada.itens != null && entrada.itens.Count > 0)
                {
                    for (int i = 0; i <= entrada.itens.Count - 1; i++)
                    {
                        cmd = new NpgsqlCommand();

                        if (entrada.itens[i].Id == 0)
                        {
                            SQL = "INSERT INTO estoque_entrada_item ";
                            SQL += "(id_entrada, id_produto, id_cfop, id_cst, id_unid, qtd_un, ";
                            SQL += "vl_unit, vl_desconto, vl_outro, bc_icms, vl_icms, vl_ipi, alq_icms, alq_ipi)";
                            SQL += "VALUES ";
                            SQL += "(@id_entrada, @id_produto, @id_cfop, @id_cst, @id_unid, @qtd_un, ";
                            SQL += "@vl_unit, @vl_desconto, @vl_outro, @bc_icms, @vl_icms, @vl_ipi, @alq_icms, @alq_ipi) ";

                            cmd.CommandText = SQL;

                            cmd.Parameters.AddWithValue("@id_entrada",  entrada.Id);
                            cmd.Parameters.AddWithValue("@id_produto",  entrada.itens[i].produto.Id);
                            cmd.Parameters.AddWithValue("@id_cfop",     entrada.itens[i].cfop.Id);
                            cmd.Parameters.AddWithValue("@id_cst",      entrada.itens[i].cst.Id);
                            cmd.Parameters.AddWithValue("@id_unid",     entrada.itens[i].unid.Id);
                            cmd.Parameters.AddWithValue("@qtd_un",      entrada.itens[i].qtd);
                            cmd.Parameters.AddWithValue("@vl_unit",     entrada.itens[i].vlUnit);
                            cmd.Parameters.AddWithValue("@vl_desconto", entrada.itens[i].vlDesc);
                            cmd.Parameters.AddWithValue("@vl_outro",    entrada.itens[i].vlOutros);
                            cmd.Parameters.AddWithValue("@bc_icms",     entrada.itens[i].bcICMS);
                            cmd.Parameters.AddWithValue("@vl_icms",     entrada.itens[i].vlICMS);
                            cmd.Parameters.AddWithValue("@vl_ipi",      entrada.itens[i].vlIPI);
                            cmd.Parameters.AddWithValue("@alq_icms",    entrada.itens[i].alqICMS);
                            cmd.Parameters.AddWithValue("@alq_ipi",     entrada.itens[i].alqIPI);

                            con.ComandoSQL(cmd);
                        }
                    }
                }
                #endregion
                /*
                #region REGISTRAR MOVIMENTO NO ESTOQUE

                if (entrada.itens != null && entrada.itens.Count > 0)
                {
                    for (int i = 0; i <= entrada.itens.Count - 1; i++)
                    {
                        cmd = new NpgsqlCommand();

                        if (entrada.itens[i].Id == 0)
                        {
                            cmd = new NpgsqlCommand();

                        }
                    }
                }

                #endregion
                */
                return entrada.Id;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

    }
}
