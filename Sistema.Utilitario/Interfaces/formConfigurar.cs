using Modelo;
using Sistema.Utilitario.Controles;
using System;
using System.Windows.Forms;
using Util;

namespace Sistema.Utilitario.Interfaces
{
    public partial class formConfigurar : Form
    {
        BLL_Sistema controle;

        public formConfigurar()
        {
            InitializeComponent();
            lerDados();
            configForm();
        }

        public void configForm()
        {
            lblTitulo.Text = "Configurações do Software";
            util_sistema.bloquearComponentesTabPage(tabDatabase, false);
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
        }

        private void salvarConfig()
        {
            try
            {
                ParamentroDoSistema p = new ParamentroDoSistema
                {
                    dbServer = txtBDServer.Text.Trim(),
                    dbPort = Convert.ToInt32(txtBDPort.Text.Trim()),
                    dbUser = txtBDUser.Text.Trim(),
                    dbBase = txtBDBanco.Text.Trim(),
                    dbPwd = txtBDSenha.Text.Trim()
                };

                controle = new BLL_Sistema();
                controle.salvarParamentros("Gestor", p);
            }
            catch
            {

            }
        }

        private void lerDados()
        {
            controle = new BLL_Sistema();
            ParamentroDoSistema ps = controle.getParamentros("Gestor");
            txtBDServer.Text = ps.dbServer;
            txtBDPort.Text   = Convert.ToString(ps.dbPort);
            txtBDBanco.Text  = ps.dbBase;
            txtBDUser.Text   = ps.dbUser;
            txtBDSenha.Text  = ps.dbPwd;
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvarConfig();
            
            util_sistema.bloquearComponentesTabPage(tabDatabase, false);
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            lblMensagem.Text = "Dados alterados com sucesso!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            util_sistema.bloquearComponentesTabPage(tabDatabase, true);
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            lblMensagem.Text = "Alterando dados";
        }
    }
}
