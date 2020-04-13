using Modelo.Estoque;
using Sistema.Estoque.Controles;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Util;

namespace Sistema.Estoque.Interfaces
{
    public partial class formClassifProdutos : Form
    {
        BLL_Produto controle;
        int idCategoria;
        int idGrupo;
        int idSubgrupo;

        public formClassifProdutos()
        {
            InitializeComponent();
            pesquisarCategoria();
        }


        #region METODOS PARA RECEBER OBJETOS DE CATEGORIA/GRUPOS/SUBGRUPOS

        //private void categoria(Categoria c)
        //{
        //    try
        //    {
        //        //txtCod.Text = Convert.ToString(c.Id);
        //        txtNome.Text = c.nome;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        #endregion

        private void pesquisarCategoria()
        {
            controle = new BLL_Produto();
            List<Categoria> categorias = controle.listarCategorias(true);
            tabelaCategorias(categorias);
        }

        private void pesquisarGrupo()
        {
            controle = new BLL_Produto();
            Categoria c = new Categoria();
            c.Id = idCategoria;
            List<Grupo> gr = controle.listarGrupos(c, true);
            tabelaGrupos(gr);
        }

        private void pesquisarSubgrupo()
        {
            controle = new BLL_Produto();
            Grupo g = new Grupo();
            g.Id = idGrupo;
            List<Subgrupo> s = controle.listarSubgrupos(g, true);
            tabelaSubgrupos(s);
        }

        private void tabelaCategorias(List<Categoria> categorias)
        {
            dgvCategorias.Rows.Clear();
            foreach (Categoria c in categorias)
            {
                dgvCategorias.Rows.Add(c.Id, c.nome);
            }
            //util_sistema.resultadoPesquisa(dgvCategorias);//, lblResultado);
        }

        private void tabelaGrupos(List<Grupo> grupos)
        {
            dgvGrupos.Rows.Clear();
            foreach (Grupo g in grupos)
            {
                dgvGrupos.Rows.Add(g.Id, g.nome);
            }
            //util_sistema.resultadoPesquisa(dgvDados, lblResultado);
        }

        private void tabelaSubgrupos(List<Subgrupo> subgrupos)
        {
            dgvSubgrupos.Rows.Clear();
            foreach (Subgrupo sb in subgrupos)
            {
                dgvSubgrupos.Rows.Add(sb.Id, sb.nome);
            }
            //util_sistema.resultadoPesquisa(dgvDados, lblResultado);
        }


        private void btnNovaCategoria_Click(object sender, EventArgs e)
        {
            formProdutoCategoria form = new formProdutoCategoria();
            form.statusForm = statusForm.Novo;
            form.configForm();
            form.ShowDialog();
            form.Dispose();
            pesquisarCategoria();
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategorias.Rows.Count == 0)
                    lblMensagem.Text = "Nenhuma categoria selecionada!";
                else
                {
                    controle = new BLL_Produto();
                    idCategoria = int.Parse(dgvCategorias.Rows[dgvCategorias.CurrentRow.Index].Cells[0].Value.ToString());
                    Categoria c = controle.detalhesCategoria(idCategoria);

                    formProdutoCategoria form = new formProdutoCategoria();
                    form.statusForm = statusForm.Editar;
                    form.configForm();
                    form.detalhes(c);
                    form.ShowDialog();
                    form.Dispose();
                    pesquisarCategoria();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovoGrupo_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.Rows.Count == 0)
                lblMensagem.Text = "Nenhuma categoria selecionada!";
            else
            {
                controle = new BLL_Produto();
                idCategoria = int.Parse(dgvCategorias.Rows[dgvCategorias.CurrentRow.Index].Cells[0].Value.ToString());

                formProdutoGrupo fGrupo = new formProdutoGrupo();
                fGrupo.statusForm = statusForm.Novo;
                fGrupo.configForm(idCategoria);
                fGrupo.ShowDialog();
                fGrupo.Dispose();
                pesquisarGrupo();
            }
        }

        private void btnEditarGrupo_Click(object sender, EventArgs e)
        {
            if (dgvGrupos.Rows.Count == 0)
                lblMensagem.Text = "Nenhuma grupo selecionado!";
            else
            {
                controle = new BLL_Produto();
                idGrupo = int.Parse(dgvGrupos.Rows[dgvGrupos.CurrentRow.Index].Cells[0].Value.ToString());
                idCategoria = int.Parse(dgvCategorias.Rows[dgvCategorias.CurrentRow.Index].Cells[0].Value.ToString());
                Grupo g = controle.detalhesGrupo(idGrupo);

                formProdutoGrupo fGrupo = new formProdutoGrupo();
                fGrupo.statusForm = statusForm.Editar;
                fGrupo.configForm(idCategoria);
                fGrupo.detalhes(g);
                fGrupo.ShowDialog();
                fGrupo.Dispose();
                pesquisarGrupo();
            }
        }

        private void btnNovoSubgrupo_Click(object sender, EventArgs e)
        {
            if (dgvGrupos.Rows.Count == 0)
                lblMensagem.Text = "Nenhuma grupo selecionado!";
            else
            {
                controle = new BLL_Produto();
                idGrupo = int.Parse(dgvGrupos.Rows[dgvGrupos.CurrentRow.Index].Cells[0].Value.ToString());

                formProdutoSubgrupo fSub = new formProdutoSubgrupo();
                fSub.statusForm = statusForm.Novo;
                fSub.configForm(idGrupo);
                fSub.ShowDialog();
                fSub.Dispose();
                pesquisarSubgrupo();
            }
        }

        private void btnEditarSubgrupo_Click(object sender, EventArgs e)
        {
            if (dgvSubgrupos.Rows.Count == 0)
                lblMensagem.Text = "Nenhuma subgrupo selecionado!";
            else
            {
                controle = new BLL_Produto();
                idSubgrupo = int.Parse(dgvSubgrupos.Rows[dgvSubgrupos.CurrentRow.Index].Cells[0].Value.ToString());
                idGrupo = int.Parse(dgvGrupos.Rows[dgvGrupos.CurrentRow.Index].Cells[0].Value.ToString());
                Subgrupo s = controle.detalhesSubgrupo(idSubgrupo);

                formProdutoSubgrupo fsub = new formProdutoSubgrupo();
                fsub.statusForm = statusForm.Editar;
                fsub.configForm(idGrupo);
                fsub.detalhes(s);
                fsub.ShowDialog();
                fsub.Dispose();
                pesquisarSubgrupo();
            }
        }

        private void eventoClickCategoria()
        {
            if(dgvSubgrupos.Rows != null)
            {
                dgvCategorias.CurrentRow.Selected = true;
                idCategoria = int.Parse(dgvCategorias.Rows[dgvCategorias.CurrentRow.Index].Cells[0].Value.ToString());
                pesquisarGrupo();
                dgvSubgrupos.Rows.Clear();
            }            
        }

        private void eventoClickGrupo()
        {
            if(dgvGrupos.Rows != null)
            {
                dgvGrupos.CurrentRow.Selected = true;
                idGrupo = int.Parse(dgvGrupos.Rows[dgvGrupos.CurrentRow.Index].Cells[0].Value.ToString());
                pesquisarSubgrupo();
            }
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
            eventoClickCategoria();
        }

        private void dgvGrupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            eventoClickGrupo();
        }

        private void dgvCategorias_KeyUp(object sender, KeyEventArgs e)
        {
            eventoClickCategoria();
        }

        private void dgvGrupos_KeyUp(object sender, KeyEventArgs e)
        {
            eventoClickGrupo();
        }
    }
}
