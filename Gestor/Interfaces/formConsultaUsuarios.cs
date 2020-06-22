using System;
using System.Windows.Forms;

namespace Gestor
{
    public partial class formConsultaUsuarios : Form
    {
        public formConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void menuAdicionar_Click(object sender, EventArgs e)
        {
            formUsuario fUser = new formUsuario();
            fUser.ShowDialog();
            fUser.Dispose();
        }
    }
}
