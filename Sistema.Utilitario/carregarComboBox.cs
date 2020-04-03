using Modelo;
using Sistema.Utilitario.Controles;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Util;

namespace Sistema.Utilitario
{
    public static class carregarComboBox
    {
        #region EMPRESAS
        
        public static void empresas(ComboBox cb)
        {
            try
            {
                BLL_Empresa emp = new BLL_Empresa();
                List<Empresa> empresas = emp.listarEmpresas(true);
                util_sistema.carregarCombobox(empresas, cb);
            }
            catch (Exception)
            { }
        }

        #endregion

    }
}
