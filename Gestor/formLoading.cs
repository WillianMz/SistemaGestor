﻿using System;
using System.Windows.Forms;
using Util;

namespace Gestor
{
    public partial class formLoading : Form
    {
        public formLoading()
        {
            InitializeComponent();
            StartTimer();
           // configForm();
        }

        //public void configForm()
        //{
        //    //lblSistema.Text = Parametro.nomeSoftware;
        //    //lblProgramador.Text = Parametro.versao;
        //}

        Timer timer = new Timer();
        static int Cont = 0;

        void Temporizador(object sender, EventArgs e)
        {
            Cont += 4;
           // lblProcessando.Text = "Carregando... (" + Cont + "%)";

            if(Cont >= 100)
            {
                Cont = 0;
                timer.Stop();
                ChamarLogin();        
            }
        }

        private void StartTimer()
        {
            timer.Interval = 100;
            timer.Tick += new EventHandler(Temporizador);
            timer.Start();
        }

        private void ChamarLogin()
        {
            try
            {
                formLogin form = new formLogin();
                Visible = false;
                form.ShowDialog();
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
