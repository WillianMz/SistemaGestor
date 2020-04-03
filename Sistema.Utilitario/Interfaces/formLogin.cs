
using Modelo;
using System;
using System.Windows.Forms;
using Util;
using static Util.util_database;

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
                ParamentroDoSistema p = util_sistema.lerDadosRegistroWindows("Gestor");
                SQL.servidor = p.dbServer;
                SQL.porta    = p.dbPort;
                SQL.banco    = p.dbBase;
                SQL.userBD   = p.dbUser;
                SQL.senhaBD  = p.dbPwd;
                
                carregarComboBox.empresas(cbEmpresa);
                cbEmpresa.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                throw ex;//mudar isso aqui
            }
        }


        private void btnLogar_Click(object sender, EventArgs e)
        {
            this.Close();            
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
