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
            configForm();
        }

        public void configForm()
        {
            if (statusForm == statusForm.Novo)
            {
                lblTitulo.Text = "NOVA CATEGORIA";
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
                txtCod.Text  = Convert.ToString(c.Id);
                txtNome.Text = c.Nome;
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

            if (controle.categoriaCadastrada(txtNome.Text.Trim()) == true)
            {
                MessageBox.Show("Já existe uma categoria com este nome!", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

            try
            {
                if (statusForm == statusForm.Novo)
                {
                    c = new Categoria();
                    c.Nome = txtNome.Text.Trim();

                    controle.novaCategoria(c);
                    MessageBox.Show(util_msg.msgSalvar, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (statusForm == statusForm.Editar)
                {
                    c = new Categoria();
                    c.Id = int.Parse(txtCod.Text.Trim());
                    c.Nome = txtNome.Text;

                    controle.editarCategoria(c);
                    MessageBox.Show(util_msg.msgSalvar, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
                Dispose();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }
    }
}
