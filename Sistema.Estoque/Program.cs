﻿using Sistema.Estoque.Interfaces;
using System;
using System.Windows.Forms;

namespace Sistema.Estoque
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formConsultaProduto());
        }
    }
}
