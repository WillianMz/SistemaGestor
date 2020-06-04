using Modelo.Estoque;
using Sistema.Estoque.Controles;
using Sistema.Estoque.Utilitario;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Util;

namespace Sistema.Estoque.Interfaces
{
    public partial class formConsultaProduto : Form
    {
        public statusForm statusForm;
        BLL_Produto controle;

        public formConsultaProduto()
        {
            InitializeComponent();
            configForm();

            carregarComboBox.filtroPesquisaProduto(cbFiltro);
            cbFiltro.Text = "Nome";
            txtPesquisar.Focus();
        }

        public void configForm()
        {

            if (statusForm == statusForm.Selecionar)
            {
                this.Text = "Consulta de produto";
                lblMensagem.Text = "Procure pelo produto e clique em Selecionar";
                menuAcoes.Visible = false;
                btnSelecionar.Visible = true;
            }
        }

        private void atualizarGrid(List<Produto> ps)
        {
            dgvProdutos.Rows.Clear();
            foreach (Produto p in ps)
            {
                dgvProdutos.Rows.Add(p.Id, p.Codigo, p.Nome, p.Descricao, p.Custo, p.PrecoVenda, p.VendaMargem + "%", p.Marca, p.Fabricante);
            }
            util_sistema.resultadoPesquisa(dgvProdutos, lblMensagem);
        }

        //usado quando a pesquisa é por codigo e retorna somente um objeto
        private void atualizarGrid2(Produto p)
        {
            try
            {
                dgvProdutos.Rows.Clear();

                if (p != null)
                {
                    dgvProdutos.Rows.Add(p.Id, p.Codigo, p.Nome, p.Descricao, p.Custo, p.PrecoVenda, p.VendaMargem + "%", p.Marca, p.Fabricante);
                }

                util_sistema.resultadoPesquisa(dgvProdutos, lblMensagem);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void pesquisarProduto(bool ativo)
        {
            try
            {
                controle = new BLL_Produto();
                List<Produto> produtos;
                Produto p;

                switch (cbFiltro.Text)
                {
                    case "Código":
                        p = controle.filtrarProduto_ID(Convert.ToInt32(txtPesquisar.Text), ativo);
                        atualizarGrid2(p);
                        break;

                    case "Código de barras":
                        p = controle.filtrarProduto_CODIGO(txtPesquisar.Text, ativo);
                        atualizarGrid2(p);
                        break;

                    case "Nome":
                        produtos = controle.filtrarProduto_NOME(txtPesquisar.Text, ativo);
                        atualizarGrid(produtos);
                        break;

                    case "Descrição":
                        produtos = controle.filtrarProduto_DESCRICAO(txtPesquisar.Text, ativo);
                        atualizarGrid(produtos);
                        break;

                    case "Marca":
                        produtos = controle.filtrarProduto_MARCA(txtPesquisar.Text, ativo);
                        atualizarGrid(produtos);
                        break;

                    case "Fabricante":
                        produtos = controle.filtrarProduto_FABRICANTE(txtPesquisar.Text, ativo);
                        atualizarGrid(produtos);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void executarConsulta()
        {
            if (chboxDesativados.Checked == true)
                pesquisarProduto(false);
            else
                pesquisarProduto(true);
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtPesquisar.Text != "")
                        executarConsulta();
                    else
                    {
                        lblMensagem.Text = util_msg.msgFiltroPesquisaVazio;
                        txtPesquisar.Focus();
                    }
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

            if (cbFiltro.Text == "Código")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void menuAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                formProduto form = new formProduto();
                form.statusForm = statusForm.Novo;
                form.configForm();
                form.ShowDialog();
                form.Dispose();
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
                if (dgvProdutos.Rows.Count == 0)
                    lblMensagem.Text = "Nenhum registro selecionado!";
                else
                {
                    controle = new BLL_Produto();
                    int id = int.Parse(dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells[0].Value.ToString());
                    Produto p = controle.detalhesDoProduto(id);
                    formProduto form = new formProduto();
                    form.statusForm = statusForm.Editar;
                    form.configForm();
                    form.detalhes(p);
                    form.ShowDialog();
                    form.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuDetalhes_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProdutos.Rows.Count == 0)
                    lblMensagem.Text = "Nenhum registro selecionado!";
                else
                {
                    controle = new BLL_Produto();
                    int id = int.Parse(dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells[0].Value.ToString());
                    Produto p = controle.detalhesDoProduto(id);
                    formProduto form = new formProduto();
                    form.statusForm = statusForm.Detalhes;
                    form.configForm();
                    form.detalhes(p);
                    form.ShowDialog();
                    form.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuDesativar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProdutos.Rows.Count == 0)
                    lblMensagem.Text = "Nenhum registro selecionado!";
                else
                {
                    controle = new BLL_Produto();
                    int id = int.Parse(dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells[0].Value.ToString());
                    string nome = Convert.ToString(dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells[2].Value.ToString());

                    DialogResult result = MessageBox.Show("Desativar o produto: (" + id + ") " + nome + " ?", util_msg.sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        controle.ativarDesativar(id, false);
                        MessageBox.Show(util_msg.msgDesativarProduto, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    executarConsulta();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Produto selecionarProduto()
        {
            try
            {
                controle = new BLL_Produto();
                int id = int.Parse(dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells[0].Value.ToString());
                Produto p = new Produto();
                p = controle.detalhesDoProduto(id);
                return p;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProdutos.Rows.Count == 0)
                    return;
                else
                {
                    lblMensagem.Text = "Nenhum registro foi selecionado, verifique!";
                    selecionarProduto();
                    this.Close();
                }
            }
            catch (Exception)
            {

            }
        }

        private void cbFiltro_Leave(object sender, EventArgs e)
        {
            txtPesquisar.Clear();
        }

        private void movimentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formHistoricoMovProduto f = new formHistoricoMovProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void mOpcaoEstruturaMercadologica_Click(object sender, EventArgs e)
        {
            formClassifProdutos f = new formClassifProdutos();
            f.status = statusForm.Consulta;
            f.configForm();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
