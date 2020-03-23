
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
        }


        private void btnLogar_Click(object sender, EventArgs e)
        {
            this.Close();

            //TESTE - RETIRAR DEPOIS
            ParamentroDoSistema p = util_sistema.lerDadosRegistroWindows("Gestor");
            SQL.servidor = p.dbServer;
            SQL.porta    = p.dbPort;
            SQL.banco    = p.dbBase;
            SQL.userBD   = p.dbUser;
            SQL.senhaBD  = p.dbPwd;
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
    }
}
