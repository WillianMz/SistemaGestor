using Modelo.Estoque;
using Sistema.Estoque.Controles;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Util;

namespace Sistema.Estoque.Utilitario
{
    public static class carregarComboBox
    {
        #region PRODUTOS
        public static void filtroPesquisaProduto(ComboBox cb)
        {
            cb.Items.Add("Código");
            cb.Items.Add("Código de barras");
            cb.Items.Add("Nome");
            cb.Items.Add("Descrição");
            cb.Items.Add("Marca");
            cb.Items.Add("Fabricante");
        }

        public static void tipoProduto(ComboBox cb)
        {
            try
            {
                BLL_Produto controler = new BLL_Produto();
                List<TipoProduto> tp = controler.buscarTpProduto();
                util_sistema.carregarCombobox(tp, cb);
            }
            catch (Exception)
            { }
        }

        public static void unidade(ComboBox cb)
        {
            try
            {
                BLL_Produto controler = new BLL_Produto();
                List<Unidade> u = controler.buscarUnidade();
                util_sistema.carregarCombobox(u, cb);
            }
            catch (Exception)
            { }
        }

        public static void categoriaProduto(ComboBox cb)
        {
            try
            {
                BLL_Produto controler = new BLL_Produto();
                List<Categoria> c = controler.listarCategorias();
                util_sistema.carregarCombobox(c, cb);
            }
            catch (Exception)
            { }
        }
        
        public static void grupoProduto(ComboBox cbox)
        {
            try
            {
                BLL_Produto controle = new BLL_Produto();
                List<Grupo> g = controle.listarGrupos();
                util_sistema.carregarCombobox(g, cbox);
            }
            catch (Exception)
            { }             
        }

        public static void subgrupoProduto(ComboBox cb, ComboBox cbGrupo)
        {
            try
            {//colocar dentro do tratamento de erro  pois esta dando erro ao converter
                BLL_Produto controler = new BLL_Produto();
                Grupo g = new Grupo();
                g.Id = Convert.ToInt32(cbGrupo.SelectedValue);
                List<Subgrupo> sub = controler.listarSubgrupos(g);
                util_sistema.carregarCombobox(sub, cb);
            }
            catch (Exception)
            { }
        }

        #endregion

        #region ENTRADAS

        public static void tipoNotaFiscal(ComboBox cb)
        {
            try
            {
                BLL_Estoque estoque = new BLL_Estoque();
                List<TipoNota> tn = estoque.tiposDeNotas();
                util_sistema.carregarCombobox(tn, cb);
            }
            catch (Exception)
            { }
        }


        #endregion
    }
}
