using Modelo;
using Modelo.Localizacao;
using Sistema.Pessoas.Controles;
using Sistema.Utilitario.Controles;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Util;

namespace Sistema.Pessoas.Utilitario
{
    public static class carregarComboBox
    {
        #region LOCALIZACAO
            
        public static void paises(ComboBox cb)
        {
            try
            {
                BLL_Endereco controle = new BLL_Endereco();
                List<Pais> p = controle.BuscaPais();
                util_sistema.carregarCombobox(p, cb);
            }
            catch(Exception)
            { }
        }

        public static void estados(ComboBox cb, ComboBox cbPais)
        {
            try
            {
                BLL_Endereco controle = new BLL_Endereco();
                Pais pais = new Pais();
                pais.Id = Convert.ToInt32(cbPais.SelectedValue);
                List<UF> estados = controle.BuscaUF(pais);
                util_sistema.carregarCombobox(estados, cb);
            }
            catch (Exception)
            { }
        }

        public static void cidades(ComboBox cb, ComboBox cbUF)
        {
            try
            {
                BLL_Endereco controle = new BLL_Endereco();
                UF uf = new UF();
                uf.Id = Convert.ToInt32(cbUF.SelectedValue);
                List<Cidade> cidades = controle.BuscaCidade(uf);
                util_sistema.carregarCombobox(cidades, cb);
            }
            catch(Exception)
            { }
        }

        #endregion

        #region PESSOAS
        public static void filtroPesquisaPessoa(ComboBox cb)
        {
            cb.Items.Add("Código");
            cb.Items.Add("Nome");
            cb.Items.Add("CPF/CNPJ");
            cb.Items.Add("Desativado");
        }

        public static void tipoPessoa(ComboBox cb)
        {
            try
            {
                BLL_Pessoa controle = new BLL_Pessoa();
                List<TipoPessoa> tp = controle.tiposDePessoas();
                util_sistema.carregarCombobox(tp, cb);
            }
            catch (Exception)
            { }
        }

        #endregion

    }
}
