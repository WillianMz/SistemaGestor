using Modelo.Estoque;
using Sistema.Estoque.Controles;
using Sistema.Estoque.Utilitario;
using System;
using System.Windows.Forms;
using Util;

namespace Sistema.Estoque.Interfaces
{
    public partial class formProdutoSubgrupo : Form
    {
        public statusForm statusForm;
        BLL_Produto controle;

        public formProdutoSubgrupo()
        {
            InitializeComponent();
            configForm();
        }

        public void configForm()
        {
            if (statusForm == statusForm.Novo)
            {
                lblTitulo.Text = "NOVO SUBGRUPO";
                carregarComboBox.grupoProduto(cboxGrupo);
            }

            if (statusForm == statusForm.Editar)
            {
                lblTitulo.Text = "EDITANDO SUBGRUPO";
                carregarComboBox.grupoProduto(cboxGrupo);
            }
        }

        public void detalhes(Subgrupo subgrupo)
        {
            try
            {
                txtCod.Text = Convert.ToString(subgrupo.Id);
                txtNome.Text = subgrupo.Nome;
                cboxGrupo.SelectedValue = subgrupo.grupo.Id;
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

            if (statusForm == statusForm.Novo)
            {
                try
                {
                    if (txtNome.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Informe o nome do subgrupo", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNome.Focus();
                        return;
                    }
                    else if(cboxGrupo.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Selecione o grupo a qual o subgrupo pertence", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboxGrupo.Focus();
                        return;
                    }

                    s = new Subgrupo();
                    s.Nome = txtNome.Text;
                    s.grupo.Id = int.Parse(cboxGrupo.SelectedValue.ToString());

                    controle.novoSubgrupo(s);

                    MessageBox.Show(util_msg.msgSalvar, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (statusForm == statusForm.Editar)
            {
                try
                {
                    s = new Subgrupo();
                    s.Id = int.Parse(txtCod.Text);
                    s.Nome = txtNome.Text;
                    s.grupo.Id = int.Parse(cboxGrupo.SelectedValue.ToString());

                    controle.editarSubgrupo(s);

                    MessageBox.Show(util_msg.msgSalvar, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }
    }
}
