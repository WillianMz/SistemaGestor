using Modelo;
using Sistema.Pessoas.Controles;
using Sistema.Pessoas.Utilitario;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Util;

namespace Sistema.Pessoas.Interfaces
{
    public partial class formConsultaPessoa : Form
    {
        public consultaPessoaPorTipo tpConsultaPessoa;
        BLL_Pessoa controle;

        public formConsultaPessoa()
        {
            InitializeComponent();
            configForm();
        }

        private void configForm()
        {
            carregarComboBox.filtroPesquisaPessoa(cboxFiltro);
            cboxFiltro.Text = "Nome";//default
            txtPesquisar.Focus();
        }

        private void atualizarGrid(List<Pessoa> ps)
        {
            dgvPessoa.Rows.Clear();
            foreach(Pessoa p in ps)
            {
                dgvPessoa.Rows.Add(p.Id, p.NomeCompleto, p.Fantasia, p.CPF_CNPJ, p.Telefone, p.Email, p.Local);
            }
            util_sistema.resultadoPesquisa(dgvPessoa, lblResultado);
        }

        //teste
        //private void atualizarGrid2(Pessoa p)
        //{
        //    dgvPessoa.Rows.Clear();
        //    dgvPessoa.Rows.Add(p.Id, p.NomeCompleto, p.Fantasia, p.CPF_CNPJ, p.Telefone, p.Email, p.Local);
        //    util_sistema.resultadoPesquisa(dgvPessoa, lblResultado);
        //}

