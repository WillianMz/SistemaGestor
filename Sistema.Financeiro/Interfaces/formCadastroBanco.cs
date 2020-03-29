using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Financeiro.Interfaces
{
    public partial class formCadastroBanco : Form
    {
        public formCadastroBanco()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtCodigo.Enabled = true;
                txtCodBanco.Enabled = true;
                txtAgencia.Enabled = true;
                txtConta.Enabled = true;
                btnNovo.Enabled = false;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                btnPesquisar.Enabled = false;
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
                btnExcluir.Enabled = false;
                btnPesquisar.Enabled = false;
                txtNome.Focus();
            }
        }
    }
}
