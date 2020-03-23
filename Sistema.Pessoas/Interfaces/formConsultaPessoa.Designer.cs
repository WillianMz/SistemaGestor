namespace Sistema.Pessoas.Interfaces
{
    partial class formConsultaPessoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formConsultaPessoa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuAcoes = new System.Windows.Forms.MenuStrip();
            this.menuAdicionar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDetalhes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDesativar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.desativadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPessoa = new System.Windows.Forms.DataGridView();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pnFiltro = new System.Windows.Forms.Panel();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.lblProcurar = new System.Windows.Forms.Label();
            this.lblTipoFiltro = new System.Windows.Forms.Label();
            this.cboxFiltro = new System.Windows.Forms.ComboBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuAcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoa)).BeginInit();
            this.pnlRodape.SuspendLayout();
            this.pnFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAcoes
            // 
            this.menuAcoes.AutoSize = false;
            this.menuAcoes.BackColor = System.Drawing.Color.Transparent;
            this.menuAcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdicionar,
            this.menuDetalhes,
            this.menuEditar,
            this.menuDesativar,
            this.menuConsultas});
            this.menuAcoes.Location = new System.Drawing.Point(0, 0);
            this.menuAcoes.Name = "menuAcoes";
            this.menuAcoes.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuAcoes.Size = new System.Drawing.Size(1066, 32);
            this.menuAcoes.TabIndex = 0;
            this.menuAcoes.Text = "menuStrip1";
            // 
            // menuAdicionar
            // 
            this.menuAdicionar.Name = "menuAdicionar";
            this.menuAdicionar.Size = new System.Drawing.Size(70, 28);
            this.menuAdicionar.Text = "Adicionar";
            this.menuAdicionar.Click += new System.EventHandler(this.menuAdicionar_Click);
            // 
            // menuDetalhes
            // 
            this.menuDetalhes.Name = "menuDetalhes";
            this.menuDetalhes.Size = new System.Drawing.Size(64, 28);
            this.menuDetalhes.Text = "Detalhes";
            this.menuDetalhes.Click += new System.EventHandler(this.menuDetalhes_Click);
            // 
            // menuEditar
            // 
            this.menuEditar.Name = "menuEditar";
            this.menuEditar.Size = new System.Drawing.Size(49, 28);
            this.menuEditar.Text = "Editar";
            this.menuEditar.Click += new System.EventHandler(this.menuEditar_Click);
            // 
            // menuDesativar
            // 
            this.menuDesativar.Name = "menuDesativar";
            this.menuDesativar.Size = new System.Drawing.Size(67, 28);
            this.menuDesativar.Text = "Desativar";
            this.menuDesativar.Click += new System.EventHandler(this.menuDesativar_Click);
            // 
            // menuConsultas
            // 
            this.menuConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desativadosToolStripMenuItem});
            this.menuConsultas.Name = "menuConsultas";
            this.menuConsultas.Size = new System.Drawing.Size(71, 28);
            this.menuConsultas.Text = "Consultas";
            // 
            // desativadosToolStripMenuItem
            // 
            this.desativadosToolStripMenuItem.Name = "desativadosToolStripMenuItem";
            this.desativadosToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.desativadosToolStripMenuItem.Text = "Desativados";
            // 
            // dgvPessoa
            // 
            this.dgvPessoa.AllowUserToAddRows = false;
            this.dgvPessoa.AllowUserToDeleteRows = false;
            this.dgvPessoa.AllowUserToResizeRows = false;
            this.dgvPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPessoa.BackgroundColor = System.Drawing.Color.White;
            this.dgvPessoa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPessoa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvPessoa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPessoa.ColumnHeadersHeight = 30;
            this.dgvPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPessoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNome,
            this.colFantasia,
            this.colCNPJ,
            this.colTelefone,
            this.colEmail,
            this.colLocalizacao});
            this.dgvPessoa.Location = new System.Drawing.Point(12, 93);
            this.dgvPessoa.MultiSelect = false;
            this.dgvPessoa.Name = "dgvPessoa";
            this.dgvPessoa.ReadOnly = true;
            this.dgvPessoa.RowHeadersVisible = false;
            this.dgvPessoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPessoa.Size = new System.Drawing.Size(1042, 340);
            this.dgvPessoa.TabIndex = 2;
            // 
            // pnlRodape
            // 
            this.pnlRodape.Controls.Add(this.lblResultado);
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(0, 439);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(1066, 36);
            this.pnlRodape.TabIndex = 3;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(8, 10);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(187, 17);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Nenhum resultado disponível";
            // 
            // pnFiltro
            // 
            this.pnFiltro.Controls.Add(this.btnPesquisa);
            this.pnFiltro.Controls.Add(this.lblProcurar);
            this.pnFiltro.Controls.Add(this.lblTipoFiltro);
            this.pnFiltro.Controls.Add(this.cboxFiltro);
            this.pnFiltro.Controls.Add(this.txtPesquisar);
            this.pnFiltro.Location = new System.Drawing.Point(12, 35);
            this.pnFiltro.Name = "pnFiltro";
            this.pnFiltro.Size = new System.Drawing.Size(581, 52);
            this.pnFiltro.TabIndex = 1;
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
            // cboxFiltro
            // 
            this.cboxFiltro.FormattingEnabled = true;
            this.cboxFiltro.Location = new System.Drawing.Point(6, 18);
            this.cboxFiltro.Name = "cboxFiltro";
            this.cboxFiltro.Size = new System.Drawing.Size(121, 23);
            this.cboxFiltro.TabIndex = 0;
            this.cboxFiltro.Leave += new System.EventHandler(this.cboxFiltro_Leave);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisar.Location = new System.Drawing.Point(133, 18);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(406, 23);
            this.txtPesquisar.TabIndex = 1;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // colID
            // 
            this.colID.FillWeight = 15F;
            this.colID.HeaderText = "Cód.";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 70;
            // 
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNome.DefaultCellStyle = dataGridViewCellStyle1;
            this.colNome.FillWeight = 90F;
            this.colNome.HeaderText = "Nome Completo";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colFantasia
            // 
            this.colFantasia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.NullValue = null;
            this.colFantasia.DefaultCellStyle = dataGridViewCellStyle2;
            this.colFantasia.FillWeight = 50F;
            this.colFantasia.HeaderText = "Fantasia/Apelido";
            this.colFantasia.Name = "colFantasia";
            this.colFantasia.ReadOnly = true;
            // 
            // colCNPJ
            // 
            this.colCNPJ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "00\\.000\\.000/0000-00";
            dataGridViewCellStyle3.NullValue = null;
            this.colCNPJ.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCNPJ.FillWeight = 70F;
            this.colCNPJ.HeaderText = "CPF/CNPJ";
            this.colCNPJ.Name = "colCNPJ";
            this.colCNPJ.ReadOnly = true;
            // 
            // colTelefone
            // 
            this.colTelefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "(00)00000-0009";
            dataGridViewCellStyle4.NullValue = null;
            this.colTelefone.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colLocalizacao
            // 
            this.colLocalizacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLocalizacao.HeaderText = "Localização";
            this.colLocalizacao.Name = "colLocalizacao";
            this.colLocalizacao.ReadOnly = true;
            // 
            // formConsultaPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1066, 475);
            this.Controls.Add(this.dgvPessoa);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnFiltro);
            this.Controls.Add(this.menuAcoes);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "formConsultaPessoa";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta pessoas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formConsultaPessoa_KeyDown);
            this.menuAcoes.ResumeLayout(false);
            this.menuAcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoa)).EndInit();
            this.pnlRodape.ResumeLayout(false);
            this.pnlRodape.PerformLayout();
            this.pnFiltro.ResumeLayout(false);
            this.pnFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAcoes;
        private System.Windows.Forms.ToolStripMenuItem menuAdicionar;
        private System.Windows.Forms.ToolStripMenuItem menuDetalhes;
        private System.Windows.Forms.ToolStripMenuItem menuEditar;
        private System.Windows.Forms.ToolStripMenuItem menuDesativar;
        private System.Windows.Forms.DataGridView dgvPessoa;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Panel pnFiltro;
        private System.Windows.Forms.ToolStripMenuItem menuConsultas;
        private System.Windows.Forms.Label lblProcurar;
        private System.Windows.Forms.Label lblTipoFiltro;
        private System.Windows.Forms.ComboBox cboxFiltro;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.ToolStripMenuItem desativadosToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalizacao;
    }
}