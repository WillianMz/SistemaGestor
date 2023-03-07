using Modelo.Config;
using Sistema.Utilitario.Controles;
using System;
using System.Windows.Forms;
using Util;

namespace Gestor
{
    public partial class formConfigurar : Form
    {
        BLL_Sistema controle;

        public formConfigurar()
        {
            InitializeComponent();
            //lerDados();
            configForm();
        }

        public void configForm()
        {
            lblTitulo.Text = "Configurações do Software";
            btnSalvarbd.Enabled = false;
            btnAlterarbd.Enabled = true;
        }

        private void salvarConfig()
        {
            try
            {
                ConfigSistema config = new ConfigSistema
                {
                    dbServer = txtBDServer.Text.Trim(),
                    dbPort = Convert.ToInt32(txtBDPort.Text.Trim()),
                    dbUser = txtBDUser.Text.Trim(),
                    dbBase = txtBDBanco.Text.Trim(),
                    dbPwd = txtBDSenha.Text.Trim(),
                    lembrarSenha = true,
                    empresaPadrao = 2
                };

                controle = new BLL_Sistema();
                controle.salvarParametrosDeBaseDeDados("Gestor", config);
            }
            catch
            {

            }
        }

        private void lerDados()
        {
            controle = new BLL_Sistema();
            ConfigSistema cf = controle.parametrosBaseDeDados("Gestor");
            txtBDServer.Text = cf.dbServer;
            txtBDPort.Text   = Convert.ToString(cf.dbPort);
            txtBDBanco.Text  = cf.dbBase;
            txtBDUser.Text   = cf.dbUser;
            txtBDSenha.Text  = cf.dbPwd;
        }
        
        private void btnSalvarbd_Click(object sender, EventArgs e)
        {
            salvarConfig();
            
            util_sistema.bloquearComponentesTabPage(tabSuporte, false);
            btnSalvarbd.Enabled = false;
            btnAlterarbd.Enabled = true;
            lblMensagem.Text = "Dados alterados com sucesso!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            util_sistema.bloquearComponentesTabPage(tabSuporte, true);
            btnSalvarbd.Enabled = true;
            btnAlterarbd.Enabled = false;
            lblMensagem.Text = "Alterando dados";
        }

    }
}
