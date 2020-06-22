using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor
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
            Inicializar();
        }

        private static void Inicializar()
        {
            formLoading formLoad = new formLoading();

            try
            {
                Application.Run(formLoad);
                Application.Run(new formPrincipal());
            }
            catch (Exception)
            {
            }
            finally
            {
                formLoad.Dispose();
            }
        }
    }
}
