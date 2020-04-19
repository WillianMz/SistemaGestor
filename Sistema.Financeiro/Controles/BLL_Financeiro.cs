using DAO;
using Modelo.Financeiro;
using System.Collections.Generic;

namespace Sistema.Financeiro.Controles
{
    public class BLL_Financeiro
    {
        DAO_Financeiro daoFinanceiro;

        #region PAGAR
        public void novoPagar(Modelo.Financeiro.Pagar p)
        {
            daoFinanceiro = new DAO_Financeiro();
            daoFinanceiro.insertPagar(p);
        }

        #endregion

        #region RECEBER
        #endregion


        #region BANCO
         public void novoBanco(Banco b)
        {
            daoFinanceiro = new DAO_Financeiro();
            daoFinanceiro.insertBanco(b);
        }



        public List<Banco> filtrarBancos(string filtro, bool ativo)
        {
            daoFinanceiro = new DAO_Financeiro();
            List<Banco> cs = daoFinanceiro.selectBancoPorNome(filtro, ativo);
            return cs;
        }

        #endregion

        #region PLANO DE CONTAS
        public void novoPlanoContas(PlanoDeContas pc)
        {
            daoFinanceiro = new DAO_Financeiro();
            daoFinanceiro.insertPlanoContas(pc);
        }

        public void editarPlanoContas(PlanoDeContas pc)
        {
            daoFinanceiro = new DAO_Financeiro();
            daoFinanceiro.editPlanoContas(pc);
        }

        public List<PlanoDeContas> listarTodosPlanoContas(bool ativo)
        {
            daoFinanceiro = new DAO_Financeiro();
            List<PlanoDeContas> pc = daoFinanceiro.selectAllPlanoContas(ativo);
            return pc;
        }


        #endregion











    }
}
