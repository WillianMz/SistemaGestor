using DAO;
using Modelo;
using System;
using System.Collections.Generic;

namespace Sistema.Pessoas.Controles
{
    public class BLL_Empresa
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
            catch (Exception ex)
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
    }
}
