using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Utilitario.Interfaces
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
