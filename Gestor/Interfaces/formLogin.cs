using Modelo.Config;
using Sistema.Utilitario;
using Sistema.Utilitario.Controles;
using System;
using System.Windows.Forms;
using Util;
using static Modelo.Config.Parametro;

namespace Gestor
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

        private void verificarLogin()
        {
            try
            {
                BLL_Usuario controler = new BLL_Usuario();

                string login = txtUsuario.Text.Trim();
                string senha = txtSenha.Text.Trim();

                UsuarioLogado.empresa = int.Parse(cbEmpresa.SelectedValue.ToString());

                if (controler.verificarUsuario(login, senha) == true)
                {
                    UsuarioLogado.idUser = controler.usuario(login, senha);
                    //UsuarioLogado.nomeUser = login;
                    formPrincipal iniciar = new formPrincipal();
                    iniciar.Show();
                    this.Close();
                    Dispose();
                    return;
                }
                else
                    MessageBox.Show(util_msg.msgUser_loginNaoEncontrado, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgUser_erroNoLogin + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {           
            verificarLogin();
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