        private void pesquisarPessoas(bool ativo)
        {
            try
            {
                controle = new BLL_Pessoa();
                List<Pessoa> ps;

                #region TODAS AS PESSOAS
                if(tpConsultaPessoa == consultaPessoaPorTipo.Pessoas)
                {
                    switch (cboxFiltro.Text)
                    {
                        case "Código":
                            ps = controle.filtrarPessoa_ID(Convert.ToInt32(txtPesquisar.Text), ativo);
                            atualizarGrid(ps);
                            break;
                        case "Nome":
                            ps = controle.filtrarPessoa_NOME(txtPesquisar.Text, ativo);
                            atualizarGrid(ps);
                            break;
                        case "CPF/CNPJ":
                            ps = controle.filtrarPessoa_CPFCNPJ(txtPesquisar.Text, ativo);
                            atualizarGrid(ps);
                            break;
                        case "Todos":
                            ps = controle.listarTodasAsPessoas(ativo);
                            atualizarGrid(ps);
                            break;
                    }
                }                
                #endregion

                #region CLIENTES
                if (tpConsultaPessoa == consultaPessoaPorTipo.Cliente)
                {                   
                    switch (cboxFiltro.Text)
                    {
                        case "Código":
                            ps = controle.filtrarCliente_ID(Convert.ToInt32(txtPesquisar.Text), ativo);
                            atualizarGrid(ps);
                            break;
                        case "Nome":
                            ps = controle.filtrarClientes_NOME(txtPesquisar.Text, ativo);
                            atualizarGrid(ps);
                            break;
                        case "CPF/CNPJ":
                            ps = controle.filtrarPessoa_CPFCNPJ(txtPesquisar.Text, ativo);
                            atualizarGrid(ps);
                            break;
                    }
                }
                #endregion

                #region FORNECEDOR
                if (tpConsultaPessoa == consultaPessoaPorTipo.Fornecedor)
                {
                    switch (cboxFiltro.Text)
                    {
                        case "Código":
                            ps = controle.filtrarFornecedores_ID(Convert.ToInt32(txtPesquisar.Text), ativo);
                            atualizarGrid(ps);
                            break;
                        case "Nome":
                            ps = controle.filtrarFornecedores_NOME(txtPesquisar.Text, ativo);
                            atualizarGrid(ps);
                            break;
                        case "CPF/CNPJ":
                            ps = controle.filtrarPessoa_CPFCNPJ(txtPesquisar.Text, ativo);
                            atualizarGrid(ps);
                            break;
                    }
                }
                #endregion

                #region TRANSPORTADOR
                if (tpConsultaPessoa == consultaPessoaPorTipo.Transportador)
                {
                    switch (cboxFiltro.Text)
                    {
                        case "Código":
                            ps = controle.filtrarTransp_ID(Convert.ToInt32(txtPesquisar.Text), ativo);
                            atualizarGrid(ps);
                            break;
                        case "Nome":
                            ps = controle.filtrarTransp_NOME(txtPesquisar.Text, ativo);
                            atualizarGrid(ps);
                            break;
                        case "CPF/CNPJ":
                            ps = controle.filtrarPessoa_CPFCNPJ(txtPesquisar.Text, ativo);
                            atualizarGrid(ps);
                            break;
                    }
                }
                #endregion

                #region FUNCIONARIO

                if (tpConsultaPessoa == consultaPessoaPorTipo.Funcionario)
                {
                    switch (cboxFiltro.Text)
                    {
                        case "Código":
                            ps = controle.filtrarFuncionarios_ID(Convert.ToInt32(txtPesquisar.Text), ativo);
                            atualizarGrid(ps);
                            break;
                        case "Nome":
                            ps = controle.filtrarFuncionarios_NOME(txtPesquisar.Text, ativo);
                            atualizarGrid(ps);
                            break;
                        case "CPF/CNPJ":
                            ps = controle.filtrarPessoa_CPFCNPJ(txtPesquisar.Text, ativo);
                            atualizarGrid(ps);
                            break;
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       #region MENU

        private void menuAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                formPessoa form = new formPessoa();
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

        private void menuDetalhes_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPessoa.Rows.Count == 0)
                    lblResultado.Text = "Nenhum registro selecionado!";
                else
                {
                    controle = new BLL_Pessoa();
                    int id = int.Parse(dgvPessoa.Rows[dgvPessoa.CurrentRow.Index].Cells[0].Value.ToString());
                    Pessoa p = controle.exibirDetalhesDaPessoa(id);
                    formPessoa form = new formPessoa();
                    form.statusForm = statusForm.Detalhes;
                    form.detalhes(p);
                    form.configForm();
                    form.ShowDialog();
                    form.Dispose();
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
                if (dgvPessoa.Rows.Count == 0)
                    lblResultado.Text = "Nenhum registro selecionado!";
                else
                {
                    controle = new BLL_Pessoa();
                    int id = int.Parse(dgvPessoa.Rows[dgvPessoa.CurrentRow.Index].Cells[0].Value.ToString());
                    Pessoa p = controle.exibirDetalhesDaPessoa(id);
                    formPessoa form = new formPessoa();
                    form.statusForm = statusForm.Editar;
                    form.detalhes(p);
                    form.configForm();
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
                if (dgvPessoa.Rows.Count == 0)
                    lblResultado.Text = "Nenhum registro selecionado!";
                else
                {
                    BLL_Pessoa psController = new BLL_Pessoa();
                    int id = int.Parse(dgvPessoa.Rows[dgvPessoa.CurrentRow.Index].Cells[0].Value.ToString());
                    string nome = Convert.ToString(dgvPessoa.Rows[dgvPessoa.CurrentRow.Index].Cells[1].Value.ToString());
                    DialogResult result = MessageBox.Show("Deseja realmente desativar a pessoa ( " + id + " ) " + nome + " ?", util_msg.sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        psController.desativarAtivar(id, false);
                        MessageBox.Show(util_msg.msgDesativar, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void formConsultaPessoa_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtPesquisar.Text != "")
                    {
                        pesquisarPessoas(true);
                    }
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
            if (e.KeyChar == '\'')
                e.Handled = true;

            if(cboxFiltro.Text == "Código")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show(util_msg.msgFiltroPorCodigo, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cboxFiltro_Leave(object sender, EventArgs e)
        {
            txtPesquisar.Clear();
            txtPesquisar.Focus();
        }
    }
}
