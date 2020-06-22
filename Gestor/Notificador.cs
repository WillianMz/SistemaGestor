using CustomAlertBoxDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor
{
    public class Notificador
    {
        //exibe mensagens de notificação para o usuário
        public static void notificacao(string mensagem, Form_Alert.enmType tipo)
        {
            Form_Alert f = new Form_Alert
            {
                ShowInTaskbar = false,
                TopMost = true
            };

            f.showAlert(mensagem, tipo);
        }
    }
}
