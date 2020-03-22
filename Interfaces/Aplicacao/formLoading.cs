using Interfaces.Usuarios;
using System;
using System.Windows.Forms;
using Util;

namespace Interfaces.Aplicacao
{
    public partial class formLoading : Form
    {
        public formLoading()
        {
            InitializeComponent();
            startTime();
        }

        Timer timer = new Timer();
        static int Cont = 0;

        void temporizador(object sender, EventArgs e)
        {
            Cont += 2;
            lblProcessando.Text = "Carregando... (" + Cont + "%)";

            if(Cont >= 100)
            {
                Cont = 0;
                timer.Stop();
                //this.Close();
                chamarLogin();        
            }
        }

        private void startTime()
        {
            timer.Interval = 100;
            timer.Tick += new EventHandler(temporizador);
            timer.Start();
        }

        private void chamarLogin()
        {
            try
            {
                formLogin form = new formLogin();
                this.Visible = false;
                form.ShowDialog();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
