using System;
using System.Security.Cryptography;
using System.Text;

namespace Util
{
    public static class util_dados
    {
        /// <summary>
        /// Configura Numero Decimal Quantidade de Casas Decimais
        /// <para>0 - 0.000</para>
        /// <para>1 - 0.000,0</para>
        /// <para>2 - 0.000,00</para>
        /// <para>3 - 0.000,000</para>
        /// <para>4 - 0.000,0000</para>
        /// 
        /// <para>Para DataGrid</para>
        /// <para>10 - 0000</para>
        /// <para>11 - 0000,0</para>
        /// <para>12 - 0000,00</para>
        /// <para>13 - 0000,000</para>
        /// <para>14 - 0000,0000</para>
        /// 
        /// <para>Para NFe</para>
        /// <para>20 - 0000</para>
        /// <para>21 - 0000.0</para>
        /// <para>22 - 0000.00</para>
        /// <para>23 - 0000.000</para>
        /// <para>24 - 0000.0000</para>
        /// 
        /// <para>Arquivo Remessa e Sintegra</para>
        /// <para>32 - 2 casa decimal sem ponto/virgula</para>
        /// <para>33 - 3 casa decimal sem ponto/virgula</para>
        /// </summary>
        public static string configurarNumeroDecimal(object Valor, int Dec)
        {
            if (Valor.ToString().Trim() == string.Empty)
                Valor = 0;

            double Numero = 0;
            if (!double.TryParse(Valor.ToString(), out Numero))
                Valor = 0;

            string Mascara = null;
            Mascara = "";
            switch (Dec)
            {
                case 0:
                    Mascara = "{0:N0}";
                    break;
                case 1:
                    Mascara = "{0:N1}";
                    break;
                case 2:
                    Mascara = "{0:N2}";
                    break;
                case 3:
                    Mascara = "{0:N3}";
                    break;
                case 4:
                    Mascara = "{0:N4}";
                    break;
                case 10:
                    Mascara = "{0:F0}";
                    break;
                case 11:
                    Mascara = "{0:F1}";
                    break;
                case 12:
                    Mascara = "{0:F2}";
                    break;
                case 13:
                    Mascara = "{0:F3}";
                    break;
                case 14:
                    Mascara = "{0:F4}";
                    break;
                case 20:
                    Mascara = "{0:F0}";
                    break;
                case 21:
                    Mascara = "{0:F1}";
                    break;
                case 22:
                    Mascara = "{0:F2}";
                    break;
                case 23:
                    Mascara = "{0:F3}";
                    break;
                case 24:
                    Mascara = "{0:F4}";
                    break;
                case 32:
                    Mascara = "{0:N2}";
                    break;
                case 33:
                    Mascara = "{0:N3}";
                    break;
                case 35:
                    Mascara = "{0:N5}";
                    break;
            }
            if (Dec == 10 ||
                Dec == 11 ||
                Dec == 12 ||
                Dec == 13 ||
                Dec == 14)
                return String.Format(Mascara, Convert.ToDouble(Valor)).Replace(",", ".");

            if (Dec == 32 || Dec == 33)
                return String.Format(Mascara, Convert.ToDouble(Valor)).Replace(",", "").Replace(".", "");

            return String.Format(Mascara, Convert.ToDouble(Valor));
        }

        public static double verificaDouble(string str)
        {
            try
            {
                double num = 0;
                if (str == null || str == "" || !double.TryParse(str, out num))
                    return 0;

                return Convert.ToDouble(str);
            }
            catch(Exception)
            {
                return 0;
            }
        }


        #region FORMATAÇÃO DE CPF/CNPJ

        /// <summary>
        /// Formatar uma string CNPJ
        /// </summary>
        /// <param name="cnpj">string CNPJ sem formatacao</param>
        /// <returns>string CNPJ formatada</returns>
        /// <example>Recebe '99999999999999'. Devolve '99.999.999/9999-99</example>
        public static string formataCNPJ(string cnpj)
        {
            return Convert.ToUInt64(cnpj).ToString(@"00\.000\.00\/0000\-00");
        }

        /// <summary>
        /// Formata uma string CPF
        /// </summary>
        /// <param name="cpf">string CPF sem formatacao</param>
        /// <returns>string CPF formatada</returns>
        /// <example>Recebe '99999999999'. Devolve '999.999.999-99'</example>
        public static string formataCPF(string cpf)
        {
            return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        }

        /// <summary>
        /// Retira a formatacao de uma string CPF/CNPJ
        /// </summary>
        /// <param name="codigo">string CPF/CNPJ formatada</param>
        /// <returns>string sem formatacao</returns>
        /// <example>Recebe '99.999.999/9999-99'. Devolve '99999999999999'</example>
        public static string tirarFormatacaoCPF_CNPJ(string codigo)
        {
            return codigo.Replace(".", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty);
        }

        #endregion


        #region SEGURANCA E CRIPTOGRAFIA

        private static string chave = "7e5d3f3t7y";

        private static byte[] pegarChave(string password)
        {
            string pwd = null;

            if (Encoding.UTF8.GetByteCount(password) < 24)
                pwd = password.PadRight(24, ' ');
            else
                pwd = password.Substring(0, 24);

            return Encoding.UTF8.GetBytes(pwd);
        }

        public static string criptografar(string str)
        {
            try
            {
                TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
                des.Mode = CipherMode.ECB;
                des.Key = pegarChave(chave);
                des.Padding = PaddingMode.PKCS7;
                ICryptoTransform DESEncrypt = des.CreateEncryptor();
                Byte[] buffer = ASCIIEncoding.ASCII.GetBytes(str);

                return Convert.ToBase64String(DESEncrypt.TransformFinalBlock(buffer, 0, buffer.Length));
            }
            catch (Exception ex)
            {
                return "Erro ao criptografar! Detalhes: " + ex.Message;
            }
        }

        public static string descriptografar(string str)
        {
            try
            {
                TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
                des.Mode = CipherMode.ECB;
                des.Key = pegarChave(chave);
                des.Padding = PaddingMode.PKCS7;
                ICryptoTransform DESEncrypt = des.CreateDecryptor();
                Byte[] buffer = Convert.FromBase64String(str);

                return Encoding.UTF8.GetString(DESEncrypt.TransformFinalBlock(buffer, 0, buffer.Length));
            }
            catch (Exception ex)
            {
                return "Erro ao descriptograr! Detalhes: " + ex.Message;
            }
        }

        #endregion

    }
}
