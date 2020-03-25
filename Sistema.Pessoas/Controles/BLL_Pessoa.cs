using DAO;
using Modelo;
using System.Collections.Generic;

namespace Sistema.Pessoas.Controles
{
    public class BLL_Pessoa
    {
        DAO_Pessoa dao;

        #region PERSISTENCIA

        public void novo(Pessoa p)
        {
            dao = new DAO_Pessoa();
            dao.insert(p);
        }

        public void editar(Pessoa p)
        {
            dao = new DAO_Pessoa();
            dao.update(p);
        }

        public void desativarAtivar(int id, bool ativo)//apenas ativa ou desativa. Não exclui
        {
            dao = new DAO_Pessoa();
            dao.ativarDesativar(ativo, id);
        }

        public bool cpfCNPJ_Cadastrado(string cpf_cnpj)//verifica se o cpf/cnpj ja esa cadastrado na base
        {
            dao = new DAO_Pessoa();
            List<Pessoa> ps = dao.selectPessoaPorCPF_CNPJ(cpf_cnpj, true);

            if (ps.Count > 0)
                return true;
            else
                return false;
        }

        #endregion

        #region CONSULTAS PESSOA

        public List<TipoPessoa> tiposDePessoas()
        {
            dao = new DAO_Pessoa();
            return dao.selectAllTipoPessoa();
        }           
      
        public List<Pessoa> listarTodasAsPessoas(bool ativo)
        {
            dao = new DAO_Pessoa();
            List<Pessoa> ps = dao.selectAllPessoas(ativo);
            return ps;
        }

        public List<Pessoa> filtrarPessoa_ID(int id, bool ativo)
        {
            dao = new DAO_Pessoa();
            List<Pessoa> ps = dao.selectPorID(id, ativo);
            return ps;
        }

        public List<Pessoa> filtrarPessoa_NOME(string filtro, bool ativo)
        {
            dao = new DAO_Pessoa();
            List<Pessoa> ps = dao.selectPorNome(filtro, ativo);
            return ps;
        }
        
        public List<Pessoa> filtrarPessoa_CPFCNPJ(string filtro, bool ativo)
        {
            dao = new DAO_Pessoa();
            List<Pessoa> ps = dao.selectPessoaPorCPF_CNPJ(filtro, ativo);
            return ps;
        }

        public Pessoa filtroPessoaCPFcnpj(string cpfCNPJ, bool ativo)
        {
            dao = new DAO_Pessoa();
            Pessoa p = dao.getsPessoaPorCPF_CNPJ(cpfCNPJ, ativo);
            return p;
        }

        public Pessoa exibirDetalhesDaPessoa(int id)
        {
            dao = new DAO_Pessoa();
            Pessoa p = dao.getDetalhes(id);
            return p;
        }

        #endregion

        #region CLIENTE

        public List<Pessoa> filtrarCliente_ID(int id, bool ativo)
        {
            dao = new DAO_Pessoa();
            List<Pessoa> p = dao.getClientePorID(id, ativo);
            return p;
        }

        public List<Pessoa> filtrarClientes_NOME(string filtro, bool ativo)
        {
            dao = new DAO_Pessoa();
            List<Pessoa> ps = dao.selectClientePorNome(filtro, ativo);
            return ps;
        }
        
        #endregion

        #region FORNECEDOR

        public List<Pessoa> filtrarFornecedores_ID(int id, bool ativo)
        {
            dao = new DAO_Pessoa();
            List<Pessoa> p = dao.getFornecedorPorID(id, ativo);
            return p;
        }

        public List<Pessoa> filtrarFornecedores_NOME(string filtro, bool ativo)
        {

            dao = new DAO_Pessoa();
            List<Pessoa> ps = dao.selectFornecedorPorNome(filtro, ativo);
            return ps;
        }

        #endregion

        #region TRANSPORTADOR

        public List<Pessoa> filtrarTransp_ID(int id, bool ativo)
        {
            dao = new DAO_Pessoa();
            List<Pessoa> p = dao.getTransportadorPorID(id, ativo);
            return p;
        }

        public List<Pessoa> filtrarTransp_NOME(string filtro, bool ativo)
        {
            dao = new DAO_Pessoa();
            List<Pessoa> ps = dao.selectTransportadorPorNome(filtro, ativo);
            return ps;
        }
        
        #endregion

        #region FUNCIONARIO

        public List<Pessoa> filtrarFuncionarios_ID(int id, bool ativo)
        {
            dao = new DAO_Pessoa();
            List<Pessoa> p = dao.getFuncionarioPorID(id, ativo);
            return p;
        }

        public List<Pessoa> filtrarFuncionarios_NOME(string filtro, bool ativo)
        {
            dao = new DAO_Pessoa();
            List<Pessoa> ps = dao.selectFuncionarioPorNome(filtro, ativo);
            return ps;
        }

        #endregion

        #region OUTROS

        public List<Pessoa> filtrarOutros_ID(int id, bool ativo)
        {
            dao = new DAO_Pessoa();
            List<Pessoa> p = dao.getOutrosPorID(id, ativo);
            return p;
        }

        public List<Pessoa> filtrarOutros_Nome(string filtro, bool ativo)
        {
            dao = new DAO_Pessoa();
            List<Pessoa> ps = dao.selectOutrosPorNome(filtro, ativo);
            return ps;
        }

        #endregion

        #region LOGICA


        #endregion
    }
}
