using Controller;
using Interfaces.Modulos.Estoque;
using Interfaces.Utilitario;
using Modelo.Estoque;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Util;

namespace Interfaces.Modulo.Estoque
{
    public partial class formConsultaProduto : Form
    {
        public statusForm statusForm;
        BLL_Produto controle;        

        public formConsultaProduto()
        {
            InitializeComponent();
            configForm();
        }

        private void configForm()
        {
            carregarComboBox.filtroPesquisaProduto(cboxFiltro);
            cboxFiltro.Text = "Nome";
            txtPesquisar.Focus();

            if (statusForm == statusForm.Novo)
            {

            }

            if (statusForm == statusForm.Editar)
            {

            }

            if (statusForm == statusForm.Detalhes)
            {

            }

            if(statusForm == statusForm.Consulta)
            {
                menuAcoes.Visible = false;
            }

        }

        private void atualizarGrid(List<Produto> ps)
        {
            dgvProdutos.Rows.Clear();
            foreach(Produto p in ps)
            {
                dgvProdutos.Rows.Add(p.Id, p.Codigo, p.Nome, p.Descricao, p.Custo, p.PrecoVenda, p.VendaMargem +"%", p.Marca, p.Fabricante);
            }
            util_sistema.resultadoPesquisa(dgvProdutos, lblResultado);
        }

        //teste
        //usado quando a pesquisa é por codigo e retorna somente um objeto
        private void atualizarGrid2(Produto p)
        {
            dgvProdutos.Rows.Clear();
            dgvProdutos.Rows.Add(p.Id, p.Codigo, p.Nome, p.Descricao, p.Custo, p.PrecoVenda, p.VendaMargem + "%", p.Marca, p.Fabricante);
            util_sistema.resultadoPesquisa(dgvProdutos, lblResultado);
        }

        public Produto retornaProduto()
        {
            try
            {
                controle = new BLL_Produto();
                int id = int.Parse(dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells[0].Value.ToString());
                Produto p = controle.detalhesDoProduto(id);
                return p;
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void pesquisarProduto(bool ativo)
        {
            try
            {
                controle = new BLL_Produto();
                List<Produto> produtos;
                Produto p;

                switch (cboxFiltro.Text)
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
        
        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode == Keys.Enter)
                {
                    if (txtPesquisar.Text != "")
                        pesquisarProduto(true);
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
        
        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            util_sistema.keyPress(sender, e);

            if (cboxFiltro.Text == "Código")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show(util_msg.msgFiltroPorCodigo, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                    lblResultado.Text = "Nenhum registro selecionado!";
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
                    lblResultado.Text = "Nenhum registro selecionado!";
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
                    lblResultado.Text = "Nenhum registro selecionado!";
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
                    pesquisarProduto(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuListagemDesativados_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisar.Text != "")
                    pesquisarProduto(false);
                else
                {
                    lblResultado.Text = util_msg.msgFiltroPesquisaVazio;
                    txtPesquisar.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
