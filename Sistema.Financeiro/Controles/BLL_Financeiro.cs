﻿using DAO;
using Modelo.Financeiro;

namespace Sistema.Financeiro.Controles
{
    public class BLL_Financeiro
    {
        DAO_Financeiro dao;

        public void novoPagar(Pagar p)
        {
            dao = new DAO_Financeiro();
            dao.insertPagar(p);
        }
    }
}
