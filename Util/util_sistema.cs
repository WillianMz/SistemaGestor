using Microsoft.Win32;
using Modelo;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace Util
{
    public static class util_sistema
    {
        #region SISTEMA

        //teste -> retirar desta classe
        public static string caminhoImagensProdutos = @"C:\\WN\\Imagens\\Produtos\\";

        #endregion

        #region MANIPULACAO DE COMPONENTES DO WINFORMS

        /// <summary>
        /// PREENCHE AS COMBOBOX
        /// </summary>
        /// <param name="l"></param>
        /// <param name="descricao"></param>
        /// <param name="id"></param>
        /// <param name="obj"></param>
        public static void carregarCombobox(IList l, ComboBox obj)
        {
            string descricao = "Descricao";
            string id = "Id";
            obj.DataSource = l;
            obj.DisplayMember = descricao;
            obj.ValueMember = id;
            obj.SelectedValue = -1;
        }

        //bloqueia os componentes dentro de uma tabPage
        public static void bloquearComponentesTabPage(TabPage tabControl, bool ativo)//bloqueia os componentes de tabControl contra ediução
        {
            foreach (TextBox txt in tabControl.Controls.OfType<TextBox>())
                txt.Enabled = ativo;

            foreach (MaskedTextBox mtxt in tabControl.Controls.OfType<MaskedTextBox>())
                mtxt.Enabled = ativo;

            foreach (ComboBox cbox in tabControl.Controls.OfType<ComboBox>())
                cbox.Enabled = ativo;

            foreach (Button btn in tabControl.Controls.OfType<Button>())
                btn.Enabled = ativo;

            foreach (CheckBox chbox in tabControl.Controls.OfType<CheckBox>())
                chbox.Enabled = ativo;

            foreach (GroupBox gb in tabControl.Controls.OfType<GroupBox>())
                gb.Enabled = ativo;

            foreach (PictureBox pbox in tabControl.Controls.OfType<PictureBox>())
                pbox.Enabled = ativo;

            foreach (DateTimePicker dataTime in tabControl.Controls.OfType<DateTimePicker>())
                dataTime.Enabled = ativo;
        }
       
        public static void bloquearComponentesGroupBox(GroupBox gbx, bool ativo)
        {
            foreach (TextBox txt in gbx.Controls.OfType<TextBox>())
                txt.Enabled = ativo;

            foreach (MaskedTextBox mtxt in gbx.Controls.OfType<MaskedTextBox>())
                mtxt.Enabled = ativo;

            foreach (ComboBox cbox in gbx.Controls.OfType<ComboBox>())
                cbox.Enabled = ativo;

            foreach (Button btn in gbx.Controls.OfType<Button>())
                btn.Enabled = ativo;

            foreach (CheckBox chbox in gbx.Controls.OfType<CheckBox>())
                chbox.Enabled = ativo;

            foreach (PictureBox pbox in gbx.Controls.OfType<PictureBox>())
                pbox.Enabled = ativo;

            foreach (GroupBox gb in gbx.Controls.OfType<GroupBox>())
                gb.Enabled = ativo;

            foreach (DateTimePicker dataTime in gbx.Controls.OfType<DateTimePicker>())
                dataTime.Enabled = ativo;
        }

        //limpa os componentes dentro de uma tabPage
        public static void limparComponentesTabPage(TabPage tabControl)
        {
            foreach (TextBox txt in tabControl.Controls.OfType<TextBox>())
                txt.Clear();

            foreach (MaskedTextBox mtxt in tabControl.Controls.OfType<MaskedTextBox>())
                mtxt.Clear();

            foreach (ComboBox cbox in tabControl.Controls.OfType<ComboBox>())
                cbox.SelectedValue = "";

            foreach (GroupBox gb in tabControl.Controls.OfType<GroupBox>())
            {
                foreach (TextBox txt in gb.Controls.OfType<TextBox>())
                    txt.Clear();

                foreach (MaskedTextBox mtxt in gb.Controls.OfType<MaskedTextBox>())
                    mtxt.Clear();

                foreach (ComboBox cbox in gb.Controls.OfType<ComboBox>())
                    cbox.SelectedValue = "";
            }

            foreach (PictureBox img in tabControl.Controls.OfType<PictureBox>())
                img.Image = null;
                                
        }

        public static void limparComponentesGroupBox(GroupBox gbx)
        {
            foreach (TextBox txt in gbx.Controls.OfType<TextBox>())
                txt.Clear();

            foreach (MaskedTextBox mtxt in gbx.Controls.OfType<MaskedTextBox>())
                mtxt.Clear();

            foreach (ComboBox cbox in gbx.Controls.OfType<ComboBox>())
                cbox.SelectedValue = "";

            foreach (CheckBox chbox in gbx.Controls.OfType<CheckBox>())
                chbox.Checked = false;
            /*
            foreach (PictureBox pbox in gbx.Controls.OfType<PictureBox>())
                pbox.Image*/


            foreach (DateTimePicker dataTime in gbx.Controls.OfType<DateTimePicker>())
                dataTime.Text = "";
        }

        public static void resultadoPesquisa(DataGridView dgv, Label lbl)
        {
            int Resultados = dgv.Rows.Count;

            if (Resultados == 0)
            {
                lbl.Text = "A pesquisa não encontrou nenhum resultado!";
            }
            else if (Resultados == 1)
            {
                lbl.Text = "A pesquisa encontrou 1 resultado!";
            }
            else if (Resultados > 1)
            {
                lbl.Text = "A pesquisa encontrou " + Convert.ToString(Resultados) + " resultados!";
            }
        }


        public static void keyPress(object sender, KeyPressEventArgs e)
        {
            //nao permite o usuario digitar aspas em textbox
            //é usado pois esta dando erro no sql de consultas
            //ainda não sei resolver de outra maneira
            if (e.KeyChar == '\'')
                e.Handled = true;
        }

        //tira a mascara de um componente maskedTextBox
        public static void removerMascara(MaskedTextBox txt)
        {
            txt.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        #endregion


        #region GRAVAR DADOS NO REGISTRO DO WINDOWS

        public static void gravarDadosRegistroWindows(string software, ParamentroDoSistema reg)
        {
            try
            {
                RegistryKey regkey = Registry.CurrentUser.OpenSubKey("Software", true); //cria a referencia para a chave de registro

                regkey = regkey.CreateSubKey("WNSoftware"); //cria subchave c/nome do desenvolvedor
                //regkey.DeleteSubKey(software);
                regkey = regkey.CreateSubKey(software);//cria outra subchave com dados para o software

                //dados do banco de dados
                regkey.SetValue("dbServer", util_dados.criptografar(reg.dbServer));
                regkey.SetValue("dbPort",   util_dados.criptografar(Convert.ToString(reg.dbPort)));
                regkey.SetValue("dbBase",   util_dados.criptografar(reg.dbBase));
                regkey.SetValue("dbUser",   util_dados.criptografar(reg.dbUser));
                regkey.SetValue("dbPWD",    util_dados.criptografar(reg.dbPwd));

                regkey.Close();

                MessageBox.Show(util_msg.msgSalvar + "\n As alterações terão efeitos após reiniciar a aplicação!", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static ParamentroDoSistema lerDadosRegistroWindows(string software)
        {
            try
            {
                RegistryKey regkey = Registry.CurrentUser.OpenSubKey("Software", true); //cria a referencia para a chave de registro
                regkey = regkey.OpenSubKey("WNSoftware");
                
                ParamentroDoSistema reg = new ParamentroDoSistema();
                reg.dbServer = util_dados.descriptografar(regkey.OpenSubKey(software, true).GetValue("dbServer").ToString());
                reg.dbPort   = Convert.ToInt32(util_dados.descriptografar(regkey.OpenSubKey(software, true).GetValue("dbPort").ToString()));
                reg.dbBase   = util_dados.descriptografar(regkey.OpenSubKey(software, true).GetValue("dbBase").ToString());
                reg.dbUser   = util_dados.descriptografar(regkey.OpenSubKey(software, true).GetValue("dbUser").ToString());
                reg.dbPwd    = util_dados.descriptografar(regkey.OpenSubKey(software, true).GetValue("dbPWD").ToString());
                return reg;
            }   
            catch
            {
                return null;
            }
}

        #endregion

    }
}
