using Modelo;
using Sistema.Pessoas.Controles;
using Sistema.Pessoas.Utilitario;
using System;
using System.Drawing;
using System.Windows.Forms;
using Util;

namespace Sistema.Pessoas.Interfaces
{
    public partial class formPessoa : Form
    {
        DateTime dataAtual;
        public statusForm statusForm;
        public tipoPessoa tpPessoa;
        BLL_Pessoa controle;

        public formPessoa()
        {
            InitializeComponent();

            carregarCombobox();
            configForm();
        }

        public void configForm()
        {
            if(statusForm == statusForm.Novo)
            {
                lblMensagem.Text = "Inserindo novo registro";
                lblTitulo.Text = "Nova registro";
                bloquearCampos();
                cbTipoPessoa.Enabled = true;
                btnSalvar.Visible = true;
                btnNovo.Visible = false;
                btnCancelar.Text = "Cancelar";
            }

            if(statusForm == statusForm.Editar)
            {
                configurarPessoa();
                ativarComponentes();
                lblMensagem.Text = "Editando dados da pessoa";
                cbTipoPessoa.Enabled = false;
                txtCNPJ.Enabled = false;
                txtNome.Focus();
                btnNovo.Visible = false;
            }

            if(statusForm == statusForm.Detalhes)
            {
                bloquearCampos();
                lblMensagem.Text = "Visualizando dados da pessoa";
                btnSalvar.Visible = false;
                btnCancelar.Text = "Voltar";
                btnNovo.Visible = true;
            }

            #region CONFIGURAR O FORM PELO TIPO DE PESSOA SENDO EDITADA NO MOMENTO

            if(tpPessoa == tipoPessoa.Cliente)
            {
                //tabDetCliente.
            }

            if(tpPessoa == tipoPessoa.Fornecedor)
            {

            }

            if(tpPessoa == tipoPessoa.Transportador)
            {

            }

            if(tpPessoa == tipoPessoa.Colaborador)
            {

            }

            if(tpPessoa == tipoPessoa.Outro)
            {

            }

            #endregion
        }

        private void configurarPessoa()
        {
            if (cbTipoPessoa.Text == "Jurídica")
            {
                txtCNPJ.MaxLength = 14;
                lblCNPJ.Text         = "CNPJ";
                lblNome.Text         = "Razão Social";
                lblIE.Text           = "Insc.Estadual";
                lblDtNascimento.Text = "Dt.Fundação";
            }

            if (cbTipoPessoa.Text == "Física")
            {
                txtCNPJ.MaxLength = 11;
                lblCNPJ.Text     = "CPF";
                lblNome.Text     = "Nome Completo";
                lblFantasia.Text = "Apelido";
                lblIE.Text       = "RG(Identidade)";
            }
        }

        private void carregarCombobox()
        {
            carregarComboBox.tipoPessoa(cbTipoPessoa);
            carregarComboBox.paises(comboBoxPais);
            carregarComboBox.estados(comboBoxUF, comboBoxPais);
            carregarComboBox.cidades(comboBoxCidade, comboBoxUF);
        }

        private void bloquearCampos()
        {
            util_sistema.bloquearComponentesGroupBox(gbPrincipal, false);
            util_sistema.bloquearComponentesTabPage(tabEndereco, false);
            util_sistema.bloquearComponentesTabPage(tabContato, false);
            util_sistema.bloquearComponentesTabPage(tabDadosAdicionais, false);
        }

        private void ativarComponentes()
        {            
            util_sistema.bloquearComponentesTabPage(tabEndereco, true);
            util_sistema.bloquearComponentesTabPage(tabContato, true);
            util_sistema.bloquearComponentesTabPage(tabDadosAdicionais, true);
            //util_sistema.bloquearComponentesGroupBox(gbPrincipal, true);            
            gbTipoPessoa.Enabled  = true;
            txtCNPJ.Enabled       = true;
            txtNome.Enabled       = true;
            txtFantasia.Enabled   = true;
            txtRG_IE.Enabled      = true;
            checkBoxAtivo.Enabled = true;
            mDtCadastro.Enabled   = false;
            mDtAlteracao.Enabled  = false;
        }

        private void limparCampos()
        {
            util_sistema.limparComponentesGroupBox(gbPrincipal);
            util_sistema.limparComponentesGroupBox(gbTipoPessoa);
            util_sistema.limparComponentesTabPage(tabEndereco);
            util_sistema.limparComponentesTabPage(tabContato);
            util_sistema.limparComponentesTabPage(tabDadosAdicionais);
        }

