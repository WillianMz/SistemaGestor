using Modelo.Estoque;
using Sistema.Estoque.Controles;
using System;
using System.Windows.Forms;
using Util;

namespace Sistema.Estoque.Interfaces
{
    public partial class formProdutoGrupo : Form
    {
        public statusForm statusForm;
        BLL_Produto controle;
        int idCategoria;

        public formProdutoGrupo()
        {
            InitializeComponent();
        }
        
        public void configForm(int categoriaID)
        {
            if (statusForm == statusForm.Novo)
            {
                lblTitulo.Text = "NOVO GRUPO";
                chboxAtivo.Checked = true;
                idCategoria = categoriaID;
            }

            if (statusForm == statusForm.Editar)
            {
                lblTitulo.Text = "EDITANDO GRUPO";
                idCategoria = categoriaID;
            }
        }

        public void detalhes(Grupo g)
        {
            try
            {
                txtCod.Text  = Convert.ToString(g.Id);
                txtNome.Text = g.nome;
                chboxAtivo.Checked = g.ativo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvar()
        {
            controle = new BLL_Produto();
            Grupo g;

            if (txtNome.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Informe o nome do grupo", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

            try
            {
                if (statusForm == statusForm.Novo)
                {
                    if (controle.grupoCadastrado(txtNome.Text.Trim()) == true)
                    {
                        MessageBox.Show("Já existe um Grupo com este nome!", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNome.Focus();
                        return;
                    }

                    g = new Grupo();
                    g.nome = txtNome.Text;
                    g.categ.Id = idCategoria;

                    if (chboxAtivo.Checked)
                        g.ativo = true;
                    else
                        g.ativo = false;

                    controle.gravarGrupo(g);
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
                    g = new Grupo();
                    g.Id = int.Parse(txtCod.Text);
                    g.nome = txtNome.Text;
                    g.categ.Id = idCategoria;

                    if (chboxAtivo.Checked)
                        g.ativo = true;
                    else
                        g.ativo = false;

                    controle.gravarGrupo(g);
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
