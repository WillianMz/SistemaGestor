using Controller;
using Modelo.Estoque;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Util;

namespace Interfaces.Modulos.Estoque
{
    public partial class formConsultaGrupo : Form
    {
        BLL_Produto controle;

        public formConsultaGrupo()
        {
            InitializeComponent();
        }

        private void atualizarGrid(List<Grupo> grupo)
        {
            dgvDados.Rows.Clear();
            foreach (Grupo g in grupo)
            {
                dgvDados.Rows.Add(g.Id, g.Nome);
            }
            util_sistema.resultadoPesquisa(dgvDados, lblResultado);
        }

        private void pesquisarGrupo(bool ativo)
        {
            controle = new BLL_Produto();
            List<Grupo> gr = controle.filtrarGrupos(txtPesquisar.Text, ativo);
            atualizarGrid(gr);
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            util_sistema.keyPress(sender, e);
        }

        private void menuAdicionar_Click(object sender, System.EventArgs e)
        {
            formProdutoGrupo form = new formProdutoGrupo();
            form.statusForm = statusForm.Novo;
            form.ShowDialog();
            form.Dispose();
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtPesquisar.Text != "")
                        pesquisarGrupo(true);
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
                    Grupo g = controle.detalhesGrupo(id);

                    formProdutoGrupo form = new formProdutoGrupo();
                    form.statusForm = statusForm.Editar;
                    form.configForm();
                    form.detalhes(g);
                    form.ShowDialog();
                    form.Dispose();
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
        }
    }
}
