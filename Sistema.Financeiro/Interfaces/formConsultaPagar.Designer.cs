namespace Sistema.Financeiro.Interfaces
{
    partial class formConsultaPagar
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
            this.lblResultNumSelecionado = new System.Windows.Forms.Label();
            this.lblResultVlSelecionado = new System.Windows.Forms.Label();
            this.lblResultSaldoSelecionado = new System.Windows.Forms.Label();
            this.lblResultSaldoTotal = new System.Windows.Forms.Label();
            this.lblResultVlTotal = new System.Windows.Forms.Label();
            this.lblNumSelecionados = new System.Windows.Forms.Label();
            this.lblValorSelecionado = new System.Windows.Forms.Label();
            this.lblSaldoSelecionado = new System.Windows.Forms.Label();
            this.lblSaldoTotal = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.btnBaixar = new System.Windows.Forms.Button();
            this.txtSaldoPagParcial = new System.Windows.Forms.TextBox();
            this.txtValorPagParcial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ckPagParcial = new System.Windows.Forms.CheckBox();
            this.txtValorFinal = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtAcrescimo = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lvlValorFinal = new System.Windows.Forms.Label();
            this.lblAcrescimo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFiltro = new System.Windows.Forms.Panel();
            this.btnPesquisarPessoa = new System.Windows.Forms.Button();
            this.textPessoa = new System.Windows.Forms.TextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNumDoc = new System.Windows.Forms.Label();
            this.lblPessoa = new System.Windows.Forms.Label();
            this.cbTipoPessoa = new System.Windows.Forms.ComboBox();
            this.lblTipoPessoa = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dtFimPeriodo = new System.Windows.Forms.DateTimePicker();
            this.dtInicioPeriodo = new System.Windows.Forms.DateTimePicker();
            this.cbPeriodos = new System.Windows.Forms.ComboBox();
            this.cbTipoFiltro = new System.Windows.Forms.ComboBox();
            this.panelInferior = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelFiltro.SuspendLayout();
            this.panelInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResultNumSelecionado
            // 
            this.lblResultNumSelecionado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultNumSelecionado.AutoSize = true;
            this.lblResultNumSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultNumSelecionado.Location = new System.Drawing.Point(1412, 142);
            this.lblResultNumSelecionado.Name = "lblResultNumSelecionado";
            this.lblResultNumSelecionado.Size = new System.Drawing.Size(119, 13);
            this.lblResultNumSelecionado.TabIndex = 24;
            this.lblResultNumSelecionado.Text = "Nº de Selecionados";
            // 
            // lblResultVlSelecionado
            // 
            this.lblResultVlSelecionado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultVlSelecionado.AutoSize = true;
            this.lblResultVlSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultVlSelecionado.Location = new System.Drawing.Point(754, 142);
            this.lblResultVlSelecionado.Name = "lblResultVlSelecionado";
            this.lblResultVlSelecionado.Size = new System.Drawing.Size(110, 13);
            this.lblResultVlSelecionado.TabIndex = 23;
            this.lblResultVlSelecionado.Text = "Valor Selecionado";
            // 
            // lblResultSaldoSelecionado
            // 
            this.lblResultSaldoSelecionado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultSaldoSelecionado.AutoSize = true;
            this.lblResultSaldoSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultSaldoSelecionado.Location = new System.Drawing.Point(1121, 142);
            this.lblResultSaldoSelecionado.Name = "lblResultSaldoSelecionado";
            this.lblResultSaldoSelecionado.Size = new System.Drawing.Size(113, 13);
            this.lblResultSaldoSelecionado.TabIndex = 22;
            this.lblResultSaldoSelecionado.Text = "Saldo Selecionado";
            // 
            // lblResultSaldoTotal
            // 
            this.lblResultSaldoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultSaldoTotal.AutoSize = true;
            this.lblResultSaldoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultSaldoTotal.Location = new System.Drawing.Point(378, 142);
            this.lblResultSaldoTotal.Name = "lblResultSaldoTotal";
            this.lblResultSaldoTotal.Size = new System.Drawing.Size(72, 13);
            this.lblResultSaldoTotal.TabIndex = 21;
            this.lblResultSaldoTotal.Text = "Saldo Total";
            // 
            // lblResultVlTotal
            // 
            this.lblResultVlTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultVlTotal.AutoSize = true;
            this.lblResultVlTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultVlTotal.Location = new System.Drawing.Point(64, 142);
            this.lblResultVlTotal.Name = "lblResultVlTotal";
            this.lblResultVlTotal.Size = new System.Drawing.Size(69, 13);
            this.lblResultVlTotal.TabIndex = 20;
            this.lblResultVlTotal.Text = "Valor Total";
            // 
            // lblNumSelecionados
            // 
            this.lblNumSelecionados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumSelecionados.AutoSize = true;
            this.lblNumSelecionados.Location = new System.Drawing.Point(1411, 118);
            this.lblNumSelecionados.Name = "lblNumSelecionados";
            this.lblNumSelecionados.Size = new System.Drawing.Size(101, 13);
            this.lblNumSelecionados.TabIndex = 19;
            this.lblNumSelecionados.Text = "Nº de Selecionados";
            // 
            // lblValorSelecionado
            // 
            this.lblValorSelecionado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorSelecionado.AutoSize = true;
            this.lblValorSelecionado.Location = new System.Drawing.Point(753, 118);
            this.lblValorSelecionado.Name = "lblValorSelecionado";
            this.lblValorSelecionado.Size = new System.Drawing.Size(93, 13);
            this.lblValorSelecionado.TabIndex = 18;
            this.lblValorSelecionado.Text = "Valor Selecionado";
            // 
            // lblSaldoSelecionado
            // 
            this.lblSaldoSelecionado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaldoSelecionado.AutoSize = true;
            this.lblSaldoSelecionado.Location = new System.Drawing.Point(1120, 118);
            this.lblSaldoSelecionado.Name = "lblSaldoSelecionado";
            this.lblSaldoSelecionado.Size = new System.Drawing.Size(96, 13);
            this.lblSaldoSelecionado.TabIndex = 17;
            this.lblSaldoSelecionado.Text = "Saldo Selecionado";
            // 
            // lblSaldoTotal
            // 
            this.lblSaldoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaldoTotal.AutoSize = true;
            this.lblSaldoTotal.Location = new System.Drawing.Point(377, 118);
            this.lblSaldoTotal.Name = "lblSaldoTotal";
            this.lblSaldoTotal.Size = new System.Drawing.Size(61, 13);
            this.lblSaldoTotal.TabIndex = 16;
            this.lblSaldoTotal.Text = "Saldo Total";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(63, 118);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(58, 13);
            this.lblValorTotal.TabIndex = 15;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // btnBaixar
            // 
            this.btnBaixar.Location = new System.Drawing.Point(528, 40);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(92, 35);
            this.btnBaixar.TabIndex = 14;
            this.btnBaixar.Text = "&Baixar";
            this.btnBaixar.UseVisualStyleBackColor = true;
            // 
            // txtSaldoPagParcial
            // 
            this.txtSaldoPagParcial.Location = new System.Drawing.Point(417, 55);
            this.txtSaldoPagParcial.Name = "txtSaldoPagParcial";
            this.txtSaldoPagParcial.Size = new System.Drawing.Size(91, 20);
            this.txtSaldoPagParcial.TabIndex = 13;
            // 
            // txtValorPagParcial
            // 
            this.txtValorPagParcial.Location = new System.Drawing.Point(320, 55);
            this.txtValorPagParcial.Name = "txtValorPagParcial";
            this.txtValorPagParcial.Size = new System.Drawing.Size(91, 20);
            this.txtValorPagParcial.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Valor a pagar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Saldo";
            // 
            // ckPagParcial
            // 
            this.ckPagParcial.AutoSize = true;
            this.ckPagParcial.Location = new System.Drawing.Point(323, 16);
            this.ckPagParcial.Name = "ckPagParcial";
            this.ckPagParcial.Size = new System.Drawing.Size(115, 17);
            this.ckPagParcial.TabIndex = 9;
            this.ckPagParcial.Text = "Pagamento Parcial";
            this.ckPagParcial.UseVisualStyleBackColor = true;
            // 
            // txtValorFinal
            // 
            this.txtValorFinal.Location = new System.Drawing.Point(201, 55);
            this.txtValorFinal.Name = "txtValorFinal";
            this.txtValorFinal.Size = new System.Drawing.Size(91, 20);
            this.txtValorFinal.TabIndex = 8;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(104, 55);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(91, 20);
            this.txtDesconto.TabIndex = 7;
            // 
            // txtAcrescimo
            // 
            this.txtAcrescimo.Location = new System.Drawing.Point(7, 55);
            this.txtAcrescimo.Name = "txtAcrescimo";
            this.txtAcrescimo.Size = new System.Drawing.Size(91, 20);
            this.txtAcrescimo.TabIndex = 6;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(103, 40);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(76, 13);
            this.lblDesconto.TabIndex = 5;
            this.lblDesconto.Text = "Desconto (R$)";
            // 
            // lvlValorFinal
            // 
            this.lvlValorFinal.AutoSize = true;
            this.lvlValorFinal.Location = new System.Drawing.Point(200, 40);
            this.lvlValorFinal.Name = "lvlValorFinal";
            this.lvlValorFinal.Size = new System.Drawing.Size(56, 13);
            this.lvlValorFinal.TabIndex = 4;
            this.lvlValorFinal.Text = "Valor Final";
            // 
            // lblAcrescimo
            // 
            this.lblAcrescimo.AutoSize = true;
            this.lblAcrescimo.Location = new System.Drawing.Point(5, 40);
            this.lblAcrescimo.Name = "lblAcrescimo";
            this.lblAcrescimo.Size = new System.Drawing.Size(79, 13);
            this.lblAcrescimo.TabIndex = 0;
            this.lblAcrescimo.Text = "Acréscimo (R$)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1578, 405);
            this.dataGridView1.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.listarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1598, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.adicionarToolStripMenuItem.Text = "&Adicionar";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.listarToolStripMenuItem.Text = "&Listar";
            // 
            // panelFiltro
            // 
            this.panelFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFiltro.BackColor = System.Drawing.Color.White;
            this.panelFiltro.Controls.Add(this.btnPesquisarPessoa);
            this.panelFiltro.Controls.Add(this.textPessoa);
            this.panelFiltro.Controls.Add(this.lblEmpresa);
            this.panelFiltro.Controls.Add(this.cbEmpresa);
            this.panelFiltro.Controls.Add(this.textBox1);
            this.panelFiltro.Controls.Add(this.lblNumDoc);
            this.panelFiltro.Controls.Add(this.lblPessoa);
            this.panelFiltro.Controls.Add(this.cbTipoPessoa);
            this.panelFiltro.Controls.Add(this.lblTipoPessoa);
            this.panelFiltro.Controls.Add(this.cbStatus);
            this.panelFiltro.Controls.Add(this.lblStatus);
            this.panelFiltro.Controls.Add(this.dtFimPeriodo);
            this.panelFiltro.Controls.Add(this.dtInicioPeriodo);
            this.panelFiltro.Controls.Add(this.cbPeriodos);
            this.panelFiltro.Controls.Add(this.cbTipoFiltro);
            this.panelFiltro.Location = new System.Drawing.Point(0, 25);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Size = new System.Drawing.Size(1598, 131);
            this.panelFiltro.TabIndex = 5;
            // 
            // btnPesquisarPessoa
            // 
            this.btnPesquisarPessoa.BackColor = System.Drawing.Color.White;
            this.btnPesquisarPessoa.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisarPessoa.Location = new System.Drawing.Point(528, 96);
            this.btnPesquisarPessoa.Name = "btnPesquisarPessoa";
            this.btnPesquisarPessoa.Size = new System.Drawing.Size(28, 22);
            this.btnPesquisarPessoa.TabIndex = 25;
            this.btnPesquisarPessoa.UseVisualStyleBackColor = false;
            // 
            // textPessoa
            // 
            this.textPessoa.Location = new System.Drawing.Point(146, 98);
            this.textPessoa.Name = "textPessoa";
            this.textPessoa.Size = new System.Drawing.Size(378, 20);
            this.textPessoa.TabIndex = 14;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(9, 5);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(48, 13);
            this.lblEmpresa.TabIndex = 13;
            this.lblEmpresa.Text = "Empresa";
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Location = new System.Drawing.Point(12, 20);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(510, 21);
            this.cbEmpresa.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(562, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 11;
            // 
            // lblNumDoc
            // 
            this.lblNumDoc.AutoSize = true;
            this.lblNumDoc.Location = new System.Drawing.Point(561, 80);
            this.lblNumDoc.Name = "lblNumDoc";
            this.lblNumDoc.Size = new System.Drawing.Size(77, 13);
            this.lblNumDoc.TabIndex = 10;
            this.lblNumDoc.Text = "Nº Documento";
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.Location = new System.Drawing.Point(146, 80);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(42, 13);
            this.lblPessoa.TabIndex = 8;
            this.lblPessoa.Text = "Pessoa";
            // 
            // cbTipoPessoa
            // 
            this.cbTipoPessoa.FormattingEnabled = true;
            this.cbTipoPessoa.Location = new System.Drawing.Point(12, 97);
            this.cbTipoPessoa.Name = "cbTipoPessoa";
            this.cbTipoPessoa.Size = new System.Drawing.Size(128, 21);
            this.cbTipoPessoa.TabIndex = 7;
            // 
            // lblTipoPessoa
            // 
            this.lblTipoPessoa.AutoSize = true;
            this.lblTipoPessoa.Location = new System.Drawing.Point(12, 80);
            this.lblTipoPessoa.Name = "lblTipoPessoa";
            this.lblTipoPessoa.Size = new System.Drawing.Size(66, 13);
            this.lblTipoPessoa.TabIndex = 6;
            this.lblTipoPessoa.Text = "Tipo Pessoa";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Todos",
            "Aberto",
            "Liquidado",
            "Estornados"});
            this.cbStatus.Location = new System.Drawing.Point(528, 56);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(137, 21);
            this.cbStatus.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(525, 41);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // dtFimPeriodo
            // 
            this.dtFimPeriodo.Location = new System.Drawing.Point(393, 57);
            this.dtFimPeriodo.Name = "dtFimPeriodo";
            this.dtFimPeriodo.Size = new System.Drawing.Size(129, 20);
            this.dtFimPeriodo.TabIndex = 3;
            // 
            // dtInicioPeriodo
            // 
            this.dtInicioPeriodo.Location = new System.Drawing.Point(257, 57);
            this.dtInicioPeriodo.Name = "dtInicioPeriodo";
            this.dtInicioPeriodo.Size = new System.Drawing.Size(129, 20);
            this.dtInicioPeriodo.TabIndex = 2;
            // 
            // cbPeriodos
            // 
            this.cbPeriodos.FormattingEnabled = true;
            this.cbPeriodos.Items.AddRange(new object[] {
            "Todos",
            "Personalisado",
            "Ontem",
            "Hoje",
            "Amanhã",
            "Esta semana",
            "Semana que vem",
            "Semana Passada",
            "Este mês",
            "Mês que vem",
            "Mês passado",
            "Este ano",
            "Ano que vem",
            "Ano passado"});
            this.cbPeriodos.Location = new System.Drawing.Point(127, 56);
            this.cbPeriodos.Name = "cbPeriodos";
            this.cbPeriodos.Size = new System.Drawing.Size(123, 21);
            this.cbPeriodos.TabIndex = 1;
            // 
            // cbTipoFiltro
            // 
            this.cbTipoFiltro.FormattingEnabled = true;
            this.cbTipoFiltro.Items.AddRange(new object[] {
            "Emissão",
            "Vencimento"});
            this.cbTipoFiltro.Location = new System.Drawing.Point(12, 56);
            this.cbTipoFiltro.Name = "cbTipoFiltro";
            this.cbTipoFiltro.Size = new System.Drawing.Size(109, 21);
            this.cbTipoFiltro.TabIndex = 1;
            // 
            // panelInferior
            // 
            this.panelInferior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInferior.BackColor = System.Drawing.Color.White;
            this.panelInferior.Controls.Add(this.lblResultNumSelecionado);
            this.panelInferior.Controls.Add(this.lblResultVlSelecionado);
            this.panelInferior.Controls.Add(this.lblResultSaldoSelecionado);
            this.panelInferior.Controls.Add(this.lblResultSaldoTotal);
            this.panelInferior.Controls.Add(this.lblResultVlTotal);
            this.panelInferior.Controls.Add(this.lblNumSelecionados);
            this.panelInferior.Controls.Add(this.lblValorSelecionado);
            this.panelInferior.Controls.Add(this.lblSaldoSelecionado);
            this.panelInferior.Controls.Add(this.lblSaldoTotal);
            this.panelInferior.Controls.Add(this.lblValorTotal);
            this.panelInferior.Controls.Add(this.btnBaixar);
            this.panelInferior.Controls.Add(this.txtSaldoPagParcial);
            this.panelInferior.Controls.Add(this.txtValorPagParcial);
            this.panelInferior.Controls.Add(this.label1);
            this.panelInferior.Controls.Add(this.label5);
            this.panelInferior.Controls.Add(this.ckPagParcial);
            this.panelInferior.Controls.Add(this.txtValorFinal);
            this.panelInferior.Controls.Add(this.txtDesconto);
            this.panelInferior.Controls.Add(this.txtAcrescimo);
            this.panelInferior.Controls.Add(this.lblDesconto);
            this.panelInferior.Controls.Add(this.lvlValorFinal);
            this.panelInferior.Controls.Add(this.lblAcrescimo);
            this.panelInferior.Location = new System.Drawing.Point(0, 573);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(1598, 176);
            this.panelInferior.TabIndex = 6;
            // 
            // formConsultaPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1598, 749);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelFiltro);
            this.Name = "formConsultaPagar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Títulos a Pagar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelFiltro.ResumeLayout(false);
            this.panelFiltro.PerformLayout();
            this.panelInferior.ResumeLayout(false);
            this.panelInferior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultNumSelecionado;
        private System.Windows.Forms.Label lblResultVlSelecionado;
        private System.Windows.Forms.Label lblResultSaldoSelecionado;
        private System.Windows.Forms.Label lblResultSaldoTotal;
        private System.Windows.Forms.Label lblResultVlTotal;
        private System.Windows.Forms.Label lblNumSelecionados;
        private System.Windows.Forms.Label lblValorSelecionado;
        private System.Windows.Forms.Label lblSaldoSelecionado;
        private System.Windows.Forms.Label lblSaldoTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnBaixar;
        private System.Windows.Forms.TextBox txtSaldoPagParcial;
        private System.Windows.Forms.TextBox txtValorPagParcial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckPagParcial;
        private System.Windows.Forms.TextBox txtValorFinal;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtAcrescimo;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lvlValorFinal;
        private System.Windows.Forms.Label lblAcrescimo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.Panel panelFiltro;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNumDoc;
        private System.Windows.Forms.Label lblPessoa;
        private System.Windows.Forms.ComboBox cbTipoPessoa;
        private System.Windows.Forms.Label lblTipoPessoa;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DateTimePicker dtFimPeriodo;
        private System.Windows.Forms.DateTimePicker dtInicioPeriodo;
        private System.Windows.Forms.ComboBox cbPeriodos;
        private System.Windows.Forms.ComboBox cbTipoFiltro;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.TextBox textPessoa;
        private System.Windows.Forms.Button btnPesquisarPessoa;
    }
}