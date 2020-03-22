namespace Interfaces.Modulos.Base
{
    partial class formEmpresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMensagem = new System.Windows.Forms.Label();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblRegTrib = new System.Windows.Forms.Label();
            this.lblIE = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFantasia = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lblIM = new System.Windows.Forms.Label();
            this.txtIM = new System.Windows.Forms.TextBox();
            this.checkBoxFilial = new System.Windows.Forms.CheckBox();
            this.checkBoxMatriz = new System.Windows.Forms.CheckBox();
            this.gbEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(174, 372);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(24, 13);
            this.lblMensagem.TabIndex = 57;
            this.lblMensagem.Text = "</>";
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.lblCEP);
            this.gbEndereco.Controls.Add(this.lblComplemento);
            this.gbEndereco.Controls.Add(this.lblNumero);
            this.gbEndereco.Controls.Add(this.txtComplemento);
            this.gbEndereco.Controls.Add(this.txtNumero);
            this.gbEndereco.Controls.Add(this.txtLogradouro);
            this.gbEndereco.Controls.Add(this.lblLogradouro);
            this.gbEndereco.Controls.Add(this.txtCEP);
            this.gbEndereco.Controls.Add(this.lblCidade);
            this.gbEndereco.Controls.Add(this.lblUF);
            this.gbEndereco.Controls.Add(this.cbCidade);
            this.gbEndereco.Controls.Add(this.cbUF);
            this.gbEndereco.Controls.Add(this.cbPais);
            this.gbEndereco.Controls.Add(this.lblPais);
            this.gbEndereco.Location = new System.Drawing.Point(12, 130);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(575, 150);
            this.gbEndereco.TabIndex = 56;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(7, 16);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(28, 13);
            this.lblCEP.TabIndex = 45;
            this.lblCEP.Text = "CEP";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(367, 95);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 44;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(304, 94);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 43;
            this.lblNumero.Text = "Número";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(370, 111);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(194, 20);
            this.txtComplemento.TabIndex = 42;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(307, 111);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(57, 20);
            this.txtNumero.TabIndex = 41;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(10, 111);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(291, 20);
            this.txtLogradouro.TabIndex = 40;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(7, 95);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(61, 13);
            this.lblLogradouro.TabIndex = 39;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(10, 32);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(99, 20);
            this.txtCEP.TabIndex = 38;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(315, 55);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 37;
            this.lblCidade.Text = "Cidade";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(162, 55);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(40, 13);
            this.lblUF.TabIndex = 36;
            this.lblUF.Text = "Estado";
            // 
            // cbCidade
            // 
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(318, 71);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(246, 21);
            this.cbCidade.TabIndex = 35;
            // 
            // cbUF
            // 
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Location = new System.Drawing.Point(165, 71);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(147, 21);
            this.cbUF.TabIndex = 34;
            // 
            // cbPais
            // 
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(10, 71);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(149, 21);
            this.cbPais.TabIndex = 33;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(7, 55);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(29, 13);
            this.lblPais.TabIndex = 32;
            this.lblPais.Text = "País";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvar.Location = new System.Drawing.Point(12, 367);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 55;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.Location = new System.Drawing.Point(93, 367);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 54;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 322);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 53;
            this.lblEmail.Text = "Email";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Location = new System.Drawing.Point(147, 283);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(44, 13);
            this.lblContato.TabIndex = 52;
            this.lblContato.Text = "Contato";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 338);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(354, 20);
            this.txtEmail.TabIndex = 51;
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(150, 299);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(264, 20);
            this.txtContato.TabIndex = 50;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(15, 299);
            this.txtTelefone.Mask = "(00) 00000-0009";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(130, 20);
            this.txtTelefone.TabIndex = 49;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(12, 283);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 48;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblRegTrib
            // 
            this.lblRegTrib.AutoSize = true;
            this.lblRegTrib.Location = new System.Drawing.Point(285, 87);
            this.lblRegTrib.Name = "lblRegTrib";
            this.lblRegTrib.Size = new System.Drawing.Size(74, 13);
            this.lblRegTrib.TabIndex = 47;
            this.lblRegTrib.Text = "Reg.Tributário";
            // 
            // lblIE
            // 
            this.lblIE.AutoSize = true;
            this.lblIE.Location = new System.Drawing.Point(12, 87);
            this.lblIE.Name = "lblIE";
            this.lblIE.Size = new System.Drawing.Size(71, 13);
            this.lblIE.TabIndex = 46;
            this.lblIE.Text = "Insc.Estadual";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(288, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 21);
            this.comboBox1.TabIndex = 45;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 44;
            // 
            // lblFantasia
            // 
            this.lblFantasia.AutoSize = true;
            this.lblFantasia.Location = new System.Drawing.Point(12, 48);
            this.lblFantasia.Name = "lblFantasia";
            this.lblFantasia.Size = new System.Drawing.Size(47, 13);
            this.lblFantasia.TabIndex = 43;
            this.lblFantasia.Text = "Fantasia";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(241, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(81, 13);
            this.lblNome.TabIndex = 42;
            this.lblNome.Text = "Nome completo";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(105, 9);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(59, 13);
            this.lblCNPJ.TabIndex = 41;
            this.lblCNPJ.Text = "CPF/CNPJ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 40;
            this.lblID.Text = "ID";
            // 
            // txtFantasia
            // 
            this.txtFantasia.Location = new System.Drawing.Point(15, 64);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(236, 20);
            this.txtFantasia.TabIndex = 39;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(15, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(87, 20);
            this.txtID.TabIndex = 38;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(244, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(325, 20);
            this.txtNome.TabIndex = 37;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(108, 25);
            this.txtCNPJ.Mask = "00\\.000\\.000/0000-00";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(130, 20);
            this.txtCNPJ.TabIndex = 36;
            // 
            // lblIM
            // 
            this.lblIM.AutoSize = true;
            this.lblIM.Location = new System.Drawing.Point(148, 87);
            this.lblIM.Name = "lblIM";
            this.lblIM.Size = new System.Drawing.Size(75, 13);
            this.lblIM.TabIndex = 58;
            this.lblIM.Text = "Insc.Municipal";
            // 
            // txtIM
            // 
            this.txtIM.Location = new System.Drawing.Point(151, 103);
            this.txtIM.Name = "txtIM";
            this.txtIM.Size = new System.Drawing.Size(131, 20);
            this.txtIM.TabIndex = 59;
            // 
            // checkBoxFilial
            // 
            this.checkBoxFilial.AutoSize = true;
            this.checkBoxFilial.Location = new System.Drawing.Point(523, 67);
            this.checkBoxFilial.Name = "checkBoxFilial";
            this.checkBoxFilial.Size = new System.Drawing.Size(46, 17);
            this.checkBoxFilial.TabIndex = 60;
            this.checkBoxFilial.Text = "Filial";
            this.checkBoxFilial.UseVisualStyleBackColor = true;
            // 
            // checkBoxMatriz
            // 
            this.checkBoxMatriz.AutoSize = true;
            this.checkBoxMatriz.Location = new System.Drawing.Point(463, 67);
            this.checkBoxMatriz.Name = "checkBoxMatriz";
            this.checkBoxMatriz.Size = new System.Drawing.Size(54, 17);
            this.checkBoxMatriz.TabIndex = 61;
            this.checkBoxMatriz.Text = "Matriz";
            this.checkBoxMatriz.UseVisualStyleBackColor = true;
            // 
            // formEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 402);
            this.Controls.Add(this.checkBoxMatriz);
            this.Controls.Add(this.checkBoxFilial);
            this.Controls.Add(this.txtIM);
            this.Controls.Add(this.lblIM);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.gbEndereco);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblRegTrib);
            this.Controls.Add(this.lblIE);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblFantasia);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtFantasia);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCNPJ);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formEmpresa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes da empresa";
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblRegTrib;
        private System.Windows.Forms.Label lblIE;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFantasia;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtCNPJ;
        private System.Windows.Forms.Label lblIM;
        private System.Windows.Forms.TextBox txtIM;
        private System.Windows.Forms.CheckBox checkBoxFilial;
        private System.Windows.Forms.CheckBox checkBoxMatriz;
    }
}