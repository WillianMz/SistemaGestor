using System;
using System.Security.Cryptography;
using System.Text;

namespace Util
{
    public static class util_dados
    {
        public static bool Verifica_CPF_CNPJ(string str)
        {
            try
            {
                if (str.Replace(".", "").Replace("/", "").Replace("-", "").Length == 11)
                {
                    string valor = str.Replace(".", "").Replace("-", "");
                    if (valor.Length != 11)
                        return false;
                    bool igual = true;
                    for (int i = 1; i < 11 && igual; i++)
                        if (valor[i] != valor[0])
                            igual = false;
                    if (igual || valor == "12345678909")
                        return false;
                    int[] numeros = new int[11];
                    for (int i = 0; i < 11; i++)
                        numeros[i] = int.Parse(valor[i].ToString());
                    int soma = 0;
                    for (int i = 0; i < 9; i++)
                        soma += (10 - i) * numeros[i];
                    int resultado = soma % 11;
                    if (resultado == 1 || resultado == 0)
                    {
                        if (numeros[9] != 0)
                            return false;
                    }
                    else if (numeros[9] != 11 - resultado)
                        return false;
                    soma = 0;
                    for (int i = 0; i < 10; i++)
                        soma += (11 - i) * numeros[i];
                    resultado = soma % 11;
                    if (resultado == 1 || resultado == 0)
                    {
                        if (numeros[10] != 0)
                            return false;
                    }
                    else
                        if (numeros[10] != 11 - resultado)
                        return false;
                    return true;
                }
                else
                {
                    string CNPJ = str.Replace(".", "").Replace("/", "").Replace("-", "");
                    int[] digitos, soma, resultado;
                    int nrDig;
                    string ftmt;
                    bool[] CNPJOk;
                    ftmt = "6543298765432";
                    digitos = new int[14];
                    soma = new int[2];
                    soma[0] = 0;
                    soma[1] = 0;
                    resultado = new int[2];
                    resultado[0] = 0;
                    resultado[1] = 0;
                    CNPJOk = new bool[2];
                    CNPJOk[0] = false;
                    CNPJOk[1] = false;
                    try
                    {
                        for (nrDig = 0; nrDig < 14; nrDig++)
                        {
                            digitos[nrDig] = int.Parse(CNPJ.Substring(nrDig, 1));
                            if (nrDig <= 11)
                                soma[0] += (digitos[nrDig] * int.Parse(ftmt.Substring(nrDig + 1, 1)));
                            if (nrDig <= 12)
                                soma[1] += (digitos[nrDig] * int.Parse(ftmt.Substring(nrDig, 1)));
                        }
                        for (nrDig = 0; nrDig < 2; nrDig++)
                        {
                            resultado[nrDig] = (soma[nrDig] % 11);
                            if ((resultado[nrDig] == 0) || (resultado[nrDig] == 1))
                                CNPJOk[nrDig] = (digitos[12 + nrDig] == 0);
                            else
                                CNPJOk[nrDig] = (digitos[12 + nrDig] == (11 - resultado[nrDig]));
                        }
                        return (CNPJOk[0] && CNPJOk[1]);
                    }
                    catch
                    {
                        return false;
                    }
                }

            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string formatarCPF_CNPJ(string strCPF_CNPJ, int Tipo)
        {
            try
            {
                switch (Tipo)
                {
                    case 1://cnpj
                        if (strCPF_CNPJ.Trim().Length == 2)
                            strCPF_CNPJ = strCPF_CNPJ + ".";

                        if (strCPF_CNPJ.Trim().Length == 6)
                            strCPF_CNPJ += ".";

                        if (strCPF_CNPJ.Trim().Length == 10)
                            strCPF_CNPJ = strCPF_CNPJ + "/";

                        if (strCPF_CNPJ.Trim().Length == 15)
                            strCPF_CNPJ = strCPF_CNPJ + "-";
                        break;

                    case 2://cpf
                        if (strCPF_CNPJ.Trim().Length == 3)
                            strCPF_CNPJ = strCPF_CNPJ + ".";

                        if (strCPF_CNPJ.Trim().Length == 7)
                            strCPF_CNPJ = strCPF_CNPJ + ".";

                        if (strCPF_CNPJ.Trim().Length == 11)
                            strCPF_CNPJ = strCPF_CNPJ + "-";
                        break;
                }
                return strCPF_CNPJ;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

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
