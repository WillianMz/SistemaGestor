using Modelo.Config;
using System;
using System.Windows.Forms;
using Util;
using static Modelo.Config.Parametro;

namespace Sistema.Utilitario.Interfaces
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
            carregarParametros();
        }
        
        private void carregarParametros()
        {
            try
            {
                ConfigSistema config = RegEditWindows.lerDadosRegistroWindows("Gestor");
                SQL.servidor = config.dbServer;
                SQL.porta    = config.dbPort;
                SQL.banco    = config.dbBase;
                SQL.userBD   = config.dbUser;
                SQL.senhaBD  = config.dbPwd;

                carregarComboBox.empresas(cbEmpresa);
                cbEmpresa.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show(util_msg.msgErroCarregarParametro, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void carregarAplicacao()
        {
            try
            {
                //formPrincipal
            }
            catch
            {

            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            UsuarioLogado.empresa = int.Parse(cbEmpresa.SelectedValue.ToString());
            UsuarioLogado.nomeUser = txtUsuario.Text;

            Close();            
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            try
            {
                formConfigurar f = new formConfigurar();
                f.ShowDialog();
                f.Dispose();
            }
            catch
            {

            }
        }

        private void btnEsqueceuSenha_Click(object sender, EventArgs e)
        {
            MessageBox.Show(util_msg.msg_RecursoNaoImplementado, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
