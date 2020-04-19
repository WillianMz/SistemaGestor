using Modelo.Estoque;
using Sistema.Estoque.Controles;
using System;
using System.Windows.Forms;
using Util;

namespace Sistema.Estoque.Interfaces
{
    public partial class formProdutoSubgrupo : Form
    {
        public statusForm statusForm;
        BLL_Produto controle;
        int idGrupo;

        public formProdutoSubgrupo()
        {
            InitializeComponent();
        }

        public void configForm(int grupoID)
        {
            if (statusForm == statusForm.Novo)
            {
                lblTitulo.Text = "NOVO SUBGRUPO";
                chboxAtivo.Checked = true;
                idGrupo = grupoID;
            }

            if (statusForm == statusForm.Editar)
            {
                lblTitulo.Text = "EDITANDO SUBGRUPO";
                idGrupo = grupoID;
            }
        }

        public void detalhes(Subgrupo s)
        {
            try
            {
                txtCod.Text = Convert.ToString(s.Id);
                txtNome.Text = s.nome;
                chboxAtivo.Checked = s.ativo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvar()
        {
            controle = new BLL_Produto();
            Subgrupo s;

            if (txtNome.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Informe o nome do Subgrupo", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

            try
            {
                if (statusForm == statusForm.Novo)
                {
                    if (controle.subgrupoCadastrado(txtNome.Text.Trim()) == true)
                    {
                        MessageBox.Show("Já existe um Subgrupo com este nome!", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNome.Focus();
                        return;
                    }

                    s = new Subgrupo();
                    s.nome = txtNome.Text;
                    s.grupo.Id = idGrupo;

                    if (chboxAtivo.Checked)
                        s.ativo = true;
                    else
                        s.ativo = false;

                    controle.gravarSubgrupo(s);
                    MessageBox.Show(util_msg.msgSalvar, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (statusForm == statusForm.Editar)
                {
                    s = new Subgrupo();
                    s.Id = int.Parse(txtCod.Text);
                    s.nome = txtNome.Text;
                    s.grupo.Id = idGrupo;

                    if (chboxAtivo.Checked)
                        s.ativo = true;
                    else
                        s.ativo = false;

                    controle.gravarSubgrupo(s);
                    MessageBox.Show(util_msg.msgSalvar, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }
    }
}
