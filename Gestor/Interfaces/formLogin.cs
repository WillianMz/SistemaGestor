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
                ConfigSistema config = RegEditWindows.lerDadosDeAcessoBancoDeDados("Gestor");
                SQL.servidor = config.dbServer;
                SQL.porta    = config.dbPort;
                SQL.banco    = config.dbBase;
                SQL.userBD   = config.dbUser;
                SQL.senhaBD  = config.dbPwd;

                carregarComboBox.empresas(cbEmpresa);

                ConfigSistema cf = RegEditWindows.lerDadosDeLogin("Gestor");
                ckboxLembrarSenha.Checked = cf.lembrarSenha;
                txtUsuario.Text = cf.usuario;
                txtSenha.Text = cf.senha;
                cbEmpresa.SelectedValue = cf.empresaPadrao;

                //cbEmpresa.SelectedIndex = 0;
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
                //criptografa a senha informada para depois comparar com a da base de dados
                string senha = util_dados.criptografar(txtSenha.Text.Trim());

                UsuarioLogado.empresa = int.Parse(cbEmpresa.SelectedValue.ToString());

                if (controler.verificarUsuario(login, senha) == true)
                {
                    lembrarUsuario();
                    UsuarioLogado.idUser = controler.usuario(login, senha);
                    formPrincipal iniciar = new formPrincipal();
                    iniciar.Show();
                    Close();
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

        private void lembrarUsuario()
        {
            try
            {
                ConfigSistema config;

                if (ckboxLembrarSenha.Checked == true)
                {
                    config = new ConfigSistema
                    {
                        lembrarSenha  = true,
                        empresaPadrao = int.Parse(cbEmpresa.SelectedValue.ToString()),
                        usuario       = txtUsuario.Text,
                        senha         = txtSenha.Text
                    };                    
                }
                else
                {
                    config = new ConfigSistema
                    {
                        lembrarSenha  = false,
                        empresaPadrao = 0,
                        usuario       = "",
                        senha         = ""
                    };
                }

                BLL_Sistema controle = new BLL_Sistema();
                controle.salvarDadosDeLogin("Gestor", config);
            }
            catch
            {

            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {           
            verificarLogin();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            formConfigurar f = new formConfigurar();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnEsqueceuSenha_Click(object sender, EventArgs e)
        {
            MessageBox.Show(util_msg.msg_RecursoNaoImplementado, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
