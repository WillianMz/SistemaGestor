using Controller;
using Modelo.Estoque;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Util;

namespace Interfaces.Modulos.Estoque
{
    public partial class formProdutoGrupo : Form
    {
        public statusForm statusForm;
        BLL_Produto controle;

        public formProdutoGrupo()
        {
            InitializeComponent();
            configForm();
        }
        
        public void configForm()
        {
            if (statusForm == statusForm.Novo)
            {
                lblTitulo.Text = "NOVO GRUPO";
            }

            if (statusForm == statusForm.Editar)
            {
                lblTitulo.Text = "EDITANDO GRUPO";
            }
        }

        public void detalhes(Grupo g)
        {
            try
            {
                txtCod.Text = Convert.ToString(g.Id);
                txtNome.Text = g.Nome;
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

            if(statusForm == statusForm.Novo)
            {
                try
                {
                    if (txtNome.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Informe o nome do grupo", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNome.Focus();
                        return;
                    }

                    g = new Grupo();
                    g.Nome = txtNome.Text;
                    controle.novoGrupo(g);
                    
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
                    g = new Grupo();
                    g.Id = int.Parse(txtCod.Text);
                    g.Nome = txtNome.Text;
                    controle.editarGrupo(g);

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
