using Modelo.Estoque;
using Sistema.Estoque.Controles;
using Sistema.Estoque.Utilitario;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Util;

namespace Sistema.Estoque.Interfaces
{
    public partial class formConsultaSubgrupo : Form
    {
        BLL_Produto controle;

        public formConsultaSubgrupo()
        {
            InitializeComponent();
            configForm();
        }

        private void configForm()
        {
            carregarComboBox.grupoProduto(cboxGrupo);
        }
        
        private void atualizarGrid(List<Subgrupo> subgrupo)
        {
            dgvDados.Rows.Clear();
            foreach (Subgrupo s in subgrupo)
            {
                dgvDados.Rows.Add(s.Id, s.Nome);
            }
            util_sistema.resultadoPesquisa(dgvDados, lblResultado);
        }

        private void pesquisarSubgrupo(bool ativo)
        {
            controle = new BLL_Produto();
            Grupo g = new Grupo();
            g.Id = Convert.ToInt32(cboxGrupo.SelectedValue);
            List<Subgrupo> sb = controle.filtrarSubgrupos(txtPesquisar.Text, ativo, g);
            atualizarGrid(sb);
        }

        private void menuAdicionar_Click(object sender, EventArgs e)
        {
            formProdutoSubgrupo form = new formProdutoSubgrupo();
            form.statusForm = statusForm.Novo;
            form.ShowDialog();
            form.Dispose();
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
                    Subgrupo s = controle.detalhesSubgrupo(id);

                    formProdutoSubgrupo form = new formProdutoSubgrupo();
                    form.statusForm = statusForm.Editar;
                    form.configForm();
                    form.detalhes(s);
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

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cboxGrupo.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Selecione um grupo!");
                        cboxGrupo.Focus();
                        return;
                    }

                    if (txtPesquisar.Text != "")
                        pesquisarSubgrupo(true);
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
    }
}
