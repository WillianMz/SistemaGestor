namespace Sistema.Pessoas.Interfaces
{
    partial class formPessoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPessoa));
            this.tabDetalhes = new System.Windows.Forms.TabControl();
            this.tabEndereco = new System.Windows.Forms.TabPage();
            this.btnMaisEnderecos = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.comboBoxCidade = new System.Windows.Forms.ComboBox();
            this.comboBoxUF = new System.Windows.Forms.ComboBox();
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.tabContato = new System.Windows.Forms.TabPage();
            this.btnMaisContatos = new System.Windows.Forms.Button();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.tabDadosAdicionais = new System.Windows.Forms.TabPage();
            this.mDtCadastro = new System.Windows.Forms.MaskedTextBox();
            this.lblDtCadastro = new System.Windows.Forms.Label();
            this.mDtAlteracao = new System.Windows.Forms.MaskedTextBox();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblUltimaAlteracao = new System.Windows.Forms.Label();
            this.lblDtNascimento = new System.Windows.Forms.Label();
            this.tabDetCliente = new System.Windows.Forms.TabPage();
            this.tabDetTransp = new System.Windows.Forms.TabPage();
            this.gbTransp = new System.Windows.Forms.GroupBox();
            this.btnVeicTransp = new System.Windows.Forms.Button();
            this.tabDetFornec = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabDetFuncionario = new System.Windows.Forms.TabPage();
            this.tabDetOutro = new System.Windows.Forms.TabPage();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.gbTipoPessoa = new System.Windows.Forms.GroupBox();
            this.cbOutro = new System.Windows.Forms.CheckBox();
            this.cbCliente = new System.Windows.Forms.CheckBox();
            this.cbFuncionario = new System.Windows.Forms.CheckBox();
            this.cbTransportador = new System.Windows.Forms.CheckBox();
            this.cbFornecedor = new System.Windows.Forms.CheckBox();
            this.lblTipoPessoa = new System.Windows.Forms.Label();
            this.cbTipoPessoa = new System.Windows.Forms.ComboBox();
            this.lblIE = new System.Windows.Forms.Label();
            this.txtRG_IE = new System.Windows.Forms.TextBox();
            this.lblFantasia = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tabDetalhes.SuspendLayout();
            this.tabEndereco.SuspendLayout();
            this.tabContato.SuspendLayout();
            this.tabDadosAdicionais.SuspendLayout();
            this.tabDetTransp.SuspendLayout();
            this.tabDetFornec.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.gbPrincipal.SuspendLayout();
            this.gbTipoPessoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDetalhes
            // 
            this.tabDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDetalhes.Controls.Add(this.tabEndereco);
            this.tabDetalhes.Controls.Add(this.tabContato);
            this.tabDetalhes.Controls.Add(this.tabDadosAdicionais);
            this.tabDetalhes.Controls.Add(this.tabDetCliente);
            this.tabDetalhes.Controls.Add(this.tabDetTransp);
            this.tabDetalhes.Controls.Add(this.tabDetFornec);
            this.tabDetalhes.Controls.Add(this.tabDetFuncionario);
            this.tabDetalhes.Controls.Add(this.tabDetOutro);
            this.tabDetalhes.Location = new System.Drawing.Point(12, 220);
            this.tabDetalhes.Name = "tabDetalhes";
            this.tabDetalhes.SelectedIndex = 0;
            this.tabDetalhes.Size = new System.Drawing.Size(742, 236);
            this.tabDetalhes.TabIndex = 1;
            // 
            // tabEndereco
            // 
            this.tabEndereco.Controls.Add(this.btnMaisEnderecos);
            this.tabEndereco.Controls.Add(this.txtNumero);
            this.tabEndereco.Controls.Add(this.lblBairro);
            this.tabEndereco.Controls.Add(this.txtBairro);
            this.tabEndereco.Controls.Add(this.lblCEP);
            this.tabEndereco.Controls.Add(this.lblComplemento);
            this.tabEndereco.Controls.Add(this.lblNumero);
            this.tabEndereco.Controls.Add(this.txtComplemento);
            this.tabEndereco.Controls.Add(this.txtLogradouro);
            this.tabEndereco.Controls.Add(this.lblLogradouro);
            this.tabEndereco.Controls.Add(this.txtCEP);
            this.tabEndereco.Controls.Add(this.lblCidade);
            this.tabEndereco.Controls.Add(this.lblUF);
            this.tabEndereco.Controls.Add(this.comboBoxCidade);
            this.tabEndereco.Controls.Add(this.comboBoxUF);
            this.tabEndereco.Controls.Add(this.comboBoxPais);
            this.tabEndereco.Controls.Add(this.lblPais);
            this.tabEndereco.Location = new System.Drawing.Point(4, 24);
            this.tabEndereco.Name = "tabEndereco";
            this.tabEndereco.Padding = new System.Windows.Forms.Padding(3);
            this.tabEndereco.Size = new System.Drawing.Size(734, 208);
            this.tabEndereco.TabIndex = 0;
            this.tabEndereco.Text = "Endereço";
            this.tabEndereco.UseVisualStyleBackColor = true;
            // 
            // btnMaisEnderecos
            // 
            this.btnMaisEnderecos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnMaisEnderecos.FlatAppearance.BorderSize = 0;
            this.btnMaisEnderecos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaisEnderecos.ForeColor = System.Drawing.Color.White;
            this.btnMaisEnderecos.Location = new System.Drawing.Point(595, 6);
            this.btnMaisEnderecos.Name = "btnMaisEnderecos";
            this.btnMaisEnderecos.Size = new System.Drawing.Size(132, 25);
            this.btnMaisEnderecos.TabIndex = 8;
            this.btnMaisEnderecos.Text = "Outros endereços";
            this.btnMaisEnderecos.UseVisualStyleBackColor = false;
            this.btnMaisEnderecos.Click += new System.EventHandler(this.btnMaisEnderecos_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(375, 162);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(57, 23);
            this.txtNumero.TabIndex = 6;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(266, 100);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(42, 15);
            this.lblBairro.TabIndex = 63;
            this.lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(269, 118);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(294, 23);
            this.txtBairro.TabIndex = 4;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(6, 8);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(27, 15);
            this.lblCEP.TabIndex = 62;
            this.lblCEP.Text = "CEP";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(435, 146);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(82, 15);
            this.lblComplemento.TabIndex = 61;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(372, 145);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(50, 15);
            this.lblNumero.TabIndex = 60;
            this.lblNumero.Text = "Número";
            // 
            // txtComplemento
            // 
            this.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Location = new System.Drawing.Point(438, 162);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(194, 23);
            this.txtComplemento.TabIndex = 7;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogradouro.Location = new System.Drawing.Point(9, 162);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(360, 23);
            this.txtLogradouro.TabIndex = 5;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(6, 146);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(70, 15);
            this.lblLogradouro.TabIndex = 59;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(9, 26);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(99, 23);
            this.txtCEP.TabIndex = 0;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(6, 100);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(45, 15);
            this.lblCidade.TabIndex = 58;
            this.lblCidade.Text = "Cidade";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(161, 54);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(44, 15);
            this.lblUF.TabIndex = 57;
            this.lblUF.Text = "Estado";
            // 
            // comboBoxCidade
            // 
            this.comboBoxCidade.BackColor = System.Drawing.Color.White;
            this.comboBoxCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCidade.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxCidade.ForeColor = System.Drawing.Color.Black;
            this.comboBoxCidade.FormattingEnabled = true;
            this.comboBoxCidade.Location = new System.Drawing.Point(9, 118);
            this.comboBoxCidade.Name = "comboBoxCidade";
            this.comboBoxCidade.Size = new System.Drawing.Size(254, 23);
            this.comboBoxCidade.TabIndex = 3;
            this.comboBoxCidade.Leave += new System.EventHandler(this.cbCidade_Leave);
            // 
            // comboBoxUF
            // 
            this.comboBoxUF.BackColor = System.Drawing.Color.White;
            this.comboBoxUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUF.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxUF.ForeColor = System.Drawing.Color.Black;
            this.comboBoxUF.FormattingEnabled = true;
            this.comboBoxUF.Location = new System.Drawing.Point(164, 72);
            this.comboBoxUF.Name = "comboBoxUF";
            this.comboBoxUF.Size = new System.Drawing.Size(80, 23);
            this.comboBoxUF.TabIndex = 2;
            this.comboBoxUF.SelectedValueChanged += new System.EventHandler(this.cbUF_SelectedValueChanged);
            this.comboBoxUF.Leave += new System.EventHandler(this.cbUF_Leave);
            // 
            // comboBoxPais
            // 
            this.comboBoxPais.BackColor = System.Drawing.Color.White;
            this.comboBoxPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPais.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxPais.ForeColor = System.Drawing.Color.Black;
            this.comboBoxPais.FormattingEnabled = true;
            this.comboBoxPais.Location = new System.Drawing.Point(9, 72);
            this.comboBoxPais.Name = "comboBoxPais";
            this.comboBoxPais.Size = new System.Drawing.Size(149, 23);
            this.comboBoxPais.TabIndex = 1;
            this.comboBoxPais.SelectedValueChanged += new System.EventHandler(this.cbPais_SelectedValueChanged);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(6, 54);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(30, 15);
            this.lblPais.TabIndex = 56;
            this.lblPais.Text = "País";
            // 
            // tabContato
            // 
            this.tabContato.Controls.Add(this.btnMaisContatos);
            this.tabContato.Controls.Add(this.txtCelular);
            this.tabContato.Controls.Add(this.lblCelular);
            this.tabContato.Controls.Add(this.lblEmail);
            this.tabContato.Controls.Add(this.lblContato);
            this.tabContato.Controls.Add(this.txtEmail);
            this.tabContato.Controls.Add(this.txtContato);
            this.tabContato.Controls.Add(this.txtTelefone);
            this.tabContato.Controls.Add(this.lblTelefone);
            this.tabContato.Location = new System.Drawing.Point(4, 24);
            this.tabContato.Name = "tabContato";
            this.tabContato.Padding = new System.Windows.Forms.Padding(3);
            this.tabContato.Size = new System.Drawing.Size(734, 208);
            this.tabContato.TabIndex = 1;
            this.tabContato.Text = "Contato";
            this.tabContato.UseVisualStyleBackColor = true;
            // 
            // btnMaisContatos
            // 
            this.btnMaisContatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnMaisContatos.FlatAppearance.BorderSize = 0;
            this.btnMaisContatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaisContatos.ForeColor = System.Drawing.Color.White;
            this.btnMaisContatos.Location = new System.Drawing.Point(596, 6);
            this.btnMaisContatos.Name = "btnMaisContatos";
            this.btnMaisContatos.Size = new System.Drawing.Size(132, 25);
            this.btnMaisContatos.TabIndex = 4;
            this.btnMaisContatos.Text = "Outros contatos";
            this.btnMaisContatos.UseVisualStyleBackColor = false;
            this.btnMaisContatos.Click += new System.EventHandler(this.btnMaisContatos_Click);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(9, 73);
            this.txtCelular.Mask = "(00) 00000-0009";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(130, 23);
            this.txtCelular.TabIndex = 1;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(7, 55);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(47, 15);
            this.lblCelular.TabIndex = 81;
            this.lblCelular.Text = "Celular";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 147);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 15);
            this.lblEmail.TabIndex = 79;
            this.lblEmail.Text = "Email";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Location = new System.Drawing.Point(7, 101);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(50, 15);
            this.lblContato.TabIndex = 78;
            this.lblContato.Text = "Contato";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(9, 165);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(354, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // txtContato
            // 
            this.txtContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContato.Location = new System.Drawing.Point(9, 119);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(264, 23);
            this.txtContato.TabIndex = 2;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(9, 27);
            this.txtTelefone.Mask = "(00) 0000-0009";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(130, 23);
            this.txtTelefone.TabIndex = 0;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(6, 9);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 15);
            this.lblTelefone.TabIndex = 77;
            this.lblTelefone.Text = "Telefone";
            // 
            // tabDadosAdicionais
            // 
            this.tabDadosAdicionais.Controls.Add(this.mDtCadastro);
            this.tabDadosAdicionais.Controls.Add(this.lblDtCadastro);
            this.tabDadosAdicionais.Controls.Add(this.mDtAlteracao);
            this.tabDadosAdicionais.Controls.Add(this.dtNascimento);
            this.tabDadosAdicionais.Controls.Add(this.lblUltimaAlteracao);
            this.tabDadosAdicionais.Controls.Add(this.lblDtNascimento);
            this.tabDadosAdicionais.Location = new System.Drawing.Point(4, 24);
            this.tabDadosAdicionais.Name = "tabDadosAdicionais";
            this.tabDadosAdicionais.Padding = new System.Windows.Forms.Padding(3);
            this.tabDadosAdicionais.Size = new System.Drawing.Size(734, 208);
            this.tabDadosAdicionais.TabIndex = 2;
            this.tabDadosAdicionais.Text = "Detalhes adicionais";
            this.tabDadosAdicionais.UseVisualStyleBackColor = true;
            // 
            // mDtCadastro
            // 
            this.mDtCadastro.Enabled = false;
            this.mDtCadastro.Location = new System.Drawing.Point(86, 42);
            this.mDtCadastro.Mask = "00/00/0000";
            this.mDtCadastro.Name = "mDtCadastro";
            this.mDtCadastro.Size = new System.Drawing.Size(100, 23);
            this.mDtCadastro.TabIndex = 56;
            this.mDtCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // lblDtCadastro
            // 
            this.lblDtCadastro.AutoSize = true;
            this.lblDtCadastro.Location = new System.Drawing.Point(8, 45);
            this.lblDtCadastro.Name = "lblDtCadastro";
            this.lblDtCadastro.Size = new System.Drawing.Size(75, 15);
            this.lblDtCadastro.TabIndex = 55;
            this.lblDtCadastro.Text = "Dt. Cadastro";
            // 
            // mDtAlteracao
            // 
            this.mDtAlteracao.Enabled = false;
            this.mDtAlteracao.Location = new System.Drawing.Point(313, 42);
            this.mDtAlteracao.Mask = "00/00/0000";
            this.mDtAlteracao.Name = "mDtAlteracao";
            this.mDtAlteracao.Size = new System.Drawing.Size(105, 23);
            this.mDtAlteracao.TabIndex = 4;
            this.mDtAlteracao.ValidatingType = typeof(System.DateTime);
            // 
            // dtNascimento
            // 
            this.dtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimento.Location = new System.Drawing.Point(103, 12);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(105, 23);
            this.dtNascimento.TabIndex = 0;
            // 
            // lblUltimaAlteracao
            // 
            this.lblUltimaAlteracao.AutoSize = true;
            this.lblUltimaAlteracao.Location = new System.Drawing.Point(194, 45);
            this.lblUltimaAlteracao.Name = "lblUltimaAlteracao";
            this.lblUltimaAlteracao.Size = new System.Drawing.Size(117, 15);
            this.lblUltimaAlteracao.TabIndex = 1;
            this.lblUltimaAlteracao.Text = "Dt. Última Alteração";
            // 
            // lblDtNascimento
            // 
            this.lblDtNascimento.AutoSize = true;
            this.lblDtNascimento.Location = new System.Drawing.Point(8, 18);
            this.lblDtNascimento.Name = "lblDtNascimento";
            this.lblDtNascimento.Size = new System.Drawing.Size(90, 15);
            this.lblDtNascimento.TabIndex = 0;
            this.lblDtNascimento.Text = "Dt. Nascimento";
            // 
            // tabDetCliente
            // 
            this.tabDetCliente.Location = new System.Drawing.Point(4, 24);
            this.tabDetCliente.Name = "tabDetCliente";
            this.tabDetCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetCliente.Size = new System.Drawing.Size(734, 208);
            this.tabDetCliente.TabIndex = 3;
            this.tabDetCliente.Text = "Cliente";
            this.tabDetCliente.UseVisualStyleBackColor = true;
            // 
            // tabDetTransp
            // 
            this.tabDetTransp.Controls.Add(this.gbTransp);
            this.tabDetTransp.Controls.Add(this.btnVeicTransp);
            this.tabDetTransp.Location = new System.Drawing.Point(4, 24);
            this.tabDetTransp.Name = "tabDetTransp";
            this.tabDetTransp.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetTransp.Size = new System.Drawing.Size(734, 208);
            this.tabDetTransp.TabIndex = 4;
            this.tabDetTransp.Text = "Transportador";
            this.tabDetTransp.UseVisualStyleBackColor = true;
            // 
            // gbTransp
            // 
            this.gbTransp.Location = new System.Drawing.Point(3, 35);
            this.gbTransp.Name = "gbTransp";
            this.gbTransp.Size = new System.Drawing.Size(725, 167);
            this.gbTransp.TabIndex = 1;
            this.gbTransp.TabStop = false;
            this.gbTransp.Text = "Veículos";
            // 
            // btnVeicTransp
            // 
            this.btnVeicTransp.Location = new System.Drawing.Point(3, 6);
            this.btnVeicTransp.Name = "btnVeicTransp";
            this.btnVeicTransp.Size = new System.Drawing.Size(136, 23);
            this.btnVeicTransp.TabIndex = 0;
            this.btnVeicTransp.Text = "Adicionar Veículo";
            this.btnVeicTransp.UseVisualStyleBackColor = true;
            // 
            // tabDetFornec
            // 
            this.tabDetFornec.Controls.Add(this.button2);
            this.tabDetFornec.Controls.Add(this.button1);
            this.tabDetFornec.Controls.Add(this.checkBox2);
            this.tabDetFornec.Controls.Add(this.checkBox1);
            this.tabDetFornec.Location = new System.Drawing.Point(4, 24);
            this.tabDetFornec.Name = "tabDetFornec";
            this.tabDetFornec.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetFornec.Size = new System.Drawing.Size(734, 208);
            this.tabDetFornec.TabIndex = 5;
            this.tabDetFornec.Text = "Fornecedor";
            this.tabDetFornec.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 48);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(47, 19);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "MEI";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Produtor Rural";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabDetFuncionario
            // 
            this.tabDetFuncionario.Location = new System.Drawing.Point(4, 24);
            this.tabDetFuncionario.Name = "tabDetFuncionario";
            this.tabDetFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetFuncionario.Size = new System.Drawing.Size(734, 208);
            this.tabDetFuncionario.TabIndex = 6;
            this.tabDetFuncionario.Text = "Colaborador";
            this.tabDetFuncionario.UseVisualStyleBackColor = true;
            // 
            // tabDetOutro
            // 
            this.tabDetOutro.Location = new System.Drawing.Point(4, 24);
            this.tabDetOutro.Name = "tabDetOutro";
            this.tabDetOutro.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetOutro.Size = new System.Drawing.Size(734, 208);
            this.tabDetOutro.TabIndex = 7;
            this.tabDetOutro.Text = "Outro";
            this.tabDetOutro.UseVisualStyleBackColor = true;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(766, 41);
            this.pnlTitulo.TabIndex = 55;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.Location = new System.Drawing.Point(7, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(71, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "<Titulo>";
            // 
            // pnlRodape
            // 
            this.pnlRodape.Controls.Add(this.btnNovo);
            this.pnlRodape.Controls.Add(this.btnSalvar);
            this.pnlRodape.Controls.Add(this.btnCancelar);
            this.pnlRodape.Controls.Add(this.lblMensagem);
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(0, 461);
            this.pnlRodape.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(766, 47);
            this.pnlRodape.TabIndex = 56;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(457, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 40);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(560, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 40);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(663, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(13, 14);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(24, 15);
            this.lblMensagem.TabIndex = 2;
            this.lblMensagem.Text = "</>";
            // 
            // gbPrincipal
            // 
            this.gbPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPrincipal.Controls.Add(this.txtCNPJ);
            this.gbPrincipal.Controls.Add(this.checkBoxAtivo);
            this.gbPrincipal.Controls.Add(this.gbTipoPessoa);
            this.gbPrincipal.Controls.Add(this.lblTipoPessoa);
            this.gbPrincipal.Controls.Add(this.cbTipoPessoa);
            this.gbPrincipal.Controls.Add(this.lblIE);
            this.gbPrincipal.Controls.Add(this.txtRG_IE);
            this.gbPrincipal.Controls.Add(this.lblFantasia);
            this.gbPrincipal.Controls.Add(this.lblNome);
            this.gbPrincipal.Controls.Add(this.lblCNPJ);
            this.gbPrincipal.Controls.Add(this.lblID);
            this.gbPrincipal.Controls.Add(this.txtFantasia);
            this.gbPrincipal.Controls.Add(this.txtID);
            this.gbPrincipal.Controls.Add(this.txtNome);
            this.gbPrincipal.Location = new System.Drawing.Point(12, 47);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Size = new System.Drawing.Size(742, 167);
            this.gbPrincipal.TabIndex = 0;
            this.gbPrincipal.TabStop = false;
            this.gbPrincipal.Text = "Dados principais";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(9, 81);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(155, 23);
            this.txtCNPJ.TabIndex = 2;
            this.txtCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCNPJ_KeyPress);
            this.txtCNPJ.Leave += new System.EventHandler(this.txtCNPJ_Leave);
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.Location = new System.Drawing.Point(640, 128);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(95, 19);
            this.checkBoxAtivo.TabIndex = 6;
            this.checkBoxAtivo.Text = "Pessoa Ativa";
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // gbTipoPessoa
            // 
            this.gbTipoPessoa.Controls.Add(this.cbOutro);
            this.gbTipoPessoa.Controls.Add(this.cbCliente);
            this.gbTipoPessoa.Controls.Add(this.cbFuncionario);
            this.gbTipoPessoa.Controls.Add(this.cbTransportador);
            this.gbTipoPessoa.Controls.Add(this.cbFornecedor);
            this.gbTipoPessoa.Location = new System.Drawing.Point(273, 17);
            this.gbTipoPessoa.Name = "gbTipoPessoa";
            this.gbTipoPessoa.Size = new System.Drawing.Size(450, 53);
            this.gbTipoPessoa.TabIndex = 1;
            this.gbTipoPessoa.TabStop = false;
            this.gbTipoPessoa.Text = "Esta pessoa é:";
            // 
            // cbOutro
            // 
            this.cbOutro.AutoSize = true;
            this.cbOutro.Location = new System.Drawing.Point(379, 20);
            this.cbOutro.Name = "cbOutro";
            this.cbOutro.Size = new System.Drawing.Size(58, 19);
            this.cbOutro.TabIndex = 4;
            this.cbOutro.Text = "Outro";
            this.cbOutro.UseVisualStyleBackColor = true;
            // 
            // cbCliente
            // 
            this.cbCliente.AutoSize = true;
            this.cbCliente.Location = new System.Drawing.Point(6, 21);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(64, 19);
            this.cbCliente.TabIndex = 0;
            this.cbCliente.Text = "Cliente";
            this.cbCliente.UseVisualStyleBackColor = true;
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.AutoSize = true;
            this.cbFuncionario.Location = new System.Drawing.Point(280, 20);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(96, 19);
            this.cbFuncionario.TabIndex = 3;
            this.cbFuncionario.Text = "Colaborador";
            this.cbFuncionario.UseVisualStyleBackColor = true;
            // 
            // cbTransportador
            // 
            this.cbTransportador.AutoSize = true;
            this.cbTransportador.Location = new System.Drawing.Point(169, 21);
            this.cbTransportador.Name = "cbTransportador";
            this.cbTransportador.Size = new System.Drawing.Size(105, 19);
            this.cbTransportador.TabIndex = 2;
            this.cbTransportador.Text = "Transportador";
            this.cbTransportador.UseVisualStyleBackColor = true;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.AutoSize = true;
            this.cbFornecedor.Location = new System.Drawing.Point(75, 21);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(88, 19);
            this.cbFornecedor.TabIndex = 1;
            this.cbFornecedor.Text = "Fornecedor";
            this.cbFornecedor.UseVisualStyleBackColor = true;
            // 
            // lblTipoPessoa
            // 
            this.lblTipoPessoa.AutoSize = true;
            this.lblTipoPessoa.Location = new System.Drawing.Point(77, 18);
            this.lblTipoPessoa.Name = "lblTipoPessoa";
            this.lblTipoPessoa.Size = new System.Drawing.Size(31, 15);
            this.lblTipoPessoa.TabIndex = 96;
            this.lblTipoPessoa.Text = "Tipo";
            // 
            // cbTipoPessoa
            // 
            this.cbTipoPessoa.BackColor = System.Drawing.Color.White;
            this.cbTipoPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPessoa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTipoPessoa.ForeColor = System.Drawing.Color.Black;
            this.cbTipoPessoa.FormattingEnabled = true;
            this.cbTipoPessoa.Location = new System.Drawing.Point(79, 36);
            this.cbTipoPessoa.Name = "cbTipoPessoa";
            this.cbTipoPessoa.Size = new System.Drawing.Size(121, 23);
            this.cbTipoPessoa.TabIndex = 0;
            this.cbTipoPessoa.Leave += new System.EventHandler(this.cbTipoPessoa_Leave);
            // 
            // lblIE
            // 
            this.lblIE.AutoSize = true;
            this.lblIE.Location = new System.Drawing.Point(310, 109);
            this.lblIE.Name = "lblIE";
            this.lblIE.Size = new System.Drawing.Size(37, 15);
            this.lblIE.TabIndex = 95;
            this.lblIE.Text = "RG/IE";
            // 
            // txtRG_IE
            // 
            this.txtRG_IE.Location = new System.Drawing.Point(313, 127);
            this.txtRG_IE.Name = "txtRG_IE";
            this.txtRG_IE.Size = new System.Drawing.Size(157, 23);
            this.txtRG_IE.TabIndex = 5;
            // 
            // lblFantasia
            // 
            this.lblFantasia.AutoSize = true;
            this.lblFantasia.Location = new System.Drawing.Point(6, 109);
            this.lblFantasia.Name = "lblFantasia";
            this.lblFantasia.Size = new System.Drawing.Size(55, 15);
            this.lblFantasia.TabIndex = 94;
            this.lblFantasia.Text = "Fantasia";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(167, 63);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(92, 15);
            this.lblNome.TabIndex = 93;
            this.lblNome.Text = "Nome completo";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(6, 63);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(57, 15);
            this.lblCNPJ.TabIndex = 92;
            this.lblCNPJ.Text = "CPF/CNPJ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 18);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(45, 15);
            this.lblID.TabIndex = 91;
            this.lblID.Text = "Código";
            // 
            // txtFantasia
            // 
            this.txtFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFantasia.Location = new System.Drawing.Point(9, 127);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(298, 23);
            this.txtFantasia.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(9, 36);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(65, 23);
            this.txtID.TabIndex = 89;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(170, 81);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(425, 23);
            this.txtNome.TabIndex = 3;
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // formPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 508);
            this.Controls.Add(this.gbPrincipal);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.tabDetalhes);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formPessoa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pessoa";
            this.tabDetalhes.ResumeLayout(false);
            this.tabEndereco.ResumeLayout(false);
            this.tabEndereco.PerformLayout();
            this.tabContato.ResumeLayout(false);
            this.tabContato.PerformLayout();
            this.tabDadosAdicionais.ResumeLayout(false);
            this.tabDadosAdicionais.PerformLayout();
            this.tabDetTransp.ResumeLayout(false);
            this.tabDetFornec.ResumeLayout(false);
            this.tabDetFornec.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlRodape.ResumeLayout(false);
            this.pnlRodape.PerformLayout();
            this.gbPrincipal.ResumeLayout(false);
            this.gbPrincipal.PerformLayout();
            this.gbTipoPessoa.ResumeLayout(false);
            this.gbTipoPessoa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabDetalhes;
        private System.Windows.Forms.TabPage tabEndereco;
        public System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblBairro;
        public System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblNumero;
        public System.Windows.Forms.TextBox txtComplemento;
        public System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        public System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblUF;
        public System.Windows.Forms.ComboBox comboBoxCidade;
        public System.Windows.Forms.ComboBox comboBoxUF;
        public System.Windows.Forms.ComboBox comboBoxPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TabPage tabContato;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TabPage tabDadosAdicionais;
        private System.Windows.Forms.Label lblDtCadastro;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.Label lblUltimaAlteracao;
        private System.Windows.Forms.Label lblDtNascimento;
        private System.Windows.Forms.MaskedTextBox mDtAlteracao;
        private System.Windows.Forms.MaskedTextBox mDtCadastro;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.Windows.Forms.CheckBox checkBoxAtivo;
        private System.Windows.Forms.Label lblTipoPessoa;
        private System.Windows.Forms.ComboBox cbTipoPessoa;
        private System.Windows.Forms.Label lblIE;
        private System.Windows.Forms.TextBox txtRG_IE;
        private System.Windows.Forms.Label lblFantasia;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtFantasia;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gbTipoPessoa;
        private System.Windows.Forms.CheckBox cbOutro;
        private System.Windows.Forms.CheckBox cbCliente;
        private System.Windows.Forms.CheckBox cbFuncionario;
        private System.Windows.Forms.CheckBox cbTransportador;
        private System.Windows.Forms.CheckBox cbFornecedor;
        private System.Windows.Forms.Button btnMaisEnderecos;
        private System.Windows.Forms.Button btnMaisContatos;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TabPage tabDetCliente;
        private System.Windows.Forms.TabPage tabDetTransp;
        private System.Windows.Forms.GroupBox gbTransp;
        private System.Windows.Forms.Button btnVeicTransp;
        private System.Windows.Forms.TabPage tabDetFornec;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabPage tabDetFuncionario;
        private System.Windows.Forms.TabPage tabDetOutro;
        private System.Windows.Forms.TextBox txtCNPJ;
    }
}