namespace Sistema.Estoque.Interfaces
{
    partial class formEstoqueEntrada
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
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.tabNota = new System.Windows.Forms.TabControl();
            this.tabPrincipal = new System.Windows.Forms.TabPage();
            this.gbFornecedor = new System.Windows.Forms.GroupBox();
            this.lblMsgFornec = new System.Windows.Forms.Label();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.txt_cnpjFornec = new System.Windows.Forms.TextBox();
            this.lblCNPJFornecedor = new System.Windows.Forms.Label();
            this.gbEmpresa = new System.Windows.Forms.GroupBox();
            this.mtxtCNPJEmpresa = new System.Windows.Forms.MaskedTextBox();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.lblMsgEmpresa = new System.Windows.Forms.Label();
            this.lblCNPJEmpresa = new System.Windows.Forms.Label();
            this.gbImpostoNota = new System.Windows.Forms.GroupBox();
            this.lblTotalNota = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblVL_ipi = new System.Windows.Forms.Label();
            this.txtValorIPI = new System.Windows.Forms.TextBox();
            this.lblOutrasDespesas = new System.Windows.Forms.Label();
            this.txtOutrasDesp = new System.Windows.Forms.TextBox();
            this.lblVL_Desconto = new System.Windows.Forms.Label();
            this.txtValorDesconto = new System.Windows.Forms.TextBox();
            this.lblVL_Seguro = new System.Windows.Forms.Label();
            this.txtValorSeguro = new System.Windows.Forms.TextBox();
            this.lblVL_Frete = new System.Windows.Forms.Label();
            this.txtValorFrete = new System.Windows.Forms.TextBox();
            this.lblValorTotalItens = new System.Windows.Forms.Label();
            this.txtValorItens = new System.Windows.Forms.TextBox();
            this.lblVL_Importacao = new System.Windows.Forms.Label();
            this.txt_vlImportacao = new System.Windows.Forms.TextBox();
            this.lblVL_icmsST = new System.Windows.Forms.Label();
            this.txt_vlICMSst = new System.Windows.Forms.TextBox();
            this.lblBC_icmsST = new System.Windows.Forms.Label();
            this.txt_bcICMSst = new System.Windows.Forms.TextBox();
            this.lblVL_icms = new System.Windows.Forms.Label();
            this.txt_vlICMS = new System.Windows.Forms.TextBox();
            this.lblBC_ICMS = new System.Windows.Forms.Label();
            this.txt_bcICMS = new System.Windows.Forms.TextBox();
            this.gbCabecalhoNota = new System.Windows.Forms.GroupBox();
            this.lblTpNota = new System.Windows.Forms.Label();
            this.cbTipoNota = new System.Windows.Forms.ComboBox();
            this.lblEntradaSaida = new System.Windows.Forms.Label();
            this.lblEmissao = new System.Windows.Forms.Label();
            this.dtEntradaSaida = new System.Windows.Forms.DateTimePicker();
            this.dtEmissao = new System.Windows.Forms.DateTimePicker();
            this.txtNatOp = new System.Windows.Forms.TextBox();
            this.lblNatOper = new System.Windows.Forms.Label();
            this.txtProtocolo = new System.Windows.Forms.TextBox();
            this.lblProtocolo = new System.Windows.Forms.Label();
            this.txtChaveAcesso = new System.Windows.Forms.TextBox();
            this.lblChaveAcesso = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.txtNumeroNota = new System.Windows.Forms.TextBox();
            this.lblNumeroNota = new System.Windows.Forms.Label();
            this.btnArquivoXML = new System.Windows.Forms.Button();
            this.lblArquivoXML = new System.Windows.Forms.Label();
            this.txtArquivoXML = new System.Windows.Forms.TextBox();
            this.tabProdutos = new System.Windows.Forms.TabPage();
            this.btnEditarCadProduto = new System.Windows.Forms.Button();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.dgvProdutosItens = new System.Windows.Forms.DataGridView();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCFOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVLUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVLTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBCicms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVLicms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVLipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlqICMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlqIPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbItem = new System.Windows.Forms.GroupBox();
            this.txtProdutoQtdEntrada = new System.Windows.Forms.TextBox();
            this.lblProdQtdEntrada = new System.Windows.Forms.Label();
            this.txtProdutoQTD = new System.Windows.Forms.TextBox();
            this.lblProdQtdUN = new System.Windows.Forms.Label();
            this.txtProdutoQtdEmb = new System.Windows.Forms.TextBox();
            this.lblProdQtdEmb = new System.Windows.Forms.Label();
            this.lblProdUN = new System.Windows.Forms.Label();
            this.cboxProdutoUN = new System.Windows.Forms.ComboBox();
            this.lblProdutoCod = new System.Windows.Forms.Label();
            this.txtProdutoCod = new System.Windows.Forms.TextBox();
            this.txtProdutoDesconto = new System.Windows.Forms.TextBox();
            this.lblProdDesc = new System.Windows.Forms.Label();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.txtProdutoAlqIPI = new System.Windows.Forms.TextBox();
            this.lblProdAlqIPI = new System.Windows.Forms.Label();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.txtProdutoAlqICMS = new System.Windows.Forms.TextBox();
            this.lblProdAlqICMS = new System.Windows.Forms.Label();
            this.txtProdutoVL_IPI = new System.Windows.Forms.TextBox();
            this.lblProdVl_IPI = new System.Windows.Forms.Label();
            this.lblProdutoNome = new System.Windows.Forms.Label();
            this.txtProdutoVL_ICMS = new System.Windows.Forms.TextBox();
            this.lblProdVl_ICMS = new System.Windows.Forms.Label();
            this.txtProdutoBC_ICMS = new System.Windows.Forms.TextBox();
            this.lblProdBC_ICMS = new System.Windows.Forms.Label();
            this.txtProdutoCFOP = new System.Windows.Forms.TextBox();
            this.lblProdCFOP = new System.Windows.Forms.Label();
            this.txtProdutoCST = new System.Windows.Forms.TextBox();
            this.lblProdCST = new System.Windows.Forms.Label();
            this.txtProdutoDescricao = new System.Windows.Forms.TextBox();
            this.txtProdutoValorUN = new System.Windows.Forms.TextBox();
            this.lblProdVlUn = new System.Windows.Forms.Label();
            this.txtProdutoValorTotal = new System.Windows.Forms.TextBox();
            this.lblProdVlTotal = new System.Windows.Forms.Label();
            this.lblProdCodBarras = new System.Windows.Forms.Label();
            this.txtProdutoCodbarras = new System.Windows.Forms.TextBox();
            this.tabTransporte = new System.Windows.Forms.TabPage();
            this.gbFrete = new System.Windows.Forms.GroupBox();
            this.lblMsgTransp = new System.Windows.Forms.Label();
            this.btnTransp = new System.Windows.Forms.Button();
            this.txtNomeTransp = new System.Windows.Forms.TextBox();
            this.txtCNPJtransp = new System.Windows.Forms.TextBox();
            this.lblCNPJtransp = new System.Windows.Forms.Label();
            this.tabFatura = new System.Windows.Forms.TabPage();
            this.pnlRodape.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.tabNota.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.gbFornecedor.SuspendLayout();
            this.gbEmpresa.SuspendLayout();
            this.gbImpostoNota.SuspendLayout();
            this.gbCabecalhoNota.SuspendLayout();
            this.tabProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosItens)).BeginInit();
            this.gbItem.SuspendLayout();
            this.tabTransporte.SuspendLayout();
            this.gbFrete.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRodape
            // 
            this.pnlRodape.Controls.Add(this.lblMensagem);
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(0, 467);
            this.pnlRodape.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(938, 50);
            this.pnlRodape.TabIndex = 6;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(9, 18);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(31, 17);
            this.lblMensagem.TabIndex = 2;
            this.lblMensagem.Text = "</>";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.Location = new System.Drawing.Point(7, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(238, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nova Entrada de Mercadorias";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(938, 41);
            this.pnlTitulo.TabIndex = 5;
            // 
            // tabNota
            // 
            this.tabNota.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabNota.Controls.Add(this.tabPrincipal);
            this.tabNota.Controls.Add(this.tabProdutos);
            this.tabNota.Controls.Add(this.tabTransporte);
            this.tabNota.Controls.Add(this.tabFatura);
            this.tabNota.Location = new System.Drawing.Point(12, 48);
            this.tabNota.Name = "tabNota";
            this.tabNota.SelectedIndex = 0;
            this.tabNota.Size = new System.Drawing.Size(914, 412);
            this.tabNota.TabIndex = 0;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.gbFornecedor);
            this.tabPrincipal.Controls.Add(this.gbEmpresa);
            this.tabPrincipal.Controls.Add(this.gbImpostoNota);
            this.tabPrincipal.Controls.Add(this.gbCabecalhoNota);
            this.tabPrincipal.Location = new System.Drawing.Point(4, 24);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrincipal.Size = new System.Drawing.Size(906, 384);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.Text = "Principal";
            this.tabPrincipal.UseVisualStyleBackColor = true;
            // 
            // gbFornecedor
            // 
            this.gbFornecedor.Controls.Add(this.lblMsgFornec);
            this.gbFornecedor.Controls.Add(this.btnFornecedor);
            this.gbFornecedor.Controls.Add(this.txtNomeFornecedor);
            this.gbFornecedor.Controls.Add(this.txt_cnpjFornec);
            this.gbFornecedor.Controls.Add(this.lblCNPJFornecedor);
            this.gbFornecedor.Location = new System.Drawing.Point(424, 6);
            this.gbFornecedor.Name = "gbFornecedor";
            this.gbFornecedor.Size = new System.Drawing.Size(475, 102);
            this.gbFornecedor.TabIndex = 1;
            this.gbFornecedor.TabStop = false;
            this.gbFornecedor.Text = "Fornecedor";
            // 
            // lblMsgFornec
            // 
            this.lblMsgFornec.AutoSize = true;
            this.lblMsgFornec.Location = new System.Drawing.Point(190, 41);
            this.lblMsgFornec.Name = "lblMsgFornec";
            this.lblMsgFornec.Size = new System.Drawing.Size(83, 15);
            this.lblMsgFornec.TabIndex = 26;
            this.lblMsgFornec.Text = "</Mensagem>";
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Location = new System.Drawing.Point(156, 38);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(28, 23);
            this.btnFornecedor.TabIndex = 1;
            this.btnFornecedor.Text = "+";
            this.btnFornecedor.UseVisualStyleBackColor = true;
            this.btnFornecedor.Click += new System.EventHandler(this.btnNovoFornecedor_Click);
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFornecedor.Location = new System.Drawing.Point(9, 67);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(460, 23);
            this.txtNomeFornecedor.TabIndex = 2;
            // 
            // txt_cnpjFornec
            // 
            this.txt_cnpjFornec.Location = new System.Drawing.Point(9, 38);
            this.txt_cnpjFornec.Name = "txt_cnpjFornec";
            this.txt_cnpjFornec.Size = new System.Drawing.Size(143, 23);
            this.txt_cnpjFornec.TabIndex = 0;
            this.txt_cnpjFornec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_cnpjFornec_KeyDown);
            this.txt_cnpjFornec.Leave += new System.EventHandler(this.txt_cnpjFornec_Leave);
            // 
            // lblCNPJFornecedor
            // 
            this.lblCNPJFornecedor.AutoSize = true;
            this.lblCNPJFornecedor.Location = new System.Drawing.Point(6, 19);
            this.lblCNPJFornecedor.Name = "lblCNPJFornecedor";
            this.lblCNPJFornecedor.Size = new System.Drawing.Size(32, 15);
            this.lblCNPJFornecedor.TabIndex = 22;
            this.lblCNPJFornecedor.Text = "CNPJ";
            // 
            // gbEmpresa
            // 
            this.gbEmpresa.Controls.Add(this.mtxtCNPJEmpresa);
            this.gbEmpresa.Controls.Add(this.lblNomeEmpresa);
            this.gbEmpresa.Controls.Add(this.lblMsgEmpresa);
            this.gbEmpresa.Controls.Add(this.lblCNPJEmpresa);
            this.gbEmpresa.Location = new System.Drawing.Point(7, 6);
            this.gbEmpresa.Name = "gbEmpresa";
            this.gbEmpresa.Size = new System.Drawing.Size(411, 102);
            this.gbEmpresa.TabIndex = 0;
            this.gbEmpresa.TabStop = false;
            this.gbEmpresa.Text = "Empresa";
            // 
            // mtxtCNPJEmpresa
            // 
            this.mtxtCNPJEmpresa.Location = new System.Drawing.Point(9, 38);
            this.mtxtCNPJEmpresa.Mask = "00\\.000\\.000/0000-00";
            this.mtxtCNPJEmpresa.Name = "mtxtCNPJEmpresa";
            this.mtxtCNPJEmpresa.Size = new System.Drawing.Size(143, 23);
            this.mtxtCNPJEmpresa.TabIndex = 24;
            this.mtxtCNPJEmpresa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxtCNPJEmpresa_KeyDown);
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEmpresa.Location = new System.Drawing.Point(6, 70);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(110, 15);
            this.lblNomeEmpresa.TabIndex = 23;
            this.lblNomeEmpresa.Text = "</Nome empresa>";
            // 
            // lblMsgEmpresa
            // 
            this.lblMsgEmpresa.AutoSize = true;
            this.lblMsgEmpresa.Location = new System.Drawing.Point(158, 41);
            this.lblMsgEmpresa.Name = "lblMsgEmpresa";
            this.lblMsgEmpresa.Size = new System.Drawing.Size(83, 15);
            this.lblMsgEmpresa.TabIndex = 22;
            this.lblMsgEmpresa.Text = "</Mensagem>";
            // 
            // lblCNPJEmpresa
            // 
            this.lblCNPJEmpresa.AutoSize = true;
            this.lblCNPJEmpresa.Location = new System.Drawing.Point(6, 19);
            this.lblCNPJEmpresa.Name = "lblCNPJEmpresa";
            this.lblCNPJEmpresa.Size = new System.Drawing.Size(32, 15);
            this.lblCNPJEmpresa.TabIndex = 19;
            this.lblCNPJEmpresa.Text = "CNPJ";
            // 
            // gbImpostoNota
            // 
            this.gbImpostoNota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbImpostoNota.Controls.Add(this.lblTotalNota);
            this.gbImpostoNota.Controls.Add(this.txtValorTotal);
            this.gbImpostoNota.Controls.Add(this.lblVL_ipi);
            this.gbImpostoNota.Controls.Add(this.txtValorIPI);
            this.gbImpostoNota.Controls.Add(this.lblOutrasDespesas);
            this.gbImpostoNota.Controls.Add(this.txtOutrasDesp);
            this.gbImpostoNota.Controls.Add(this.lblVL_Desconto);
            this.gbImpostoNota.Controls.Add(this.txtValorDesconto);
            this.gbImpostoNota.Controls.Add(this.lblVL_Seguro);
            this.gbImpostoNota.Controls.Add(this.txtValorSeguro);
            this.gbImpostoNota.Controls.Add(this.lblVL_Frete);
            this.gbImpostoNota.Controls.Add(this.txtValorFrete);
            this.gbImpostoNota.Controls.Add(this.lblValorTotalItens);
            this.gbImpostoNota.Controls.Add(this.txtValorItens);
            this.gbImpostoNota.Controls.Add(this.lblVL_Importacao);
            this.gbImpostoNota.Controls.Add(this.txt_vlImportacao);
            this.gbImpostoNota.Controls.Add(this.lblVL_icmsST);
            this.gbImpostoNota.Controls.Add(this.txt_vlICMSst);
            this.gbImpostoNota.Controls.Add(this.lblBC_icmsST);
            this.gbImpostoNota.Controls.Add(this.txt_bcICMSst);
            this.gbImpostoNota.Controls.Add(this.lblVL_icms);
            this.gbImpostoNota.Controls.Add(this.txt_vlICMS);
            this.gbImpostoNota.Controls.Add(this.lblBC_ICMS);
            this.gbImpostoNota.Controls.Add(this.txt_bcICMS);
            this.gbImpostoNota.Location = new System.Drawing.Point(7, 260);
            this.gbImpostoNota.Name = "gbImpostoNota";
            this.gbImpostoNota.Size = new System.Drawing.Size(893, 118);
            this.gbImpostoNota.TabIndex = 3;
            this.gbImpostoNota.TabStop = false;
            this.gbImpostoNota.Text = "Cálculos";
            // 
            // lblTotalNota
            // 
            this.lblTotalNota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalNota.AutoSize = true;
            this.lblTotalNota.Location = new System.Drawing.Point(742, 63);
            this.lblTotalNota.Name = "lblTotalNota";
            this.lblTotalNota.Size = new System.Drawing.Size(112, 15);
            this.lblTotalNota.TabIndex = 23;
            this.lblTotalNota.Text = "Valor Total da Nota";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorTotal.Location = new System.Drawing.Point(745, 81);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(139, 23);
            this.txtValorTotal.TabIndex = 11;
            // 
            // lblVL_ipi
            // 
            this.lblVL_ipi.AutoSize = true;
            this.lblVL_ipi.Location = new System.Drawing.Point(496, 63);
            this.lblVL_ipi.Name = "lblVL_ipi";
            this.lblVL_ipi.Size = new System.Drawing.Size(54, 15);
            this.lblVL_ipi.TabIndex = 21;
            this.lblVL_ipi.Text = "Valor IPI";
            // 
            // txtValorIPI
            // 
            this.txtValorIPI.Location = new System.Drawing.Point(499, 81);
            this.txtValorIPI.Name = "txtValorIPI";
            this.txtValorIPI.Size = new System.Drawing.Size(100, 23);
            this.txtValorIPI.TabIndex = 10;
            // 
            // lblOutrasDespesas
            // 
            this.lblOutrasDespesas.AutoSize = true;
            this.lblOutrasDespesas.Location = new System.Drawing.Point(330, 63);
            this.lblOutrasDespesas.Name = "lblOutrasDespesas";
            this.lblOutrasDespesas.Size = new System.Drawing.Size(163, 15);
            this.lblOutrasDespesas.TabIndex = 19;
            this.lblOutrasDespesas.Text = "Outras Despesas Acessórias";
            // 
            // txtOutrasDesp
            // 
            this.txtOutrasDesp.Location = new System.Drawing.Point(333, 81);
            this.txtOutrasDesp.Name = "txtOutrasDesp";
            this.txtOutrasDesp.Size = new System.Drawing.Size(160, 23);
            this.txtOutrasDesp.TabIndex = 9;
            // 
            // lblVL_Desconto
            // 
            this.lblVL_Desconto.AutoSize = true;
            this.lblVL_Desconto.Location = new System.Drawing.Point(224, 63);
            this.lblVL_Desconto.Name = "lblVL_Desconto";
            this.lblVL_Desconto.Size = new System.Drawing.Size(58, 15);
            this.lblVL_Desconto.TabIndex = 17;
            this.lblVL_Desconto.Text = "Desconto";
            // 
            // txtValorDesconto
            // 
            this.txtValorDesconto.Location = new System.Drawing.Point(227, 81);
            this.txtValorDesconto.Name = "txtValorDesconto";
            this.txtValorDesconto.Size = new System.Drawing.Size(100, 23);
            this.txtValorDesconto.TabIndex = 8;
            // 
            // lblVL_Seguro
            // 
            this.lblVL_Seguro.AutoSize = true;
            this.lblVL_Seguro.Location = new System.Drawing.Point(118, 63);
            this.lblVL_Seguro.Name = "lblVL_Seguro";
            this.lblVL_Seguro.Size = new System.Drawing.Size(93, 15);
            this.lblVL_Seguro.TabIndex = 15;
            this.lblVL_Seguro.Text = "Valor do Seguro";
            // 
            // txtValorSeguro
            // 
            this.txtValorSeguro.Location = new System.Drawing.Point(121, 81);
            this.txtValorSeguro.Name = "txtValorSeguro";
            this.txtValorSeguro.Size = new System.Drawing.Size(100, 23);
            this.txtValorSeguro.TabIndex = 7;
            // 
            // lblVL_Frete
            // 
            this.lblVL_Frete.AutoSize = true;
            this.lblVL_Frete.Location = new System.Drawing.Point(6, 63);
            this.lblVL_Frete.Name = "lblVL_Frete";
            this.lblVL_Frete.Size = new System.Drawing.Size(83, 15);
            this.lblVL_Frete.TabIndex = 13;
            this.lblVL_Frete.Text = "Valor do Frete";
            // 
            // txtValorFrete
            // 
            this.txtValorFrete.Location = new System.Drawing.Point(9, 81);
            this.txtValorFrete.Name = "txtValorFrete";
            this.txtValorFrete.Size = new System.Drawing.Size(106, 23);
            this.txtValorFrete.TabIndex = 6;
            // 
            // lblValorTotalItens
            // 
            this.lblValorTotalItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorTotalItens.AutoSize = true;
            this.lblValorTotalItens.Location = new System.Drawing.Point(742, 19);
            this.lblValorTotalItens.Name = "lblValorTotalItens";
            this.lblValorTotalItens.Size = new System.Drawing.Size(142, 15);
            this.lblValorTotalItens.TabIndex = 11;
            this.lblValorTotalItens.Text = "Valor Total dos Produtos";
            // 
            // txtValorItens
            // 
            this.txtValorItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorItens.Location = new System.Drawing.Point(745, 37);
            this.txtValorItens.Name = "txtValorItens";
            this.txtValorItens.Size = new System.Drawing.Size(139, 23);
            this.txtValorItens.TabIndex = 5;
            // 
            // lblVL_Importacao
            // 
            this.lblVL_Importacao.AutoSize = true;
            this.lblVL_Importacao.Location = new System.Drawing.Point(449, 19);
            this.lblVL_Importacao.Name = "lblVL_Importacao";
            this.lblVL_Importacao.Size = new System.Drawing.Size(130, 15);
            this.lblVL_Importacao.TabIndex = 9;
            this.lblVL_Importacao.Text = "Valor Imp. Importação";
            // 
            // txt_vlImportacao
            // 
            this.txt_vlImportacao.Location = new System.Drawing.Point(452, 37);
            this.txt_vlImportacao.Name = "txt_vlImportacao";
            this.txt_vlImportacao.Size = new System.Drawing.Size(127, 23);
            this.txt_vlImportacao.TabIndex = 4;
            // 
            // lblVL_icmsST
            // 
            this.lblVL_icmsST.AutoSize = true;
            this.lblVL_icmsST.Location = new System.Drawing.Point(330, 19);
            this.lblVL_icmsST.Name = "lblVL_icmsST";
            this.lblVL_icmsST.Size = new System.Drawing.Size(116, 15);
            this.lblVL_icmsST.TabIndex = 7;
            this.lblVL_icmsST.Text = "Valor do ICMS Subs.";
            // 
            // txt_vlICMSst
            // 
            this.txt_vlICMSst.Location = new System.Drawing.Point(333, 37);
            this.txt_vlICMSst.Name = "txt_vlICMSst";
            this.txt_vlICMSst.Size = new System.Drawing.Size(113, 23);
            this.txt_vlICMSst.TabIndex = 3;
            // 
            // lblBC_icmsST
            // 
            this.lblBC_icmsST.AutoSize = true;
            this.lblBC_icmsST.Location = new System.Drawing.Point(224, 19);
            this.lblBC_icmsST.Name = "lblBC_icmsST";
            this.lblBC_icmsST.Size = new System.Drawing.Size(101, 15);
            this.lblBC_icmsST.TabIndex = 5;
            this.lblBC_icmsST.Text = "BC do ICMS Subs.";
            // 
            // txt_bcICMSst
            // 
            this.txt_bcICMSst.Location = new System.Drawing.Point(227, 37);
            this.txt_bcICMSst.Name = "txt_bcICMSst";
            this.txt_bcICMSst.Size = new System.Drawing.Size(100, 23);
            this.txt_bcICMSst.TabIndex = 2;
            // 
            // lblVL_icms
            // 
            this.lblVL_icms.AutoSize = true;
            this.lblVL_icms.Location = new System.Drawing.Point(118, 19);
            this.lblVL_icms.Name = "lblVL_icms";
            this.lblVL_icms.Size = new System.Drawing.Size(84, 15);
            this.lblVL_icms.TabIndex = 3;
            this.lblVL_icms.Text = "Valor do ICMS";
            // 
            // txt_vlICMS
            // 
            this.txt_vlICMS.Location = new System.Drawing.Point(121, 37);
            this.txt_vlICMS.Name = "txt_vlICMS";
            this.txt_vlICMS.Size = new System.Drawing.Size(100, 23);
            this.txt_vlICMS.TabIndex = 1;
            // 
            // lblBC_ICMS
            // 
            this.lblBC_ICMS.AutoSize = true;
            this.lblBC_ICMS.Location = new System.Drawing.Point(6, 19);
            this.lblBC_ICMS.Name = "lblBC_ICMS";
            this.lblBC_ICMS.Size = new System.Drawing.Size(109, 15);
            this.lblBC_ICMS.TabIndex = 1;
            this.lblBC_ICMS.Text = "Base Cálculo ICMS";
            // 
            // txt_bcICMS
            // 
            this.txt_bcICMS.Location = new System.Drawing.Point(9, 37);
            this.txt_bcICMS.Name = "txt_bcICMS";
            this.txt_bcICMS.Size = new System.Drawing.Size(106, 23);
            this.txt_bcICMS.TabIndex = 0;
            // 
            // gbCabecalhoNota
            // 
            this.gbCabecalhoNota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCabecalhoNota.Controls.Add(this.lblTpNota);
            this.gbCabecalhoNota.Controls.Add(this.cbTipoNota);
            this.gbCabecalhoNota.Controls.Add(this.lblEntradaSaida);
            this.gbCabecalhoNota.Controls.Add(this.lblEmissao);
            this.gbCabecalhoNota.Controls.Add(this.dtEntradaSaida);
            this.gbCabecalhoNota.Controls.Add(this.dtEmissao);
            this.gbCabecalhoNota.Controls.Add(this.txtNatOp);
            this.gbCabecalhoNota.Controls.Add(this.lblNatOper);
            this.gbCabecalhoNota.Controls.Add(this.txtProtocolo);
            this.gbCabecalhoNota.Controls.Add(this.lblProtocolo);
            this.gbCabecalhoNota.Controls.Add(this.txtChaveAcesso);
            this.gbCabecalhoNota.Controls.Add(this.lblChaveAcesso);
            this.gbCabecalhoNota.Controls.Add(this.txtSerie);
            this.gbCabecalhoNota.Controls.Add(this.lblSerie);
            this.gbCabecalhoNota.Controls.Add(this.txtNumeroNota);
            this.gbCabecalhoNota.Controls.Add(this.lblNumeroNota);
            this.gbCabecalhoNota.Controls.Add(this.btnArquivoXML);
            this.gbCabecalhoNota.Controls.Add(this.lblArquivoXML);
            this.gbCabecalhoNota.Controls.Add(this.txtArquivoXML);
            this.gbCabecalhoNota.Location = new System.Drawing.Point(6, 114);
            this.gbCabecalhoNota.Name = "gbCabecalhoNota";
            this.gbCabecalhoNota.Size = new System.Drawing.Size(894, 140);
            this.gbCabecalhoNota.TabIndex = 2;
            this.gbCabecalhoNota.TabStop = false;
            this.gbCabecalhoNota.Text = "Nota Fiscal";
            // 
            // lblTpNota
            // 
            this.lblTpNota.AutoSize = true;
            this.lblTpNota.Location = new System.Drawing.Point(7, 19);
            this.lblTpNota.Name = "lblTpNota";
            this.lblTpNota.Size = new System.Drawing.Size(76, 15);
            this.lblTpNota.TabIndex = 18;
            this.lblTpNota.Text = "Tipo de Nota";
            // 
            // cbTipoNota
            // 
            this.cbTipoNota.FormattingEnabled = true;
            this.cbTipoNota.Location = new System.Drawing.Point(89, 16);
            this.cbTipoNota.Name = "cbTipoNota";
            this.cbTipoNota.Size = new System.Drawing.Size(153, 23);
            this.cbTipoNota.TabIndex = 0;
            this.cbTipoNota.Text = "Eletrônica";
            // 
            // lblEntradaSaida
            // 
            this.lblEntradaSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEntradaSaida.AutoSize = true;
            this.lblEntradaSaida.Location = new System.Drawing.Point(778, 87);
            this.lblEntradaSaida.Name = "lblEntradaSaida";
            this.lblEntradaSaida.Size = new System.Drawing.Size(85, 15);
            this.lblEntradaSaida.TabIndex = 16;
            this.lblEntradaSaida.Text = "Entrada/Saída";
            // 
            // lblEmissao
            // 
            this.lblEmissao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmissao.AutoSize = true;
            this.lblEmissao.Location = new System.Drawing.Point(778, 43);
            this.lblEmissao.Name = "lblEmissao";
            this.lblEmissao.Size = new System.Drawing.Size(53, 15);
            this.lblEmissao.TabIndex = 15;
            this.lblEmissao.Text = "Emissão";
            // 
            // dtEntradaSaida
            // 
            this.dtEntradaSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtEntradaSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEntradaSaida.Location = new System.Drawing.Point(781, 105);
            this.dtEntradaSaida.Name = "dtEntradaSaida";
            this.dtEntradaSaida.Size = new System.Drawing.Size(107, 23);
            this.dtEntradaSaida.TabIndex = 8;
            // 
            // dtEmissao
            // 
            this.dtEmissao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEmissao.Location = new System.Drawing.Point(781, 61);
            this.dtEmissao.Name = "dtEmissao";
            this.dtEmissao.Size = new System.Drawing.Size(107, 23);
            this.dtEmissao.TabIndex = 7;
            // 
            // txtNatOp
            // 
            this.txtNatOp.Location = new System.Drawing.Point(288, 105);
            this.txtNatOp.Name = "txtNatOp";
            this.txtNatOp.Size = new System.Drawing.Size(416, 23);
            this.txtNatOp.TabIndex = 6;
            // 
            // lblNatOper
            // 
            this.lblNatOper.AutoSize = true;
            this.lblNatOper.Location = new System.Drawing.Point(285, 87);
            this.lblNatOper.Name = "lblNatOper";
            this.lblNatOper.Size = new System.Drawing.Size(128, 15);
            this.lblNatOper.TabIndex = 11;
            this.lblNatOper.Text = "Natureza da operação";
            // 
            // txtProtocolo
            // 
            this.txtProtocolo.Location = new System.Drawing.Point(10, 105);
            this.txtProtocolo.Name = "txtProtocolo";
            this.txtProtocolo.Size = new System.Drawing.Size(272, 23);
            this.txtProtocolo.TabIndex = 5;
            // 
            // lblProtocolo
            // 
            this.lblProtocolo.AutoSize = true;
            this.lblProtocolo.Location = new System.Drawing.Point(7, 87);
            this.lblProtocolo.Name = "lblProtocolo";
            this.lblProtocolo.Size = new System.Drawing.Size(146, 15);
            this.lblProtocolo.TabIndex = 9;
            this.lblProtocolo.Text = "Protocolo de autorização";
            // 
            // txtChaveAcesso
            // 
            this.txtChaveAcesso.Location = new System.Drawing.Point(9, 61);
            this.txtChaveAcesso.Name = "txtChaveAcesso";
            this.txtChaveAcesso.Size = new System.Drawing.Size(319, 23);
            this.txtChaveAcesso.TabIndex = 2;
            this.txtChaveAcesso.Text = "42190602483544000187550010000810991317908896";
            // 
            // lblChaveAcesso
            // 
            this.lblChaveAcesso.AutoSize = true;
            this.lblChaveAcesso.Location = new System.Drawing.Point(6, 43);
            this.lblChaveAcesso.Name = "lblChaveAcesso";
            this.lblChaveAcesso.Size = new System.Drawing.Size(97, 15);
            this.lblChaveAcesso.TabIndex = 7;
            this.lblChaveAcesso.Text = "Chave de acesso";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(440, 61);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(31, 23);
            this.txtSerie.TabIndex = 4;
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(437, 43);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(34, 15);
            this.lblSerie.TabIndex = 5;
            this.lblSerie.Text = "Série";
            // 
            // txtNumeroNota
            // 
            this.txtNumeroNota.Location = new System.Drawing.Point(334, 61);
            this.txtNumeroNota.Name = "txtNumeroNota";
            this.txtNumeroNota.Size = new System.Drawing.Size(100, 23);
            this.txtNumeroNota.TabIndex = 3;
            // 
            // lblNumeroNota
            // 
            this.lblNumeroNota.AutoSize = true;
            this.lblNumeroNota.Location = new System.Drawing.Point(331, 43);
            this.lblNumeroNota.Name = "lblNumeroNota";
            this.lblNumeroNota.Size = new System.Drawing.Size(49, 15);
            this.lblNumeroNota.TabIndex = 3;
            this.lblNumeroNota.Text = "Nº Nota";
            // 
            // btnArquivoXML
            // 
            this.btnArquivoXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArquivoXML.Location = new System.Drawing.Point(860, 15);
            this.btnArquivoXML.Name = "btnArquivoXML";
            this.btnArquivoXML.Size = new System.Drawing.Size(28, 23);
            this.btnArquivoXML.TabIndex = 1;
            this.btnArquivoXML.Text = "...";
            this.btnArquivoXML.UseVisualStyleBackColor = true;
            // 
            // lblArquivoXML
            // 
            this.lblArquivoXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArquivoXML.AutoSize = true;
            this.lblArquivoXML.Location = new System.Drawing.Point(256, 19);
            this.lblArquivoXML.Name = "lblArquivoXML";
            this.lblArquivoXML.Size = new System.Drawing.Size(76, 15);
            this.lblArquivoXML.TabIndex = 1;
            this.lblArquivoXML.Text = "Arquivo XML";
            // 
            // txtArquivoXML
            // 
            this.txtArquivoXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArquivoXML.Location = new System.Drawing.Point(338, 15);
            this.txtArquivoXML.Name = "txtArquivoXML";
            this.txtArquivoXML.Size = new System.Drawing.Size(516, 23);
            this.txtArquivoXML.TabIndex = 0;
            // 
            // tabProdutos
            // 
            this.tabProdutos.Controls.Add(this.btnEditarCadProduto);
            this.tabProdutos.Controls.Add(this.btnRemoverItem);
            this.tabProdutos.Controls.Add(this.dgvProdutosItens);
            this.tabProdutos.Controls.Add(this.gbItem);
            this.tabProdutos.Location = new System.Drawing.Point(4, 24);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProdutos.Size = new System.Drawing.Size(906, 384);
            this.tabProdutos.TabIndex = 1;
            this.tabProdutos.Text = "Produtos";
            this.tabProdutos.UseVisualStyleBackColor = true;
            // 
            // btnEditarCadProduto
            // 
            this.btnEditarCadProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarCadProduto.Location = new System.Drawing.Point(789, 355);
            this.btnEditarCadProduto.Name = "btnEditarCadProduto";
            this.btnEditarCadProduto.Size = new System.Drawing.Size(111, 23);
            this.btnEditarCadProduto.TabIndex = 51;
            this.btnEditarCadProduto.Text = "Editar Cadastro";
            this.btnEditarCadProduto.UseVisualStyleBackColor = true;
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoverItem.Location = new System.Drawing.Point(693, 355);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(90, 23);
            this.btnRemoverItem.TabIndex = 50;
            this.btnRemoverItem.Text = "Remover Item";
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            // 
            // dgvProdutosItens
            // 
            this.dgvProdutosItens.AllowUserToAddRows = false;
            this.dgvProdutosItens.AllowUserToDeleteRows = false;
            this.dgvProdutosItens.AllowUserToResizeRows = false;
            this.dgvProdutosItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutosItens.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutosItens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProdutosItens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvProdutosItens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProdutosItens.ColumnHeadersHeight = 30;
            this.dgvProdutosItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProdutosItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem,
            this.colID,
            this.colCodBarras,
            this.colNome,
            this.colCST,
            this.colCFOP,
            this.colUN,
            this.colQTD,
            this.colVLUnitario,
            this.colVLTotal,
            this.colDesconto,
            this.colBCicms,
            this.colVLicms,
            this.colVLipi,
            this.colAlqICMS,
            this.colAlqIPI});
            this.dgvProdutosItens.Location = new System.Drawing.Point(6, 152);
            this.dgvProdutosItens.Name = "dgvProdutosItens";
            this.dgvProdutosItens.ReadOnly = true;
            this.dgvProdutosItens.RowHeadersVisible = false;
            this.dgvProdutosItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutosItens.Size = new System.Drawing.Size(894, 197);
            this.dgvProdutosItens.TabIndex = 28;
            // 
            // colItem
            // 
            this.colItem.HeaderText = "Item";
            this.colItem.Name = "colItem";
            this.colItem.ReadOnly = true;
            this.colItem.Width = 40;
            // 
            // colID
            // 
            this.colID.FillWeight = 15F;
            this.colID.HeaderText = "Cód.";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 70;
            // 
            // colCodBarras
            // 
            this.colCodBarras.HeaderText = "Código de Barras";
            this.colCodBarras.Name = "colCodBarras";
            this.colCodBarras.ReadOnly = true;
            this.colCodBarras.Width = 150;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 200;
            // 
            // colCST
            // 
            this.colCST.HeaderText = "CST";
            this.colCST.Name = "colCST";
            this.colCST.ReadOnly = true;
            // 
            // colCFOP
            // 
            this.colCFOP.HeaderText = "CFOP";
            this.colCFOP.Name = "colCFOP";
            this.colCFOP.ReadOnly = true;
            // 
            // colUN
            // 
            this.colUN.HeaderText = "UN";
            this.colUN.Name = "colUN";
            this.colUN.ReadOnly = true;
            // 
            // colQTD
            // 
            this.colQTD.HeaderText = "QTD";
            this.colQTD.Name = "colQTD";
            this.colQTD.ReadOnly = true;
            // 
            // colVLUnitario
            // 
            this.colVLUnitario.HeaderText = "VL.Unitário";
            this.colVLUnitario.Name = "colVLUnitario";
            this.colVLUnitario.ReadOnly = true;
            // 
            // colVLTotal
            // 
            this.colVLTotal.HeaderText = "VL.Total";
            this.colVLTotal.Name = "colVLTotal";
            this.colVLTotal.ReadOnly = true;
            // 
            // colDesconto
            // 
            this.colDesconto.HeaderText = "VL.Desconto";
            this.colDesconto.Name = "colDesconto";
            this.colDesconto.ReadOnly = true;
            // 
            // colBCicms
            // 
            this.colBCicms.HeaderText = "BC ICMS";
            this.colBCicms.Name = "colBCicms";
            this.colBCicms.ReadOnly = true;
            // 
            // colVLicms
            // 
            this.colVLicms.HeaderText = "VL.ICMS";
            this.colVLicms.Name = "colVLicms";
            this.colVLicms.ReadOnly = true;
            // 
            // colVLipi
            // 
            this.colVLipi.HeaderText = "VL.IPI";
            this.colVLipi.Name = "colVLipi";
            this.colVLipi.ReadOnly = true;
            // 
            // colAlqICMS
            // 
            this.colAlqICMS.HeaderText = "Aliq.ICMS";
            this.colAlqICMS.Name = "colAlqICMS";
            this.colAlqICMS.ReadOnly = true;
            // 
            // colAlqIPI
            // 
            this.colAlqIPI.HeaderText = "Aliq.IPI";
            this.colAlqIPI.Name = "colAlqIPI";
            this.colAlqIPI.ReadOnly = true;
            // 
            // gbItem
            // 
            this.gbItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbItem.Controls.Add(this.txtProdutoQtdEntrada);
            this.gbItem.Controls.Add(this.lblProdQtdEntrada);
            this.gbItem.Controls.Add(this.txtProdutoQTD);
            this.gbItem.Controls.Add(this.lblProdQtdUN);
            this.gbItem.Controls.Add(this.txtProdutoQtdEmb);
            this.gbItem.Controls.Add(this.lblProdQtdEmb);
            this.gbItem.Controls.Add(this.lblProdUN);
            this.gbItem.Controls.Add(this.cboxProdutoUN);
            this.gbItem.Controls.Add(this.lblProdutoCod);
            this.gbItem.Controls.Add(this.txtProdutoCod);
            this.gbItem.Controls.Add(this.txtProdutoDesconto);
            this.gbItem.Controls.Add(this.lblProdDesc);
            this.gbItem.Controls.Add(this.btnAdicionarItem);
            this.gbItem.Controls.Add(this.txtProdutoAlqIPI);
            this.gbItem.Controls.Add(this.lblProdAlqIPI);
            this.gbItem.Controls.Add(this.btnBuscarProduto);
            this.gbItem.Controls.Add(this.txtProdutoAlqICMS);
            this.gbItem.Controls.Add(this.lblProdAlqICMS);
            this.gbItem.Controls.Add(this.txtProdutoVL_IPI);
            this.gbItem.Controls.Add(this.lblProdVl_IPI);
            this.gbItem.Controls.Add(this.lblProdutoNome);
            this.gbItem.Controls.Add(this.txtProdutoVL_ICMS);
            this.gbItem.Controls.Add(this.lblProdVl_ICMS);
            this.gbItem.Controls.Add(this.txtProdutoBC_ICMS);
            this.gbItem.Controls.Add(this.lblProdBC_ICMS);
            this.gbItem.Controls.Add(this.txtProdutoCFOP);
            this.gbItem.Controls.Add(this.lblProdCFOP);
            this.gbItem.Controls.Add(this.txtProdutoCST);
            this.gbItem.Controls.Add(this.lblProdCST);
            this.gbItem.Controls.Add(this.txtProdutoDescricao);
            this.gbItem.Controls.Add(this.txtProdutoValorUN);
            this.gbItem.Controls.Add(this.lblProdVlUn);
            this.gbItem.Controls.Add(this.txtProdutoValorTotal);
            this.gbItem.Controls.Add(this.lblProdVlTotal);
            this.gbItem.Controls.Add(this.lblProdCodBarras);
            this.gbItem.Controls.Add(this.txtProdutoCodbarras);
            this.gbItem.Location = new System.Drawing.Point(6, 6);
            this.gbItem.Name = "gbItem";
            this.gbItem.Size = new System.Drawing.Size(894, 140);
            this.gbItem.TabIndex = 0;
            this.gbItem.TabStop = false;
            this.gbItem.Text = "Item";
            // 
            // txtProdutoQtdEntrada
            // 
            this.txtProdutoQtdEntrada.Location = new System.Drawing.Point(294, 83);
            this.txtProdutoQtdEntrada.Name = "txtProdutoQtdEntrada";
            this.txtProdutoQtdEntrada.ReadOnly = true;
            this.txtProdutoQtdEntrada.Size = new System.Drawing.Size(73, 23);
            this.txtProdutoQtdEntrada.TabIndex = 47;
            this.txtProdutoQtdEntrada.Text = "2";
            // 
            // lblProdQtdEntrada
            // 
            this.lblProdQtdEntrada.AutoSize = true;
            this.lblProdQtdEntrada.Location = new System.Drawing.Point(294, 65);
            this.lblProdQtdEntrada.Name = "lblProdQtdEntrada";
            this.lblProdQtdEntrada.Size = new System.Drawing.Size(73, 15);
            this.lblProdQtdEntrada.TabIndex = 46;
            this.lblProdQtdEntrada.Text = "Qtd.Entrada";
            // 
            // txtProdutoQTD
            // 
            this.txtProdutoQTD.Location = new System.Drawing.Point(238, 83);
            this.txtProdutoQTD.Name = "txtProdutoQTD";
            this.txtProdutoQTD.Size = new System.Drawing.Size(50, 23);
            this.txtProdutoQTD.TabIndex = 45;
            this.txtProdutoQTD.Text = "2";
            // 
            // lblProdQtdUN
            // 
            this.lblProdQtdUN.AutoSize = true;
            this.lblProdQtdUN.Location = new System.Drawing.Point(238, 65);
            this.lblProdQtdUN.Name = "lblProdQtdUN";
            this.lblProdQtdUN.Size = new System.Drawing.Size(46, 15);
            this.lblProdQtdUN.TabIndex = 44;
            this.lblProdQtdUN.Text = "Qtd.UN";
            // 
            // txtProdutoQtdEmb
            // 
            this.txtProdutoQtdEmb.Location = new System.Drawing.Point(171, 83);
            this.txtProdutoQtdEmb.Name = "txtProdutoQtdEmb";
            this.txtProdutoQtdEmb.Size = new System.Drawing.Size(61, 23);
            this.txtProdutoQtdEmb.TabIndex = 43;
            // 
            // lblProdQtdEmb
            // 
            this.lblProdQtdEmb.AutoSize = true;
            this.lblProdQtdEmb.Location = new System.Drawing.Point(171, 65);
            this.lblProdQtdEmb.Name = "lblProdQtdEmb";
            this.lblProdQtdEmb.Size = new System.Drawing.Size(53, 15);
            this.lblProdQtdEmb.TabIndex = 42;
            this.lblProdQtdEmb.Text = "Qtd.Emb";
            // 
            // lblProdUN
            // 
            this.lblProdUN.AutoSize = true;
            this.lblProdUN.Location = new System.Drawing.Point(111, 65);
            this.lblProdUN.Name = "lblProdUN";
            this.lblProdUN.Size = new System.Drawing.Size(23, 15);
            this.lblProdUN.TabIndex = 41;
            this.lblProdUN.Text = "UN";
            // 
            // cboxProdutoUN
            // 
            this.cboxProdutoUN.FormattingEnabled = true;
            this.cboxProdutoUN.Location = new System.Drawing.Point(111, 83);
            this.cboxProdutoUN.Name = "cboxProdutoUN";
            this.cboxProdutoUN.Size = new System.Drawing.Size(54, 23);
            this.cboxProdutoUN.TabIndex = 40;
            this.cboxProdutoUN.Text = "CX";
            // 
            // lblProdutoCod
            // 
            this.lblProdutoCod.AutoSize = true;
            this.lblProdutoCod.Location = new System.Drawing.Point(6, 19);
            this.lblProdutoCod.Name = "lblProdutoCod";
            this.lblProdutoCod.Size = new System.Drawing.Size(45, 15);
            this.lblProdutoCod.TabIndex = 33;
            this.lblProdutoCod.Text = "Código";
            // 
            // txtProdutoCod
            // 
            this.txtProdutoCod.Location = new System.Drawing.Point(6, 37);
            this.txtProdutoCod.Name = "txtProdutoCod";
            this.txtProdutoCod.Size = new System.Drawing.Size(75, 23);
            this.txtProdutoCod.TabIndex = 32;
            // 
            // txtProdutoDesconto
            // 
            this.txtProdutoDesconto.Location = new System.Drawing.Point(449, 83);
            this.txtProdutoDesconto.Name = "txtProdutoDesconto";
            this.txtProdutoDesconto.Size = new System.Drawing.Size(63, 23);
            this.txtProdutoDesconto.TabIndex = 31;
            // 
            // lblProdDesc
            // 
            this.lblProdDesc.AutoSize = true;
            this.lblProdDesc.Location = new System.Drawing.Point(449, 65);
            this.lblProdDesc.Name = "lblProdDesc";
            this.lblProdDesc.Size = new System.Drawing.Size(58, 15);
            this.lblProdDesc.TabIndex = 30;
            this.lblProdDesc.Text = "Desconto";
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarItem.Location = new System.Drawing.Point(798, 111);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(90, 23);
            this.btnAdicionarItem.TabIndex = 29;
            this.btnAdicionarItem.Text = "Adicionar";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);
            // 
            // txtProdutoAlqIPI
            // 
            this.txtProdutoAlqIPI.Location = new System.Drawing.Point(831, 83);
            this.txtProdutoAlqIPI.Name = "txtProdutoAlqIPI";
            this.txtProdutoAlqIPI.Size = new System.Drawing.Size(57, 23);
            this.txtProdutoAlqIPI.TabIndex = 28;
            // 
            // lblProdAlqIPI
            // 
            this.lblProdAlqIPI.AutoSize = true;
            this.lblProdAlqIPI.Location = new System.Drawing.Point(831, 65);
            this.lblProdAlqIPI.Name = "lblProdAlqIPI";
            this.lblProdAlqIPI.Size = new System.Drawing.Size(47, 15);
            this.lblProdAlqIPI.TabIndex = 27;
            this.lblProdAlqIPI.Text = "Aliq.IPI";
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.Location = new System.Drawing.Point(537, 37);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(26, 23);
            this.btnBuscarProduto.TabIndex = 24;
            this.btnBuscarProduto.Text = "+";
            this.btnBuscarProduto.UseVisualStyleBackColor = true;
            this.btnBuscarProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // txtProdutoAlqICMS
            // 
            this.txtProdutoAlqICMS.Location = new System.Drawing.Point(768, 83);
            this.txtProdutoAlqICMS.Name = "txtProdutoAlqICMS";
            this.txtProdutoAlqICMS.Size = new System.Drawing.Size(57, 23);
            this.txtProdutoAlqICMS.TabIndex = 23;
            // 
            // lblProdAlqICMS
            // 
            this.lblProdAlqICMS.AutoSize = true;
            this.lblProdAlqICMS.Location = new System.Drawing.Point(768, 65);
            this.lblProdAlqICMS.Name = "lblProdAlqICMS";
            this.lblProdAlqICMS.Size = new System.Drawing.Size(60, 15);
            this.lblProdAlqICMS.TabIndex = 22;
            this.lblProdAlqICMS.Text = "Aliq.ICMS";
            // 
            // txtProdutoVL_IPI
            // 
            this.txtProdutoVL_IPI.Location = new System.Drawing.Point(711, 83);
            this.txtProdutoVL_IPI.Name = "txtProdutoVL_IPI";
            this.txtProdutoVL_IPI.Size = new System.Drawing.Size(51, 23);
            this.txtProdutoVL_IPI.TabIndex = 21;
            // 
            // lblProdVl_IPI
            // 
            this.lblProdVl_IPI.AutoSize = true;
            this.lblProdVl_IPI.Location = new System.Drawing.Point(711, 65);
            this.lblProdVl_IPI.Name = "lblProdVl_IPI";
            this.lblProdVl_IPI.Size = new System.Drawing.Size(36, 15);
            this.lblProdVl_IPI.TabIndex = 20;
            this.lblProdVl_IPI.Text = "Vl.IPI";
            // 
            // lblProdutoNome
            // 
            this.lblProdutoNome.AutoSize = true;
            this.lblProdutoNome.Location = new System.Drawing.Point(193, 19);
            this.lblProdutoNome.Name = "lblProdutoNome";
            this.lblProdutoNome.Size = new System.Drawing.Size(51, 15);
            this.lblProdutoNome.TabIndex = 19;
            this.lblProdutoNome.Text = "Produto";
            // 
            // txtProdutoVL_ICMS
            // 
            this.txtProdutoVL_ICMS.Location = new System.Drawing.Point(656, 83);
            this.txtProdutoVL_ICMS.Name = "txtProdutoVL_ICMS";
            this.txtProdutoVL_ICMS.Size = new System.Drawing.Size(49, 23);
            this.txtProdutoVL_ICMS.TabIndex = 18;
            // 
            // lblProdVl_ICMS
            // 
            this.lblProdVl_ICMS.AutoSize = true;
            this.lblProdVl_ICMS.Location = new System.Drawing.Point(656, 65);
            this.lblProdVl_ICMS.Name = "lblProdVl_ICMS";
            this.lblProdVl_ICMS.Size = new System.Drawing.Size(49, 15);
            this.lblProdVl_ICMS.TabIndex = 17;
            this.lblProdVl_ICMS.Text = "Vl.ICMS";
            // 
            // txtProdutoBC_ICMS
            // 
            this.txtProdutoBC_ICMS.Location = new System.Drawing.Point(595, 83);
            this.txtProdutoBC_ICMS.Name = "txtProdutoBC_ICMS";
            this.txtProdutoBC_ICMS.Size = new System.Drawing.Size(55, 23);
            this.txtProdutoBC_ICMS.TabIndex = 16;
            // 
            // lblProdBC_ICMS
            // 
            this.lblProdBC_ICMS.AutoSize = true;
            this.lblProdBC_ICMS.Location = new System.Drawing.Point(595, 65);
            this.lblProdBC_ICMS.Name = "lblProdBC_ICMS";
            this.lblProdBC_ICMS.Size = new System.Drawing.Size(55, 15);
            this.lblProdBC_ICMS.TabIndex = 15;
            this.lblProdBC_ICMS.Text = "BC. ICMS";
            // 
            // txtProdutoCFOP
            // 
            this.txtProdutoCFOP.Location = new System.Drawing.Point(56, 83);
            this.txtProdutoCFOP.Name = "txtProdutoCFOP";
            this.txtProdutoCFOP.Size = new System.Drawing.Size(49, 23);
            this.txtProdutoCFOP.TabIndex = 14;
            // 
            // lblProdCFOP
            // 
            this.lblProdCFOP.AutoSize = true;
            this.lblProdCFOP.Location = new System.Drawing.Point(56, 65);
            this.lblProdCFOP.Name = "lblProdCFOP";
            this.lblProdCFOP.Size = new System.Drawing.Size(36, 15);
            this.lblProdCFOP.TabIndex = 13;
            this.lblProdCFOP.Text = "CFOP";
            // 
            // txtProdutoCST
            // 
            this.txtProdutoCST.Location = new System.Drawing.Point(6, 83);
            this.txtProdutoCST.Name = "txtProdutoCST";
            this.txtProdutoCST.Size = new System.Drawing.Size(44, 23);
            this.txtProdutoCST.TabIndex = 12;
            // 
            // lblProdCST
            // 
            this.lblProdCST.AutoSize = true;
            this.lblProdCST.Location = new System.Drawing.Point(6, 65);
            this.lblProdCST.Name = "lblProdCST";
            this.lblProdCST.Size = new System.Drawing.Size(26, 15);
            this.lblProdCST.TabIndex = 11;
            this.lblProdCST.Text = "CST";
            // 
            // txtProdutoDescricao
            // 
            this.txtProdutoDescricao.Location = new System.Drawing.Point(193, 37);
            this.txtProdutoDescricao.Name = "txtProdutoDescricao";
            this.txtProdutoDescricao.ReadOnly = true;
            this.txtProdutoDescricao.Size = new System.Drawing.Size(341, 23);
            this.txtProdutoDescricao.TabIndex = 8;
            // 
            // txtProdutoValorUN
            // 
            this.txtProdutoValorUN.Location = new System.Drawing.Point(373, 83);
            this.txtProdutoValorUN.Name = "txtProdutoValorUN";
            this.txtProdutoValorUN.Size = new System.Drawing.Size(70, 23);
            this.txtProdutoValorUN.TabIndex = 7;
            // 
            // lblProdVlUn
            // 
            this.lblProdVlUn.AutoSize = true;
            this.lblProdVlUn.Location = new System.Drawing.Point(373, 65);
            this.lblProdVlUn.Name = "lblProdVlUn";
            this.lblProdVlUn.Size = new System.Drawing.Size(70, 15);
            this.lblProdVlUn.TabIndex = 6;
            this.lblProdVlUn.Text = "Vl. Unitario";
            // 
            // txtProdutoValorTotal
            // 
            this.txtProdutoValorTotal.Location = new System.Drawing.Point(518, 83);
            this.txtProdutoValorTotal.Name = "txtProdutoValorTotal";
            this.txtProdutoValorTotal.Size = new System.Drawing.Size(71, 23);
            this.txtProdutoValorTotal.TabIndex = 5;
            // 
            // lblProdVlTotal
            // 
            this.lblProdVlTotal.AutoSize = true;
            this.lblProdVlTotal.Location = new System.Drawing.Point(518, 65);
            this.lblProdVlTotal.Name = "lblProdVlTotal";
            this.lblProdVlTotal.Size = new System.Drawing.Size(47, 15);
            this.lblProdVlTotal.TabIndex = 4;
            this.lblProdVlTotal.Text = "Vl.Total";
            // 
            // lblProdCodBarras
            // 
            this.lblProdCodBarras.AutoSize = true;
            this.lblProdCodBarras.Location = new System.Drawing.Point(87, 19);
            this.lblProdCodBarras.Name = "lblProdCodBarras";
            this.lblProdCodBarras.Size = new System.Drawing.Size(68, 15);
            this.lblProdCodBarras.TabIndex = 3;
            this.lblProdCodBarras.Text = "Cód.Barras";
            // 
            // txtProdutoCodbarras
            // 
            this.txtProdutoCodbarras.Location = new System.Drawing.Point(87, 37);
            this.txtProdutoCodbarras.Name = "txtProdutoCodbarras";
            this.txtProdutoCodbarras.Size = new System.Drawing.Size(100, 23);
            this.txtProdutoCodbarras.TabIndex = 1;
            // 
            // tabTransporte
            // 
            this.tabTransporte.Controls.Add(this.gbFrete);
            this.tabTransporte.Location = new System.Drawing.Point(4, 24);
            this.tabTransporte.Name = "tabTransporte";
            this.tabTransporte.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransporte.Size = new System.Drawing.Size(906, 384);
            this.tabTransporte.TabIndex = 3;
            this.tabTransporte.Text = "Transporte";
            this.tabTransporte.UseVisualStyleBackColor = true;
            // 
            // gbFrete
            // 
            this.gbFrete.Controls.Add(this.lblMsgTransp);
            this.gbFrete.Controls.Add(this.btnTransp);
            this.gbFrete.Controls.Add(this.txtNomeTransp);
            this.gbFrete.Controls.Add(this.txtCNPJtransp);
            this.gbFrete.Controls.Add(this.lblCNPJtransp);
            this.gbFrete.Location = new System.Drawing.Point(6, 6);
            this.gbFrete.Name = "gbFrete";
            this.gbFrete.Size = new System.Drawing.Size(893, 102);
            this.gbFrete.TabIndex = 2;
            this.gbFrete.TabStop = false;
            this.gbFrete.Text = "Transportador";
            // 
            // lblMsgTransp
            // 
            this.lblMsgTransp.AutoSize = true;
            this.lblMsgTransp.Location = new System.Drawing.Point(193, 41);
            this.lblMsgTransp.Name = "lblMsgTransp";
            this.lblMsgTransp.Size = new System.Drawing.Size(83, 15);
            this.lblMsgTransp.TabIndex = 26;
            this.lblMsgTransp.Text = "</Mensagem>";
            // 
            // btnTransp
            // 
            this.btnTransp.Location = new System.Drawing.Point(158, 38);
            this.btnTransp.Name = "btnTransp";
            this.btnTransp.Size = new System.Drawing.Size(29, 23);
            this.btnTransp.TabIndex = 1;
            this.btnTransp.Text = "+";
            this.btnTransp.UseVisualStyleBackColor = true;
            // 
            // txtNomeTransp
            // 
            this.txtNomeTransp.Location = new System.Drawing.Point(9, 67);
            this.txtNomeTransp.Name = "txtNomeTransp";
            this.txtNomeTransp.Size = new System.Drawing.Size(460, 23);
            this.txtNomeTransp.TabIndex = 2;
            // 
            // txtCNPJtransp
            // 
            this.txtCNPJtransp.Location = new System.Drawing.Point(9, 38);
            this.txtCNPJtransp.Name = "txtCNPJtransp";
            this.txtCNPJtransp.Size = new System.Drawing.Size(143, 23);
            this.txtCNPJtransp.TabIndex = 0;
            // 
            // lblCNPJtransp
            // 
            this.lblCNPJtransp.AutoSize = true;
            this.lblCNPJtransp.Location = new System.Drawing.Point(6, 19);
            this.lblCNPJtransp.Name = "lblCNPJtransp";
            this.lblCNPJtransp.Size = new System.Drawing.Size(32, 15);
            this.lblCNPJtransp.TabIndex = 22;
            this.lblCNPJtransp.Text = "CNPJ";
            // 
            // tabFatura
            // 
            this.tabFatura.Location = new System.Drawing.Point(4, 24);
            this.tabFatura.Name = "tabFatura";
            this.tabFatura.Padding = new System.Windows.Forms.Padding(3);
            this.tabFatura.Size = new System.Drawing.Size(906, 384);
            this.tabFatura.TabIndex = 2;
            this.tabFatura.Text = "Fatura";
            this.tabFatura.UseVisualStyleBackColor = true;
            // 
            // formEstoqueEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(938, 517);
            this.Controls.Add(this.tabNota);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "formEstoqueEntrada";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada de Produtos";
            this.pnlRodape.ResumeLayout(false);
            this.pnlRodape.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.tabNota.ResumeLayout(false);
            this.tabPrincipal.ResumeLayout(false);
            this.gbFornecedor.ResumeLayout(false);
            this.gbFornecedor.PerformLayout();
            this.gbEmpresa.ResumeLayout(false);
            this.gbEmpresa.PerformLayout();
            this.gbImpostoNota.ResumeLayout(false);
            this.gbImpostoNota.PerformLayout();
            this.gbCabecalhoNota.ResumeLayout(false);
            this.gbCabecalhoNota.PerformLayout();
            this.tabProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosItens)).EndInit();
            this.gbItem.ResumeLayout(false);
            this.gbItem.PerformLayout();
            this.tabTransporte.ResumeLayout(false);
            this.gbFrete.ResumeLayout(false);
            this.gbFrete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.TabControl tabNota;
        private System.Windows.Forms.TabPage tabPrincipal;
        private System.Windows.Forms.TabPage tabProdutos;
        private System.Windows.Forms.GroupBox gbCabecalhoNota;
        private System.Windows.Forms.TextBox txtArquivoXML;
        private System.Windows.Forms.Button btnArquivoXML;
        private System.Windows.Forms.Label lblArquivoXML;
        private System.Windows.Forms.Label lblEntradaSaida;
        private System.Windows.Forms.Label lblEmissao;
        private System.Windows.Forms.DateTimePicker dtEntradaSaida;
        private System.Windows.Forms.DateTimePicker dtEmissao;
        private System.Windows.Forms.TextBox txtNatOp;
        private System.Windows.Forms.Label lblNatOper;
        private System.Windows.Forms.TextBox txtProtocolo;
        private System.Windows.Forms.Label lblProtocolo;
        private System.Windows.Forms.TextBox txtChaveAcesso;
        private System.Windows.Forms.Label lblChaveAcesso;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.TextBox txtNumeroNota;
        private System.Windows.Forms.Label lblNumeroNota;
        private System.Windows.Forms.GroupBox gbImpostoNota;
        private System.Windows.Forms.Label lblTotalNota;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblVL_ipi;
        private System.Windows.Forms.TextBox txtValorIPI;
        private System.Windows.Forms.Label lblOutrasDespesas;
        private System.Windows.Forms.TextBox txtOutrasDesp;
        private System.Windows.Forms.Label lblVL_Desconto;
        private System.Windows.Forms.TextBox txtValorDesconto;
        private System.Windows.Forms.Label lblVL_Seguro;
        private System.Windows.Forms.TextBox txtValorSeguro;
        private System.Windows.Forms.Label lblVL_Frete;
        private System.Windows.Forms.TextBox txtValorFrete;
        private System.Windows.Forms.Label lblValorTotalItens;
        private System.Windows.Forms.TextBox txtValorItens;
        private System.Windows.Forms.Label lblVL_Importacao;
        private System.Windows.Forms.TextBox txt_vlImportacao;
        private System.Windows.Forms.Label lblVL_icmsST;
        private System.Windows.Forms.TextBox txt_vlICMSst;
        private System.Windows.Forms.Label lblBC_icmsST;
        private System.Windows.Forms.TextBox txt_bcICMSst;
        private System.Windows.Forms.Label lblVL_icms;
        private System.Windows.Forms.TextBox txt_vlICMS;
        private System.Windows.Forms.Label lblBC_ICMS;
        private System.Windows.Forms.TextBox txt_bcICMS;
        private System.Windows.Forms.GroupBox gbEmpresa;
        private System.Windows.Forms.Label lblTpNota;
        private System.Windows.Forms.ComboBox cbTipoNota;
        private System.Windows.Forms.GroupBox gbFornecedor;
        private System.Windows.Forms.TabPage tabFatura;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.TextBox txt_cnpjFornec;
        private System.Windows.Forms.Label lblCNPJFornecedor;
        private System.Windows.Forms.Label lblCNPJEmpresa;
        private System.Windows.Forms.Label lblMsgFornec;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Label lblMsgEmpresa;
        private System.Windows.Forms.TabPage tabTransporte;
        private System.Windows.Forms.GroupBox gbItem;
        private System.Windows.Forms.TextBox txtProdutoVL_ICMS;
        private System.Windows.Forms.Label lblProdVl_ICMS;
        private System.Windows.Forms.TextBox txtProdutoBC_ICMS;
        private System.Windows.Forms.Label lblProdBC_ICMS;
        private System.Windows.Forms.TextBox txtProdutoCFOP;
        private System.Windows.Forms.Label lblProdCFOP;
        private System.Windows.Forms.TextBox txtProdutoCST;
        private System.Windows.Forms.Label lblProdCST;
        private System.Windows.Forms.TextBox txtProdutoDescricao;
        private System.Windows.Forms.TextBox txtProdutoValorUN;
        private System.Windows.Forms.Label lblProdVlUn;
        private System.Windows.Forms.TextBox txtProdutoValorTotal;
        private System.Windows.Forms.Label lblProdVlTotal;
        private System.Windows.Forms.Label lblProdCodBarras;
        private System.Windows.Forms.TextBox txtProdutoCodbarras;
        private System.Windows.Forms.TextBox txtProdutoAlqICMS;
        private System.Windows.Forms.Label lblProdAlqICMS;
        private System.Windows.Forms.TextBox txtProdutoVL_IPI;
        private System.Windows.Forms.Label lblProdVl_IPI;
        private System.Windows.Forms.Label lblProdutoNome;
        private System.Windows.Forms.Button btnBuscarProduto;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.TextBox txtProdutoAlqIPI;
        private System.Windows.Forms.Label lblProdAlqIPI;
        private System.Windows.Forms.DataGridView dgvProdutosItens;
        private System.Windows.Forms.TextBox txtProdutoDesconto;
        private System.Windows.Forms.Label lblProdDesc;
        private System.Windows.Forms.GroupBox gbFrete;
        private System.Windows.Forms.Label lblMsgTransp;
        private System.Windows.Forms.Button btnTransp;
        private System.Windows.Forms.TextBox txtNomeTransp;
        private System.Windows.Forms.TextBox txtCNPJtransp;
        private System.Windows.Forms.Label lblCNPJtransp;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.MaskedTextBox mtxtCNPJEmpresa;
        private System.Windows.Forms.Label lblProdutoCod;
        private System.Windows.Forms.TextBox txtProdutoCod;
        private System.Windows.Forms.TextBox txtProdutoQtdEntrada;
        private System.Windows.Forms.Label lblProdQtdEntrada;
        private System.Windows.Forms.TextBox txtProdutoQTD;
        private System.Windows.Forms.Label lblProdQtdUN;
        private System.Windows.Forms.TextBox txtProdutoQtdEmb;
        private System.Windows.Forms.Label lblProdQtdEmb;
        private System.Windows.Forms.Label lblProdUN;
        private System.Windows.Forms.ComboBox cboxProdutoUN;
        private System.Windows.Forms.Button btnEditarCadProduto;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCST;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCFOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVLUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVLTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBCicms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVLicms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVLipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlqICMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlqIPI;
    }
}