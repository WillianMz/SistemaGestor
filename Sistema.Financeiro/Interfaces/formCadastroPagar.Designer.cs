namespace Sistema.Financeiro.Interfaces
{
    partial class formCadastroPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadastroPagar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPlanoDeContas = new System.Windows.Forms.Label();
            this.dbPlanodeContas = new System.Windows.Forms.DataGridView();
            this.txtPessoa = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblParcelas = new System.Windows.Forms.Label();
            this.dbGridParcelas = new System.Windows.Forms.DataGridView();
            this.btnNovaPessoa = new System.Windows.Forms.Button();
            this.btnBuscaPessoa = new System.Windows.Forms.Button();
            this.textObservacao = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.cbBanco = new System.Windows.Forms.ComboBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.textValorTitulo = new System.Windows.Forms.TextBox();
            this.lblValorTitulo = new System.Windows.Forms.Label();
            this.cbFormaPgto = new System.Windows.Forms.ComboBox();
            this.lblCondicao = new System.Windows.Forms.Label();
            this.cbPortador = new System.Windows.Forms.ComboBox();
            this.lblPortador = new System.Windows.Forms.Label();
            this.cbCondicao = new System.Windows.Forms.ComboBox();
            this.lblFormaPgto = new System.Windows.Forms.Label();
            this.textNumDoc = new System.Windows.Forms.TextBox();
            this.lblNumDoc = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoPessoa = new System.Windows.Forms.ComboBox();
            this.dtCadastro = new System.Windows.Forms.DateTimePicker();
            this.dtEmissao = new System.Windows.Forms.DateTimePicker();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.lblDtEmissao = new System.Windows.Forms.Label();
            this.lblDtCadastro = new System.Windows.Forms.Label();
            this.lblTipoPessoa = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbPlanodeContas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridParcelas)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPlanoDeContas);
            this.panel1.Controls.Add(this.dbPlanodeContas);
            this.panel1.Controls.Add(this.txtPessoa);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnIncluir);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.lblParcelas);
            this.panel1.Controls.Add(this.dbGridParcelas);
            this.panel1.Controls.Add(this.btnNovaPessoa);
            this.panel1.Controls.Add(this.btnBuscaPessoa);
            this.panel1.Controls.Add(this.textObservacao);
            this.panel1.Controls.Add(this.lblObs);
            this.panel1.Controls.Add(this.cbBanco);
            this.panel1.Controls.Add(this.lblBanco);
            this.panel1.Controls.Add(this.textValorTitulo);
            this.panel1.Controls.Add(this.lblValorTitulo);
            this.panel1.Controls.Add(this.cbFormaPgto);
            this.panel1.Controls.Add(this.lblCondicao);
            this.panel1.Controls.Add(this.cbPortador);
            this.panel1.Controls.Add(this.lblPortador);
            this.panel1.Controls.Add(this.cbCondicao);
            this.panel1.Controls.Add(this.lblFormaPgto);
            this.panel1.Controls.Add(this.textNumDoc);
            this.panel1.Controls.Add(this.lblNumDoc);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.lblCodigp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbTipoPessoa);
            this.panel1.Controls.Add(this.dtCadastro);
            this.panel1.Controls.Add(this.dtEmissao);
            this.panel1.Controls.Add(this.cbEmpresa);
            this.panel1.Controls.Add(this.lblDtEmissao);
            this.panel1.Controls.Add(this.lblDtCadastro);
            this.panel1.Controls.Add(this.lblTipoPessoa);
            this.panel1.Controls.Add(this.lblEmpresa);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 543);
            this.panel1.TabIndex = 0;
            // 
            // lblPlanoDeContas
            // 
            this.lblPlanoDeContas.AutoSize = true;
            this.lblPlanoDeContas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanoDeContas.Location = new System.Drawing.Point(394, 112);
            this.lblPlanoDeContas.Name = "lblPlanoDeContas";
            this.lblPlanoDeContas.Size = new System.Drawing.Size(122, 16);
            this.lblPlanoDeContas.TabIndex = 41;
            this.lblPlanoDeContas.Text = "Plano de Contas";
            // 
            // dbPlanodeContas
            // 
            this.dbPlanodeContas.BackgroundColor = System.Drawing.Color.White;
            this.dbPlanodeContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbPlanodeContas.Location = new System.Drawing.Point(397, 131);
            this.dbPlanodeContas.Name = "dbPlanodeContas";
            this.dbPlanodeContas.Size = new System.Drawing.Size(411, 158);
            this.dbPlanodeContas.TabIndex = 40;
            // 
            // txtPessoa
            // 
            this.txtPessoa.Location = new System.Drawing.Point(153, 80);
            this.txtPessoa.Name = "txtPessoa";
            this.txtPessoa.Size = new System.Drawing.Size(586, 20);
            this.txtPessoa.TabIndex = 39;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(252, 508);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 38;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(171, 508);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 37;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(89, 508);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 36;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(8, 508);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 35;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(733, 508);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblParcelas
            // 
            this.lblParcelas.AutoSize = true;
            this.lblParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcelas.Location = new System.Drawing.Point(394, 303);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(70, 16);
            this.lblParcelas.TabIndex = 32;
            this.lblParcelas.Text = "Parcelas";
            // 
            // dbGridParcelas
            // 
            this.dbGridParcelas.BackgroundColor = System.Drawing.Color.White;
            this.dbGridParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGridParcelas.Location = new System.Drawing.Point(397, 322);
            this.dbGridParcelas.Name = "dbGridParcelas";
            this.dbGridParcelas.Size = new System.Drawing.Size(411, 158);
            this.dbGridParcelas.TabIndex = 31;
            // 
            // btnNovaPessoa
            // 
            this.btnNovaPessoa.BackColor = System.Drawing.Color.Transparent;
            this.btnNovaPessoa.Image = global::Sistema.Financeiro.Properties.Resources.mais16;
            this.btnNovaPessoa.Location = new System.Drawing.Point(745, 79);
            this.btnNovaPessoa.Name = "btnNovaPessoa";
            this.btnNovaPessoa.Size = new System.Drawing.Size(27, 23);
            this.btnNovaPessoa.TabIndex = 30;
            this.btnNovaPessoa.UseVisualStyleBackColor = false;
            // 
            // btnBuscaPessoa
            // 
            this.btnBuscaPessoa.Image = global::Sistema.Financeiro.Properties.Resources.pesquisa;
            this.btnBuscaPessoa.Location = new System.Drawing.Point(781, 78);
            this.btnBuscaPessoa.Name = "btnBuscaPessoa";
            this.btnBuscaPessoa.Size = new System.Drawing.Size(27, 23);
            this.btnBuscaPessoa.TabIndex = 29;
            this.btnBuscaPessoa.UseVisualStyleBackColor = true;
            // 
            // textObservacao
            // 
            this.textObservacao.Location = new System.Drawing.Point(87, 360);
            this.textObservacao.Multiline = true;
            this.textObservacao.Name = "textObservacao";
            this.textObservacao.Size = new System.Drawing.Size(290, 120);
            this.textObservacao.TabIndex = 28;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(54, 363);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(29, 13);
            this.lblObs.TabIndex = 27;
            this.lblObs.Text = "Obs.";
            // 
            // cbBanco
            // 
            this.cbBanco.FormattingEnabled = true;
            this.cbBanco.Location = new System.Drawing.Point(87, 290);
            this.cbBanco.Name = "cbBanco";
            this.cbBanco.Size = new System.Drawing.Size(290, 21);
            this.cbBanco.TabIndex = 23;
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(45, 293);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(38, 13);
            this.lblBanco.TabIndex = 22;
            this.lblBanco.Text = "Banco";
            // 
            // textValorTitulo
            // 
            this.textValorTitulo.Location = new System.Drawing.Point(87, 331);
            this.textValorTitulo.Name = "textValorTitulo";
            this.textValorTitulo.Size = new System.Drawing.Size(143, 20);
            this.textValorTitulo.TabIndex = 21;
            // 
            // lblValorTitulo
            // 
            this.lblValorTitulo.AutoSize = true;
            this.lblValorTitulo.Location = new System.Drawing.Point(23, 334);
            this.lblValorTitulo.Name = "lblValorTitulo";
            this.lblValorTitulo.Size = new System.Drawing.Size(60, 13);
            this.lblValorTitulo.TabIndex = 20;
            this.lblValorTitulo.Text = "Valor Titulo";
            // 
            // cbFormaPgto
            // 
            this.cbFormaPgto.FormattingEnabled = true;
            this.cbFormaPgto.Location = new System.Drawing.Point(87, 214);
            this.cbFormaPgto.Name = "cbFormaPgto";
            this.cbFormaPgto.Size = new System.Drawing.Size(290, 21);
            this.cbFormaPgto.TabIndex = 19;
            // 
            // lblCondicao
            // 
            this.lblCondicao.AutoSize = true;
            this.lblCondicao.Location = new System.Drawing.Point(31, 255);
            this.lblCondicao.Name = "lblCondicao";
            this.lblCondicao.Size = new System.Drawing.Size(52, 13);
            this.lblCondicao.TabIndex = 18;
            this.lblCondicao.Text = "Condição";
            // 
            // cbPortador
            // 
            this.cbPortador.FormattingEnabled = true;
            this.cbPortador.Location = new System.Drawing.Point(87, 176);
            this.cbPortador.Name = "cbPortador";
            this.cbPortador.Size = new System.Drawing.Size(290, 21);
            this.cbPortador.TabIndex = 17;
            // 
            // lblPortador
            // 
            this.lblPortador.AutoSize = true;
            this.lblPortador.Location = new System.Drawing.Point(36, 179);
            this.lblPortador.Name = "lblPortador";
            this.lblPortador.Size = new System.Drawing.Size(47, 13);
            this.lblPortador.TabIndex = 16;
            this.lblPortador.Text = "Portador";
            // 
            // cbCondicao
            // 
            this.cbCondicao.FormattingEnabled = true;
            this.cbCondicao.Location = new System.Drawing.Point(87, 252);
            this.cbCondicao.Name = "cbCondicao";
            this.cbCondicao.Size = new System.Drawing.Size(290, 21);
            this.cbCondicao.TabIndex = 15;
            // 
            // lblFormaPgto
            // 
            this.lblFormaPgto.AutoSize = true;
            this.lblFormaPgto.Location = new System.Drawing.Point(2, 217);
            this.lblFormaPgto.Name = "lblFormaPgto";
            this.lblFormaPgto.Size = new System.Drawing.Size(81, 13);
            this.lblFormaPgto.TabIndex = 14;
            this.lblFormaPgto.Text = "Forma de pagto";
            // 
            // textNumDoc
            // 
            this.textNumDoc.Location = new System.Drawing.Point(255, 131);
            this.textNumDoc.Name = "textNumDoc";
            this.textNumDoc.Size = new System.Drawing.Size(117, 20);
            this.textNumDoc.TabIndex = 13;
            // 
            // lblNumDoc
            // 
            this.lblNumDoc.AutoSize = true;
            this.lblNumDoc.Location = new System.Drawing.Point(255, 115);
            this.lblNumDoc.Name = "lblNumDoc";
            this.lblNumDoc.Size = new System.Drawing.Size(64, 13);
            this.lblNumDoc.TabIndex = 12;
            this.lblNumDoc.Text = "Num. Docto";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(711, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 11;
            // 
            // lblCodigp
            // 
            this.lblCodigp.AutoSize = true;
            this.lblCodigp.Location = new System.Drawing.Point(772, 9);
            this.lblCodigp.Name = "lblCodigp";
            this.lblCodigp.Size = new System.Drawing.Size(40, 13);
            this.lblCodigp.TabIndex = 10;
            this.lblCodigp.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pessoa";
            // 
            // cbTipoPessoa
            // 
            this.cbTipoPessoa.FormattingEnabled = true;
            this.cbTipoPessoa.Location = new System.Drawing.Point(6, 80);
            this.cbTipoPessoa.Name = "cbTipoPessoa";
            this.cbTipoPessoa.Size = new System.Drawing.Size(141, 21);
            this.cbTipoPessoa.TabIndex = 7;
            // 
            // dtCadastro
            // 
            this.dtCadastro.Location = new System.Drawing.Point(131, 131);
            this.dtCadastro.Name = "dtCadastro";
            this.dtCadastro.Size = new System.Drawing.Size(117, 20);
            this.dtCadastro.TabIndex = 6;
            // 
            // dtEmissao
            // 
            this.dtEmissao.Location = new System.Drawing.Point(6, 131);
            this.dtEmissao.Name = "dtEmissao";
            this.dtEmissao.Size = new System.Drawing.Size(117, 20);
            this.dtEmissao.TabIndex = 5;
            this.dtEmissao.Value = new System.DateTime(2020, 3, 25, 14, 32, 12, 0);
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Location = new System.Drawing.Point(6, 25);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(699, 21);
            this.cbEmpresa.TabIndex = 4;
            // 
            // lblDtEmissao
            // 
            this.lblDtEmissao.AutoSize = true;
            this.lblDtEmissao.Location = new System.Drawing.Point(3, 114);
            this.lblDtEmissao.Name = "lblDtEmissao";
            this.lblDtEmissao.Size = new System.Drawing.Size(63, 13);
            this.lblDtEmissao.TabIndex = 3;
            this.lblDtEmissao.Text = "Dt. Emissão";
            // 
            // lblDtCadastro
            // 
            this.lblDtCadastro.AutoSize = true;
            this.lblDtCadastro.Location = new System.Drawing.Point(128, 114);
            this.lblDtCadastro.Name = "lblDtCadastro";
            this.lblDtCadastro.Size = new System.Drawing.Size(66, 13);
            this.lblDtCadastro.TabIndex = 2;
            this.lblDtCadastro.Text = "Dt. Cadastro";
            // 
            // lblTipoPessoa
            // 
            this.lblTipoPessoa.AutoSize = true;
            this.lblTipoPessoa.Location = new System.Drawing.Point(3, 64);
            this.lblTipoPessoa.Name = "lblTipoPessoa";
            this.lblTipoPessoa.Size = new System.Drawing.Size(66, 13);
            this.lblTipoPessoa.TabIndex = 1;
            this.lblTipoPessoa.Text = "Tipo Pessoa";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(3, 9);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(48, 13);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Empresa";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnNovo);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 584);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(906, 53);
            this.panel2.TabIndex = 1;
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(588, 6);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 40);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(691, 6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 40);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(794, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Cancelar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // formCadastroPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(905, 638);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "formCadastroPagar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Títulos a Pagar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbPlanodeContas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridParcelas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbBanco;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.TextBox textValorTitulo;
        private System.Windows.Forms.Label lblValorTitulo;
        private System.Windows.Forms.ComboBox cbFormaPgto;
        private System.Windows.Forms.Label lblCondicao;
        private System.Windows.Forms.ComboBox cbPortador;
        private System.Windows.Forms.Label lblPortador;
        private System.Windows.Forms.ComboBox cbCondicao;
        private System.Windows.Forms.Label lblFormaPgto;
        private System.Windows.Forms.TextBox textNumDoc;
        private System.Windows.Forms.Label lblNumDoc;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoPessoa;
        private System.Windows.Forms.DateTimePicker dtCadastro;
        private System.Windows.Forms.DateTimePicker dtEmissao;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.Label lblDtEmissao;
        private System.Windows.Forms.Label lblDtCadastro;
        private System.Windows.Forms.Label lblTipoPessoa;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblParcelas;
        private System.Windows.Forms.DataGridView dbGridParcelas;
        private System.Windows.Forms.Button btnNovaPessoa;
        private System.Windows.Forms.Button btnBuscaPessoa;
        private System.Windows.Forms.TextBox textObservacao;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtPessoa;
        private System.Windows.Forms.Label lblPlanoDeContas;
        private System.Windows.Forms.DataGridView dbPlanodeContas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button button1;
    }
}