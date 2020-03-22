using Controller;
using Modelo.Estoque;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Util;

namespace Interfaces.Modulos.Estoque
{
    public partial class formConsultaCategoria : Form
    {
        BLL_Produto controle;

        public formConsultaCategoria()
        {
            InitializeComponent();
        }

        private void menuAdicionar_Click(object sender, EventArgs e)
        {
            formProdutoCategoria form = new formProdutoCategoria();
            form.statusForm = statusForm.Novo;
            form.ShowDialog();
            form.Dispose();
        }

        private void atualizarGrid(List<Categoria> categ)
        {
            dgvDados.Rows.Clear();
            foreach(Categoria c in categ)
            {
                dgvDados.Rows.Add(c.Id, c.Nome);
            }
            util_sistema.resultadoPesquisa(dgvDados, lblResultado);
        }

        private void pesquisarCategoria(bool ativo)
        {
            controle = new BLL_Produto();
            List<Categoria> categorias = controle.filtrarCategorias(txtPesquisar.Text, ativo);
            atualizarGrid(categorias);
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtPesquisar.Text != "")
                        pesquisarCategoria(true);
                    else
                    {
                        lblResultado.Text = util_msg.msgFiltroPesquisaVazio;
                        txtPesquisar.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDados.Rows.Count == 0)
                    lblResultado.Text = "Nenhum registro selecionado!";
                else
                {
                    controle = new BLL_Produto();
                    int id = int.Parse(dgvDados.Rows[dgvDados.CurrentRow.Index].Cells[0].Value.ToString());
                    Categoria c = controle.detalhesCategoria(id);

                    formProdutoCategoria form = new formProdutoCategoria();
                    form.statusForm = statusForm.Editar;
                    form.configForm();
                    form.detalhes(c);
                    form.ShowDialog();
                    form.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            util_sistema.keyPress(sender, e);
        }
    }
}
