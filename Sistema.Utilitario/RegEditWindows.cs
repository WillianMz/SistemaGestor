using Microsoft.Win32;
using System;
using System.Windows.Forms;
using Util;

namespace Sistema.Utilitario
{
    public class RegEditWindows
    {
        #region GRAVAR DADOS NO REGISTRO DO WINDOWS

        public static void gravarDadosRegistroWindows(string software, ConfigSistema config)
        {
            try
            {
                RegistryKey regkey = Registry.CurrentUser.OpenSubKey("Software", true); //cria a referencia para a chave de registro

                regkey = regkey.CreateSubKey("SistemaGestor"); //cria subchave c/nome do desenvolvedor
                //regkey.DeleteSubKey(software);
                regkey = regkey.CreateSubKey(software);//cria outra subchave com dados para o software

                //dados do banco de dados
                regkey.SetValue("dbServer", util_dados.criptografar(config.dbServer));
                regkey.SetValue("dbPort",   util_dados.criptografar(Convert.ToString(config.dbPort)));
                regkey.SetValue("dbBase",   util_dados.criptografar(config.dbBase));
                regkey.SetValue("dbUser",   util_dados.criptografar(config.dbUser));
                regkey.SetValue("dbPWD",    util_dados.criptografar(config.dbPwd));

                //dados referentes a login
                regkey.SetValue("lembrarSenha",  util_dados.criptografar(Convert.ToString(config.lembrarSenha)));
                //regkey.SetValue("user",          util_dados.criptografar(config.usuario));
                //regkey.SetValue("userPass",      util_dados.criptografar(config.senha));
                regkey.SetValue("empresaPadrao", util_dados.criptografar(Convert.ToString(config.empresaPadrao)));

                regkey.Close();

                MessageBox.Show(util_msg.msgSalvar + "\n As alterações terão efeitos após reiniciar a aplicação!", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static ConfigSistema lerDadosRegistroWindows(string software)
        {
            try
            {
                RegistryKey regkey = Registry.CurrentUser.OpenSubKey("Software", true); //cria a referencia para a chave de registro
                regkey = regkey.OpenSubKey("SistemaGestor");

                ConfigSistema config = new ConfigSistema
                {
                    dbServer      = util_dados.descriptografar(regkey.OpenSubKey(software, true).GetValue("dbServer").ToString()),
                    dbPort        = Convert.ToInt32(util_dados.descriptografar(regkey.OpenSubKey(software, true).GetValue("dbPort").ToString())),
                    dbBase        = util_dados.descriptografar(regkey.OpenSubKey(software, true).GetValue("dbBase").ToString()),
                    dbUser        = util_dados.descriptografar(regkey.OpenSubKey(software, true).GetValue("dbUser").ToString()),
                    dbPwd         = util_dados.descriptografar(regkey.OpenSubKey(software, true).GetValue("dbPWD").ToString()),
                    lembrarSenha  = Convert.ToBoolean(util_dados.descriptografar(regkey.OpenSubKey(software, true).GetValue("lembrarSenha").ToString())),
                    empresaPadrao = Convert.ToInt32(util_dados.descriptografar(regkey.OpenSubKey(software, true).GetValue("empresaPadrao").ToString()))
                };
                return config;
            }
            catch
            {
                return null;
            }
        }

        #endregion
    }
}
