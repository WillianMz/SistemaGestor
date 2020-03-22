using Controller;
using Modelo;
using Modelo.Estoque;
using Modelo.Localizacao;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Util;

namespace Interfaces.Utilitario
{
    public static class carregarComboBox
    {
        //esta classe serve para preencher as combobox do sitema
        //utilizar os metodos abaixo para qualquer parte da interface

        //obs.: não esta sendo usado tratamento de erros nos metodos porque está dando erro quando é feito a consulta na base


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

        #region EMPRESAS

        public static void empresas(ComboBox cb)
        {
            try
            {
                BLL_Sistema sistema = new BLL_Sistema();
                List<Empresa> e = sistema.listarEmpresas(true);
                util_sistema.carregarCombobox(e, cb);
            }
            catch (Exception)
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
            catch(Exception )
            { }
        }

        #endregion

        #region PRODUTOS
        public static void filtroPesquisaProduto(ComboBox cb)
        {
            cb.Items.Add("Código");
            cb.Items.Add("Código de barras");
            cb.Items.Add("Nome");
            cb.Items.Add("Descrição");
            cb.Items.Add("Marca");
            cb.Items.Add("Fabricante");
            cb.Items.Add("Desativados");
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
