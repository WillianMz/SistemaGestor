using DAO;
using Modelo;
using System;
using System.Collections.Generic;
using Util;

namespace Controller
{
    public class BLL_Sistema
    {
        DAO_Sistema dao;

        #region EMPRESAS

        public void novaEmpresa(Empresa e)
        {
            dao = new DAO_Sistema();
            dao.insertEmpresa(e);
        }

        public void editarEmpresa(Empresa e)
        {
            dao = new DAO_Sistema();
            dao.updateEmpresa(e);
        }
        
        public List<Empresa> listarEmpresas(bool ativo)
        {
            dao = new DAO_Sistema();
            List<Empresa> empresas = dao.getAllEmpresa(ativo);
            return empresas;
        }

        public List<Empresa> filtrarEmpresa_ID(int id, bool ativo)
        {
            dao = new DAO_Sistema();
            List<Empresa> empresas = dao.selectEmpresa_ID(id, ativo);
            return empresas;
        }

        public Empresa filtrarEmpresa_CNPJ(string cnpj, bool ativo)
        {
            try
            {
                dao = new DAO_Sistema();
                Empresa e = dao.selectEmpresa_CNPJ(cnpj, ativo);
                return e;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Empresa verDetalhesEmpresa(int id)
        {
            dao = new DAO_Sistema();
            Empresa e = dao.getDetalhes(id);
            return e;
        }

        #endregion

        #region INICIALIZAÇÃO DO PROGRAMA

        public ParamentroDoSistema getParamentros(string software)
        {
            ParamentroDoSistema p = new ParamentroDoSistema();
            p = util_sistema.lerDadosRegistroWindows(software);
            return p;
        }

        public void salvarParamentros(string software, ParamentroDoSistema ps)
        {
            util_sistema.gravarDadosRegistroWindows(software, ps);
        }

        #endregion
    }
}
