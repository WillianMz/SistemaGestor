namespace Sistema.Estoque.Interfaces
{
    partial class formConsultaProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formConsultaProduto));
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.menuAcoes = new System.Windows.Forms.MenuStrip();
            this.menuAdicionar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDetalhes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAtivarDesativar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistorico = new System.Windows.Forms.ToolStripMenuItem();
            this.mHistMovimento = new System.Windows.Forms.ToolStripMenuItem();
            this.mHistPrecos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMaisOpcoes = new System.Windows.Forms.ToolStripMenuItem();
            this.mOpcaoEstruturaMercadologica = new System.Windows.Forms.ToolStripMenuItem();
            this.tributaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etiquetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuListarDesativados = new System.Windows.Forms.ToolStripMenuItem();
            this.menuListarTodos = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subgruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semelhantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnFiltro = new System.Windows.Forms.Panel();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.lblProcurar = new System.Windows.Forms.Label();
            this.lblTipoFiltro = new System.Windows.Forms.Label();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.chboxDesativados = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.pnlRodape.SuspendLayout();
            this.menuAcoes.SuspendLayout();
            this.pnFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToOrderColumns = true;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.nome,
            this.descricao,
            this.custo,
            this.precoVenda,
            this.margem,
            this.marca,
            this.fabricante});
            this.dgvProdutos.Location = new System.Drawing.Point(13, 95);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(1125, 403);
            this.dgvProdutos.TabIndex = 27;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // custo
            // 
            this.custo.HeaderText = "Custo";
            this.custo.Name = "custo";
            this.custo.ReadOnly = true;
            // 
            // precoVenda
            // 
            this.precoVenda.HeaderText = "Venda";
            this.precoVenda.Name = "precoVenda";
            this.precoVenda.ReadOnly = true;
            // 
            // margem
            // 
            this.margem.HeaderText = "Margem";
            this.margem.Name = "margem";
            this.margem.ReadOnly = true;
            // 
            // marca
            // 
            this.marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            this.marca.Width = 68;
            // 
            // fabricante
            // 
            this.fabricante.HeaderText = "Fabricante";
            this.fabricante.Name = "fabricante";
            this.fabricante.ReadOnly = true;
            // 
            // pnlRodape
            // 
            this.pnlRodape.Controls.Add(this.btnSelecionar);
            this.pnlRodape.Controls.Add(this.lblMensagem);
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(0, 504);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(1149, 40);
            this.pnlRodape.TabIndex = 26;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(1062, 10);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 22);
            this.btnSelecionar.TabIndex = 1;
            this.btnSelecionar.Text = "&Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Visible = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(9, 13);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(196, 17);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Nenhum resultado encontrado";
            // 
            // menuAcoes
            // 
            this.menuAcoes.AutoSize = false;
            this.menuAcoes.BackColor = System.Drawing.Color.White;
            this.menuAcoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuAcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdicionar,
            this.menuEditar,
            this.menuDetalhes,
            this.menuAtivarDesativar,
            this.menuHistorico,
            this.menuMaisOpcoes,
            this.menuRelatorio});
            this.menuAcoes.Location = new System.Drawing.Point(0, 0);
            this.menuAcoes.Name = "menuAcoes";
            this.menuAcoes.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuAcoes.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuAcoes.Size = new System.Drawing.Size(1149, 37);
            this.menuAcoes.TabIndex = 24;
            // 
            // menuAdicionar
            // 
            this.menuAdicionar.Name = "menuAdicionar";
            this.menuAdicionar.Size = new System.Drawing.Size(70, 33);
            this.menuAdicionar.Text = "Adicionar";
            this.menuAdicionar.Click += new System.EventHandler(this.menuAdicionar_Click);
            // 
            // menuEditar
            // 
            this.menuEditar.Name = "menuEditar";
            this.menuEditar.Size = new System.Drawing.Size(49, 33);
            this.menuEditar.Text = "Editar";
            this.menuEditar.Click += new System.EventHandler(this.menuEditar_Click);
            // 
            // menuDetalhes
            // 
            this.menuDetalhes.Name = "menuDetalhes";
            this.menuDetalhes.Size = new System.Drawing.Size(64, 33);
            this.menuDetalhes.Text = "Detalhes";
            this.menuDetalhes.Click += new System.EventHandler(this.menuDetalhes_Click);
            // 
            // menuAtivarDesativar
            // 
            this.menuAtivarDesativar.Name = "menuAtivarDesativar";
            this.menuAtivarDesativar.Size = new System.Drawing.Size(67, 33);
            this.menuAtivarDesativar.Text = "Desativar";
            this.menuAtivarDesativar.Click += new System.EventHandler(this.menuDesativar_Click);
            // 
            // menuHistorico
            // 
            this.menuHistorico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHistMovimento,
            this.mHistPrecos});
            this.menuHistorico.Name = "menuHistorico";
            this.menuHistorico.Size = new System.Drawing.Size(72, 33);
            this.menuHistorico.Text = "Históricos";
            // 
            // mHistMovimento
            // 
            this.mHistMovimento.Name = "mHistMovimento";
            this.mHistMovimento.Size = new System.Drawing.Size(154, 22);
            this.mHistMovimento.Text = "Movimentação";
            this.mHistMovimento.Click += new System.EventHandler(this.movimentaçãoToolStripMenuItem_Click);
            // 
            // mHistPrecos
            // 
            this.mHistPrecos.Name = "mHistPrecos";
            this.mHistPrecos.Size = new System.Drawing.Size(154, 22);
            this.mHistPrecos.Text = "Preços";
            // 
            // menuMaisOpcoes
            // 
            this.menuMaisOpcoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mOpcaoEstruturaMercadologica,
            this.tributaçãoToolStripMenuItem,
            this.etiquetasToolStripMenuItem});
            this.menuMaisOpcoes.Name = "menuMaisOpcoes";
            this.menuMaisOpcoes.Size = new System.Drawing.Size(87, 33);
            this.menuMaisOpcoes.Text = "Mais Opções";
            // 
            // mOpcaoEstruturaMercadologica
            // 
            this.mOpcaoEstruturaMercadologica.Name = "mOpcaoEstruturaMercadologica";
            this.mOpcaoEstruturaMercadologica.Size = new System.Drawing.Size(203, 22);
            this.mOpcaoEstruturaMercadologica.Text = "Estrutura Mercadológica";
            this.mOpcaoEstruturaMercadologica.Click += new System.EventHandler(this.mOpcaoEstruturaMercadologica_Click);
            // 
            // tributaçãoToolStripMenuItem
            // 
            this.tributaçãoToolStripMenuItem.Name = "tributaçãoToolStripMenuItem";
            this.tributaçãoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.tributaçãoToolStripMenuItem.Text = "Tributação";
            // 
            // etiquetasToolStripMenuItem
            // 
            this.etiquetasToolStripMenuItem.Name = "etiquetasToolStripMenuItem";
            this.etiquetasToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.etiquetasToolStripMenuItem.Text = "Etiquetas";
            // 
            // menuRelatorio
            // 
            this.menuRelatorio.Name = "menuRelatorio";
            this.menuRelatorio.Size = new System.Drawing.Size(71, 33);
            this.menuRelatorio.Text = "Relatórios";
            // 
            // menuListarDesativados
            // 
            this.menuListarDesativados.Name = "menuListarDesativados";
            this.menuListarDesativados.Size = new System.Drawing.Size(167, 22);
            this.menuListarDesativados.Text = "Listar desativados";
            // 
            // menuListarTodos
            // 
            this.menuListarTodos.Name = "menuListarTodos";
            this.menuListarTodos.Size = new System.Drawing.Size(167, 22);
            this.menuListarTodos.Text = "Listar todos";
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // gruposToolStripMenuItem
            // 
            this.gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            this.gruposToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // subgruposToolStripMenuItem
            // 
            this.subgruposToolStripMenuItem.Name = "subgruposToolStripMenuItem";
            this.subgruposToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.subgruposToolStripMenuItem.Text = "Subgrupos";
            // 
            // semelhantesToolStripMenuItem
            // 
            this.semelhantesToolStripMenuItem.Name = "semelhantesToolStripMenuItem";
            this.semelhantesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.semelhantesToolStripMenuItem.Text = "Semelhantes";
            // 
            // pnFiltro
            // 
            this.pnFiltro.Controls.Add(this.btnPesquisa);
            this.pnFiltro.Controls.Add(this.lblProcurar);
            this.pnFiltro.Controls.Add(this.lblTipoFiltro);
            this.pnFiltro.Controls.Add(this.cbFiltro);
            this.pnFiltro.Controls.Add(this.txtPesquisar);
            this.pnFiltro.Location = new System.Drawing.Point(13, 40);
            this.pnFiltro.Name = "pnFiltro";
            this.pnFiltro.Size = new System.Drawing.Size(575, 49);
            this.pnFiltro.TabIndex = 28;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Enabled = false;
            this.btnPesquisa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.Image")));
            this.btnPesquisa.Location = new System.Drawing.Point(541, 18);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(28, 22);
            this.btnPesquisa.TabIndex = 43;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            // 
            // lblProcurar
            // 
            this.lblProcurar.AutoSize = true;
            this.lblProcurar.Location = new System.Drawing.Point(129, 0);
            this.lblProcurar.Name = "lblProcurar";
            this.lblProcurar.Size = new System.Drawing.Size(78, 15);
            this.lblProcurar.TabIndex = 28;
            this.lblProcurar.Text = "Procurar por";
            // 
            // lblTipoFiltro
            // 
            this.lblTipoFiltro.AutoSize = true;
            this.lblTipoFiltro.Location = new System.Drawing.Point(3, 0);
            this.lblTipoFiltro.Name = "lblTipoFiltro";
            this.lblTipoFiltro.Size = new System.Drawing.Size(37, 15);
            this.lblTipoFiltro.TabIndex = 27;
            this.lblTipoFiltro.Text = "Filtro";
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(6, 18);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(121, 23);
            this.cbFiltro.TabIndex = 0;
            this.cbFiltro.Leave += new System.EventHandler(this.cbFiltro_Leave);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisar.Location = new System.Drawing.Point(133, 18);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(406, 23);
            this.txtPesquisar.TabIndex = 1;
            this.txtPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyDown);
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // chboxDesativados
            // 
            this.chboxDesativados.AutoSize = true;
            this.chboxDesativados.Location = new System.Drawing.Point(594, 60);
            this.chboxDesativados.Name = "chboxDesativados";
            this.chboxDesativados.Size = new System.Drawing.Size(141, 19);
            this.chboxDesativados.TabIndex = 29;
            this.chboxDesativados.Text = "Somente desativados";
            this.chboxDesativados.UseVisualStyleBackColor = true;
            // 
            // formConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1149, 544);
            this.Controls.Add(this.chboxDesativados);
            this.Controls.Add(this.pnFiltro);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.menuAcoes);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "formConsultaProduto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.pnlRodape.ResumeLayout(false);
            this.pnlRodape.PerformLayout();
            this.menuAcoes.ResumeLayout(false);
            this.menuAcoes.PerformLayout();
            this.pnFiltro.ResumeLayout(false);
            this.pnFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.MenuStrip menuAcoes;
        private System.Windows.Forms.ToolStripMenuItem menuListarDesativados;
        private System.Windows.Forms.ToolStripMenuItem menuListarTodos;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subgruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semelhantesToolStripMenuItem;
        private System.Windows.Forms.Panel pnFiltro;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Label lblProcurar;
        private System.Windows.Forms.Label lblTipoFiltro;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ToolStripMenuItem menuAdicionar;
        private System.Windows.Forms.ToolStripMenuItem menuEditar;
        private System.Windows.Forms.ToolStripMenuItem menuDetalhes;
        private System.Windows.Forms.ToolStripMenuItem menuAtivarDesativar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.CheckBox chboxDesativados;
        private System.Windows.Forms.ToolStripMenuItem menuHistorico;
        private System.Windows.Forms.ToolStripMenuItem mHistMovimento;
        private System.Windows.Forms.ToolStripMenuItem mHistPrecos;
        private System.Windows.Forms.ToolStripMenuItem menuMaisOpcoes;
        private System.Windows.Forms.ToolStripMenuItem mOpcaoEstruturaMercadologica;
        private System.Windows.Forms.ToolStripMenuItem tributaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etiquetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn custo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn margem;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricante;
    }
}