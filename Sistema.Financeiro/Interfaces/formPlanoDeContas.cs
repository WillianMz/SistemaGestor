using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Financeiro;
using Sistema.Financeiro.Controles;
using Util;

namespace Sistema.Financeiro.Interfaces
{
    public partial class formPlanoDeContas : Form
    {

        BLL_Financeiro controler;

        public formPlanoDeContas()
        {
            InitializeComponent();
        }





        private void formPlanoDeContas_Load(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            txtNome.Focus();
        }
        private void novoPlanoContas()
        {
            btnNovo.Enabled = false;
            btnPesquisar.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void gravarPlanoContas()
        {
            controler = new BLL_Financeiro();

            try
            {
                PlanoDeContas pc = new PlanoDeContas();
                pc.nome = txtNome.Text;
                pc.descricao = txtDescricao.Text;
                pc.entrada = ckCredito.Checked;
                pc.saida = ckDebito.Checked;
                pc.ativo = true;

                controler.novoPlanoContas(pc);
                MessageBox.Show(util_msg.msgSalvar, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtDescricao.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void atualizarGrid(List<PlanoDeContas> ps)
        {
            string natureza;
            dgvPlanoContas.Rows.Clear();
            foreach (PlanoDeContas pc in ps)
            {
                if (pc.entrada == true)
                {
                    natureza = "CRÉDITO";
                }
                else
                {
                    natureza = "DÉBITO";
                }
                dgvPlanoContas.Rows.Add(pc.id,pc.nome, pc.descricao, natureza);
            }
            util_sistema.resultadoPesquisa(dgvPlanoContas, lblMensagem);
        }




        //-----------------------------------------------------

        private void btnNovo_Click(object sender, EventArgs e)
        {
            novoPlanoContas();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            gravarPlanoContas();
        }

    }
}