        private void tirarMascara()
        {
            util_sistema.removerMascara(txtCEP);
            util_sistema.removerMascara(txtCelular);
            util_sistema.removerMascara(txtTelefone);
        }
                
        private void adicionar()
        {
            if(controle.cpfCNPJ_Cadastrado(txtCNPJ.Text.Trim()) == true)
            {
                MessageBox.Show(util_msg.msgCPF_CNPJ_Cadastrado, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCNPJ.Focus();
                return;
            }

            try
            {
                dataAtual = DateTime.Now;    
                //envia para a base somente os dados sem a mascara
                tirarMascara();
                
                Pessoa p = new Pessoa();
                p.ativo        = true;//como é 1ª vez que esta cadastrando a pessoa por default deve ficar ativa na base
                p.tipo.Id      = int.Parse(cbTipoPessoa.SelectedValue.ToString());
                p.CPF_CNPJ     = txtCNPJ.Text;
                p.nomeCompleto = txtNome.Text.Trim();
                p.fantasia     = txtFantasia.Text.Trim();
                p.RG_IE        = txtRG_IE.Text;
                p.CEP          = txtCEP.Text;
                p.pais.Id      = int.Parse(comboBoxPais.SelectedValue.ToString());
                p.uf.Id        = int.Parse(comboBoxUF.SelectedValue.ToString());
                p.cidade.Id    = int.Parse(comboBoxCidade.SelectedValue.ToString());
                p.bairro       = txtBairro.Text.Trim();
                p.logradouro   = txtLogradouro.Text.Trim();
                p.numero       = Convert.ToInt32(txtNumero.Text);
                p.complemento  = txtComplemento.Text.Trim();
                p.telefone     = long.Parse(txtTelefone.Text);
                p.celular      = long.Parse(txtCelular.Text);
                p.contato      = txtContato.Text.Trim();
                p.email        = txtEmail.Text.Trim();
                p.dtNasc       = dtNascimento.Value;
                p.dtCadastro   = dataAtual;
                p.dtAlteracao  = dataAtual;

                if (cbCliente.Checked == true)
                    p.cliente = true;
                else
                    p.cliente = false;

                if (cbFornecedor.Checked == true)
                    p.fornecedor = true;
                else
                    p.fornecedor = false;

                if (cbTransportador.Checked == true)
                    p.transportador = true;
                else
                    p.transportador = false;

                if (cbFuncionario.Checked == true)
                    p.funcionario = true;
                else
                    p.funcionario = false;

                if (cbOutro.Checked == true)
                    p.outro = true;
                else
                    p.outro = false;

                controle = new BLL_Pessoa();
                controle.novo(p);
                MessageBox.Show(util_msg.msgSalvar, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                 MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void alterar()
        {
            try
            {
                dataAtual = DateTime.Now;
                tirarMascara();

                Pessoa p = new Pessoa();
                p.id           = Convert.ToInt32(txtID.Text);
                p.tipo.Id      = int.Parse(cbTipoPessoa.SelectedValue.ToString());
                p.CPF_CNPJ     = txtCNPJ.Text;
                p.nomeCompleto = txtNome.Text;
                p.fantasia     = txtFantasia.Text;
                p.RG_IE        = txtRG_IE.Text;
                p.CEP          = txtCEP.Text;
                p.pais.Id      = int.Parse(comboBoxPais.SelectedValue.ToString());
                p.uf.Id        = int.Parse(comboBoxUF.SelectedValue.ToString());
                p.cidade.Id    = int.Parse(comboBoxCidade.SelectedValue.ToString());
                p.bairro       = txtBairro.Text;
                p.logradouro   = txtLogradouro.Text;
                p.numero       = Convert.ToInt32(txtNumero.Text);
                p.complemento  = txtComplemento.Text;
                p.telefone     = long.Parse(txtTelefone.Text);
                p.celular      = long.Parse(txtCelular.Text);
                p.contato      = txtContato.Text;
                p.email        = txtEmail.Text;
                p.dtNasc       = dtNascimento.Value;
                p.dtAlteracao  = dataAtual;

                if (checkBoxAtivo.Checked == true)
                    p.ativo = true;
                else
                    p.ativo = false;

                if (cbCliente.Checked == true)
                    p.cliente = true;
                else
                    p.cliente = false;

                if (cbFornecedor.Checked == true)
                    p.fornecedor = true;
                else
                    p.fornecedor = false;

                if (cbTransportador.Checked == true)
                    p.transportador = true;
                else
                    p.transportador = false;

                if (cbFuncionario.Checked == true)
                    p.funcionario = true;
                else
                    p.funcionario = false;

                if (cbOutro.Checked == true)
                    p.outro = true;
                else
                    p.outro = false;

                controle = new BLL_Pessoa();
                controle.editar(p);
                MessageBox.Show(util_msg.msgAlterar, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void detalhes(Pessoa p)
        {
            try
            {
                checkBoxAtivo.Checked        = p.ativo;
                cbCliente.Checked            = p.cliente;
                cbFornecedor.Checked         = p.fornecedor;
                cbTransportador.Checked      = p.transportador;
                cbFuncionario.Checked        = p.funcionario;
                cbOutro.Checked              = p.outro;
                lblTitulo.Text               = p.nomeCompleto;
                txtID.Text                   = Convert.ToString(p.id);
                cbTipoPessoa.SelectedValue   = p.tipo.Id;
                txtCNPJ.Text                 = p.CPF_CNPJ;
                txtNome.Text                 = p.nomeCompleto;
                txtFantasia.Text             = p.fantasia;
                txtRG_IE.Text                = p.RG_IE;
                txtCEP.Text                  = p.CEP;
                comboBoxPais.SelectedValue   = p.pais.Id;
                comboBoxUF.SelectedValue     = p.uf.Id;
                comboBoxCidade.SelectedValue = p.cidade.Id;
                txtBairro.Text               = p.bairro;
                txtLogradouro.Text           = p.logradouro;
                txtNumero.Text               = Convert.ToString(p.numero);
                txtComplemento.Text          = p.complemento;
                txtTelefone.Text             = Convert.ToString(p.telefone);
                txtCelular.Text              = Convert.ToString(p.celular);
                txtContato.Text              = p.contato;
                txtEmail.Text                = p.email;
                mDtCadastro.Text             = Convert.ToString(p.dtCadastro);
                dtNascimento.Text            = Convert.ToString(p.dtNasc);
                mDtAlteracao.Text            = Convert.ToString(p.dtAlteracao);
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvar()
        {
            #region VERIFICA SE OS CAMPOS OBRIGATÓRIOS ESTÃO COMPLETOS
            if (txtNome.Text.Trim() == string.Empty)
            {
                txtNome.BackColor = Color.Gold;
                MessageBox.Show(util_msg.msgCampoObrigatorioVazio, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

            if (txtFantasia.Text.Trim() == string.Empty)
            {
                txtFantasia.Text = txtNome.Text;
                //if (cbTipoPessoa.Text == "Jurídica")
                //    txtFantasia.Text = txtNome.Text;
                //else
                //    txtFantasia.Text = "Não Informado";
            }

            if (txtRG_IE.Text.Trim() == string.Empty)
            {
                txtRG_IE.BackColor = Color.Gold;
                MessageBox.Show(util_msg.msgCampoObrigatorioVazio + "\nCaso seja uma pessoa jurídica e não possua IE informe ISENTO" +
                    "", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRG_IE.Focus();
                return;
            }

            if (!txtCEP.MaskCompleted)
            {
                tabDetalhes.SelectedTab = tabEndereco;
                txtCEP.BackColor = Color.Gold;
                MessageBox.Show(util_msg.msgCampoObrigatorioVazio, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCEP.Focus();
                return;
            }

            if (txtBairro.Text.Trim() == string.Empty)
            {
                tabDetalhes.SelectedTab = tabEndereco;
                txtBairro.BackColor = Color.Gold;
                MessageBox.Show(util_msg.msgCampoObrigatorioVazio, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBairro.Focus();
                return;
            }

            if (txtLogradouro.Text.Trim() == string.Empty)
            {
                tabDetalhes.SelectedTab = tabEndereco;
                txtLogradouro.BackColor = Color.Gold;
                MessageBox.Show(util_msg.msgCampoObrigatorioVazio, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogradouro.Focus();
                return;
            }

            if (txtNumero.Text.Trim() == string.Empty)
            {
                tabDetalhes.SelectedTab = tabEndereco;
                txtNumero.BackColor = Color.Gold;
                MessageBox.Show(util_msg.msgCampoObrigatorioVazio + "\nCaso não tenha número, informe 0", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Focus();
                return;
            }

            if (!txtTelefone.MaskCompleted)
            {
                tabDetalhes.SelectedTab = tabContato;
                txtTelefone.BackColor = Color.Gold;
                MessageBox.Show(util_msg.msgCampoObrigatorioVazio, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefone.Focus();
                return;
            }

            if (!txtCelular.MaskCompleted)
            {
                tabDetalhes.SelectedTab = tabContato;
                txtCelular.BackColor = Color.Gold;
                MessageBox.Show(util_msg.msgCampoObrigatorioVazio, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCelular.Focus();
                return;
            }

            if (txtContato.Text.Trim() == string.Empty)
            {
                //tabDetalhes.SelectedTab = tabContato;
                //txtContato.BackColor = Color.Gold;
                //MessageBox.Show(util_msg.msg_CampoObrigatorioVazio, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //txtContato.Focus();
                //return;
                txtContato.Text = "NC";
            }

            if (txtEmail.Text.Trim() == string.Empty)
            {
                tabDetalhes.SelectedTab = tabContato;
                txtEmail.BackColor = Color.Gold;
                MessageBox.Show(util_msg.msgCampoObrigatorioVazio, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            #endregion

            if (statusForm == statusForm.Novo)
                adicionar();
            else if (statusForm == statusForm.Editar)
                alterar();

            statusForm = statusForm.Detalhes;
            configForm();
        }

        #region COMBOBOX
        private void cbPais_SelectedValueChanged(object sender, EventArgs e)
        {
            carregarComboBox.estados(comboBoxUF, comboBoxPais);
        }

        private void cbUF_SelectedValueChanged(object sender, EventArgs e)
        {
            carregarComboBox.cidades(comboBoxCidade, comboBoxUF);
        }

        private void cbTipoPessoa_Leave(object sender, EventArgs e)
        {
            if (cbTipoPessoa.Text.Trim() == "")
            {
                MessageBox.Show("Selecione o Tipo de Pessoa!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbTipoPessoa.Focus();
                return;
            }
            else
            {
                configurarPessoa();
                ativarComponentes();
                cbTipoPessoa.Enabled = false;//não permite ao usuário mudar o que já está selecionado na combo
            }

        }

        private void cbCidade_Leave(object sender, EventArgs e)
        {
            if (comboBoxCidade.Text.Trim() == "")
            {
                MessageBox.Show("Selecione a Cidade!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxCidade.Focus();
                return;
            }
        }

        private void cbUF_Leave(object sender, EventArgs e)
        {
            if (comboBoxUF.Text.Trim() == "")
            {
                MessageBox.Show("Selecione o Estado!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxUF.Focus();
                return;
            }
        }

        #endregion


        private void pessoaCadastrada(string cpfCNPJ)//verifica na base se a pessoa já esta cadastrada
        {
            controle = new BLL_Pessoa();

            if(statusForm == statusForm.Novo)
            {
                if(controle.cpfCNPJ_Cadastrado(cpfCNPJ) == true)
                {
                    MessageBox.Show(util_msg.msgCPF_CNPJ_Cadastrado);
                    txtCNPJ.Focus();
                    return;
                }
            }
        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            if (txtCNPJ.Text.Trim() == string.Empty)
            {
                MessageBox.Show(util_msg.msgCPFCNPJ_Vazio);
                txtCNPJ.Focus();
                return;
            }
            else
                pessoaCadastrada(txtCNPJ.Text);        


            if (cbTipoPessoa.Text == "Jurídica")
            {
                txtCNPJ.Text = util_dados.formataCNPJ(txtCNPJ.Text);
            }
            else if(cbTipoPessoa.Text == "Física")
            {
                txtCNPJ.Text = util_dados.formataCPF(txtCNPJ.Text);
            }                   

        }
        
        private void txtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
               // MessageBox.Show(util_msg.msgCampoSomenteNumero, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show(util_msg.msgCampoSomenteNumero, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() != string.Empty)
                lblTitulo.Text = txtNome.Text;
        }

        #region BOTOES
        private void btnMaisEnderecos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(util_msg.msg_RecursoNaoImplementado, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnMaisContatos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(util_msg.msg_RecursoNaoImplementado, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if ((statusForm == statusForm.Novo) || (statusForm == statusForm.Editar))
            {
                DialogResult result = MessageBox.Show("Cancelar alterações?", util_msg.sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    this.Close();
                else
                    return;
            }
            else if (statusForm == statusForm.Detalhes)
                this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparCampos();
            statusForm = statusForm.Novo;
            configForm();
        }

        #endregion
    }
}
