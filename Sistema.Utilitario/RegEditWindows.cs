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
                #region NAO ESTA FUNCIONANDO
                //RegistryKey regkey = Registry.CurrentUser.OpenSubKey("Software", true); //cria a referencia para a chave de registro
                //ParamentroDoSistema reg = new ParamentroDoSistema();
                //regkey = regkey.OpenSubKey("SistemaGestor");

                //if (regkey.OpenSubKey("SistemaGestor") != null)
                //{
                //    if (reg.dbServer != string.Empty)
                //        reg.dbServer = util_dados.descriptografar(regkey.OpenSubKey(software, true).GetValue("dbServer").ToString());


                //    //if (reg.dbPort != 0)
                //        reg.dbPort = Convert.ToInt32(util_dados.descriptografar(regkey.OpenSubKey(software, true).GetValue("dbPort").ToString()));

                //    if (reg.dbBase != string.Empty)
                //        reg.dbBase = util_dados.descriptografar(regkey.OpenSubKey(software, true).GetValue("dbBase").ToString());

                //   if (reg.dbUser != string.Empty)
                //        reg.dbUser = util_dados.descriptografar(regkey.OpenSubKey(software, true).GetValue("dbUser").ToString());

                //    if (reg.dbPwd != string.Empty)
                //        reg.dbPwd = util_dados.descriptografar(regkey.OpenSubKey(software, true).GetValue("dbPWD").ToString());

                //    //if (reg.lembrarSenha ? true : false)
                //    //    reg.lembrarSenha = Convert.ToBoolean(util_dados.descriptografar(regkey.OpenSubKey(software, true).GetValue("lembrarSenha").ToString()));

                //    //if (reg.empresaPadrao != 0)
                //    //    reg.empresaPadrao = Convert.ToInt32(util_dados.descriptografar(regkey.OpenSubKey(software, true).GetValue("empresaPadrao").ToString()));
                //}
                //return reg;
                #endregion

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
