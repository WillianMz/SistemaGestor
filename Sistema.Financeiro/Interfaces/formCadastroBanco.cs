using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;
using Modelo.Financeiro;
using Sistema.Financeiro.Controles;

namespace Sistema.Financeiro.Interfaces
{
    public partial class formCadastroBanco : Form
    {
        private int empresaCodigo = 1;
        BLL_Financeiro controle;
        public formCadastroBanco()
        {
            InitializeComponent();
        }

        #region ROTINAS
        private void adicionar()
        {
            try
            {
                Banco b = new Banco();
                b.ativo = ckAtivo.Checked;
                b.nome = txtNome.Text;
                b.codigoBanco = Convert.ToInt32(txtCodBanco.Text);
                b.agencia = txtAgencia.Text;
                b.conta = txtConta.Text;
                b.idEmpresa = empresaCodigo;

                controle = new BLL_Financeiro();
                controle.novoBanco(b);

                lblResultado.Text = "Adicionado com sucesso!";

            }catch(Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void novo()
        {
            if (txtNome.Text == "")
            {
                txtCodigo.Enabled = true;
                txtCodBanco.Enabled = true;
                txtAgencia.Enabled = true;
                txtConta.Enabled = true;
                btnNovo.Enabled = false;
                btnEditar.Enabled = false;
                btnSalvar.Enabled = true;
                txtNome.Focus();
            }
            else
            {
                txtNome.Text = "";
                txtCodigo.Enabled = true;
                txtCodBanco.Enabled = true;
                txtAgencia.Enabled = true;
                txtConta.Enabled = true;
                btnNovo.Enabled = false;
                btnEditar.Enabled = false;
                btnSalvar.Enabled = true;
                txtNome.Focus();
            }
        }
        private void salvar()
        {
            if (txtNome.Text.Trim() == string.Empty)
            {
                txtNome.BackColor = Color.Gold;
                MessageBox.Show(util_msg.msgCampoObrigatorioVazio, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }
            if (txtCodBanco.Text.Trim() == string.Empty)
            {
                txtCodBanco.BackColor = Color.Gold;
                MessageBox.Show(util_msg.msgCampoObrigatorioVazio, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodBanco.Focus();
                return;
            }
            
            adicionar();

        }

        private void atualizarGrid(List<Banco> banc)
        {
            dbGridListaBanco.Rows.Clear();
            foreach (Banco b in banc)
            {
                dbGridListaBanco.Rows.Add(b.id, b.codigoBanco, b.nome, b.agencia, b.conta);
            }
            util_sistema.resultadoPesquisa(dbGridListaBanco, lblResultado);
        }

        private void pesquisarBancos(bool ativo)
        {
            controle = new BLL_Financeiro();
            List<Banco> bancos = controle.filtrarBancos(txtNome.Text, ativo);
            atualizarGrid(bancos);
        }


        #endregion



        #region BUTTONS


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        #endregion

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            novo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuListar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtNome.Text != "")
                        pesquisarBancos(true);
                    else
                    {
                        lblResultado.Text = util_msg.msgFiltroPesquisaVazio;
                        txtNome.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            util_sistema.keyPress(sender, e);
        }
    }
}
