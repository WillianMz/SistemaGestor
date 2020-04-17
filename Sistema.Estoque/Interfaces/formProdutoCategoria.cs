using Modelo.Estoque;
using Sistema.Estoque.Controles;
using System;
using System.Windows.Forms;
using Util;

namespace Sistema.Estoque.Interfaces
{
    public partial class formProdutoCategoria : Form
    {
        public statusForm statusForm;
        BLL_Produto controle;

        public formProdutoCategoria()
        {
            InitializeComponent();
        }

        public void configForm()
        {
            if (statusForm == statusForm.Novo)
            {
                lblTitulo.Text = "NOVA CATEGORIA";
                chboxAtivo.Checked = true;
            }

            if (statusForm == statusForm.Editar)
            {
                lblTitulo.Text = "EDITANDO CATEGORIA";
            }
        }

        public void detalhes(Categoria c)
        {
            try
            {
                txtCod.Text        = Convert.ToString(c.Id);
                txtNome.Text       = c.nome;
                chboxAtivo.Checked = c.ativo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvar()
        {
            controle = new BLL_Produto();
            Categoria c;

            if (txtNome.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Informe o nome da categoria", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }            

            try
            {
                if (statusForm == statusForm.Novo)
                {
                    if (controle.categoriaCadastrada(txtNome.Text.Trim()) == true)
                    {
                        MessageBox.Show("Já existe uma Categoria com este nome!", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNome.Focus();
                        return;
                    }

                    c = new Categoria
                    {
                        nome = txtNome.Text.Trim()
                    };
                    if (chboxAtivo.Checked)
                        c.ativo = true;
                    else
                        c.ativo = false;

                    controle.gravarCategoria(c);
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
                    c = new Categoria
                    {
                        Id = int.Parse(txtCod.Text.Trim()),
                        nome = txtNome.Text
                    };
                    if (chboxAtivo.Checked)
                        c.ativo = true;
                    else
                        c.ativo = false;

                    controle.gravarCategoria(c);
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
