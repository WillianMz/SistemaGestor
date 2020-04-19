namespace Sistema.Estoque.Interfaces
{
    partial class formClassifProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formClassifProdutos));
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.gbTabelas = new System.Windows.Forms.GroupBox();
            this.btnEditarSubgrupo = new System.Windows.Forms.Button();
            this.btnEditarGrupo = new System.Windows.Forms.Button();
            this.btnEditarCategoria = new System.Windows.Forms.Button();
            this.btnNovoSubgrupo = new System.Windows.Forms.Button();
            this.btnNovoGrupo = new System.Windows.Forms.Button();
            this.btnNovaCategoria = new System.Windows.Forms.Button();
            this.dgvSubgrupos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.chboxDesativados = new System.Windows.Forms.CheckBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.menuCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrupo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSubgrupo = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlRodape.SuspendLayout();
            this.gbTabelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubgrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.menu.SuspendLayout();
            this.pnlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRodape
            // 
            this.pnlRodape.Controls.Add(this.btnSelecionar);
            this.pnlRodape.Controls.Add(this.lblMensagem);
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(0, 431);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(964, 40);
            this.pnlRodape.TabIndex = 27;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(877, 12);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
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
            // gbTabelas
            // 
            this.gbTabelas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTabelas.Controls.Add(this.btnEditarSubgrupo);
            this.gbTabelas.Controls.Add(this.btnEditarGrupo);
            this.gbTabelas.Controls.Add(this.btnEditarCategoria);
            this.gbTabelas.Controls.Add(this.btnNovoSubgrupo);
            this.gbTabelas.Controls.Add(this.btnNovoGrupo);
            this.gbTabelas.Controls.Add(this.btnNovaCategoria);
            this.gbTabelas.Controls.Add(this.dgvSubgrupos);
            this.gbTabelas.Controls.Add(this.dgvGrupos);
            this.gbTabelas.Controls.Add(this.dgvCategorias);
            this.gbTabelas.Location = new System.Drawing.Point(12, 66);
            this.gbTabelas.Name = "gbTabelas";
            this.gbTabelas.Size = new System.Drawing.Size(940, 359);
            this.gbTabelas.TabIndex = 32;
            this.gbTabelas.TabStop = false;
            // 
            // btnEditarSubgrupo
            // 
            this.btnEditarSubgrupo.Location = new System.Drawing.Point(744, 330);
            this.btnEditarSubgrupo.Name = "btnEditarSubgrupo";
            this.btnEditarSubgrupo.Size = new System.Drawing.Size(110, 23);
            this.btnEditarSubgrupo.TabIndex = 40;
            this.btnEditarSubgrupo.Text = "Editar Su&bgrupo";
            this.btnEditarSubgrupo.UseVisualStyleBackColor = true;
            this.btnEditarSubgrupo.Click += new System.EventHandler(this.btnEditarSubgrupo_Click);
            // 
            // btnEditarGrupo
            // 
            this.btnEditarGrupo.Location = new System.Drawing.Point(433, 330);
            this.btnEditarGrupo.Name = "btnEditarGrupo";
            this.btnEditarGrupo.Size = new System.Drawing.Size(110, 23);
            this.btnEditarGrupo.TabIndex = 39;
            this.btnEditarGrupo.Text = "Editar G&rupo";
            this.btnEditarGrupo.UseVisualStyleBackColor = true;
            this.btnEditarGrupo.Click += new System.EventHandler(this.btnEditarGrupo_Click);
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.Location = new System.Drawing.Point(122, 330);
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(110, 23);
            this.btnEditarCategoria.TabIndex = 38;
            this.btnEditarCategoria.Text = "Editar Ca&tegoria";
            this.btnEditarCategoria.UseVisualStyleBackColor = true;
            this.btnEditarCategoria.Click += new System.EventHandler(this.btnEditarCategoria_Click);
            // 
            // btnNovoSubgrupo
            // 
            this.btnNovoSubgrupo.Location = new System.Drawing.Point(628, 330);
            this.btnNovoSubgrupo.Name = "btnNovoSubgrupo";
            this.btnNovoSubgrupo.Size = new System.Drawing.Size(110, 23);
            this.btnNovoSubgrupo.TabIndex = 37;
            this.btnNovoSubgrupo.Text = "Novo &Subgrupo";
            this.btnNovoSubgrupo.UseVisualStyleBackColor = true;
            this.btnNovoSubgrupo.Click += new System.EventHandler(this.btnNovoSubgrupo_Click);
            // 
            // btnNovoGrupo
            // 
            this.btnNovoGrupo.Location = new System.Drawing.Point(317, 330);
            this.btnNovoGrupo.Name = "btnNovoGrupo";
            this.btnNovoGrupo.Size = new System.Drawing.Size(110, 23);
            this.btnNovoGrupo.TabIndex = 36;
            this.btnNovoGrupo.Text = "Novo &Grupo";
            this.btnNovoGrupo.UseVisualStyleBackColor = true;
            this.btnNovoGrupo.Click += new System.EventHandler(this.btnNovoGrupo_Click);
            // 
            // btnNovaCategoria
            // 
            this.btnNovaCategoria.Location = new System.Drawing.Point(6, 330);
            this.btnNovaCategoria.Name = "btnNovaCategoria";
            this.btnNovaCategoria.Size = new System.Drawing.Size(110, 23);
            this.btnNovaCategoria.TabIndex = 35;
            this.btnNovaCategoria.Text = "Nova &Categoria";
            this.btnNovaCategoria.UseVisualStyleBackColor = true;
            this.btnNovaCategoria.Click += new System.EventHandler(this.btnNovaCategoria_Click);
            // 
            // dgvSubgrupos
            // 
            this.dgvSubgrupos.AllowUserToAddRows = false;
            this.dgvSubgrupos.AllowUserToDeleteRows = false;
            this.dgvSubgrupos.AllowUserToResizeRows = false;
            this.dgvSubgrupos.BackgroundColor = System.Drawing.Color.White;
            this.dgvSubgrupos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSubgrupos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvSubgrupos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSubgrupos.ColumnHeadersHeight = 30;
            this.dgvSubgrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSubgrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvSubgrupos.Location = new System.Drawing.Point(628, 20);
            this.dgvSubgrupos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSubgrupos.MultiSelect = false;
            this.dgvSubgrupos.Name = "dgvSubgrupos";
            this.dgvSubgrupos.ReadOnly = true;
            this.dgvSubgrupos.RowHeadersVisible = false;
            this.dgvSubgrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubgrupos.Size = new System.Drawing.Size(306, 305);
            this.dgvSubgrupos.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 15F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Cód.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Subgrupo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 230;
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.AllowUserToAddRows = false;
            this.dgvGrupos.AllowUserToDeleteRows = false;
            this.dgvGrupos.AllowUserToResizeRows = false;
            this.dgvGrupos.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrupos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGrupos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvGrupos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvGrupos.ColumnHeadersHeight = 30;
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvGrupos.Location = new System.Drawing.Point(317, 20);
            this.dgvGrupos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGrupos.MultiSelect = false;
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.ReadOnly = true;
            this.dgvGrupos.RowHeadersVisible = false;
            this.dgvGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrupos.Size = new System.Drawing.Size(305, 305);
            this.dgvGrupos.TabIndex = 33;
            this.dgvGrupos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupos_CellClick);
            this.dgvGrupos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvGrupos_KeyUp);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 15F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Cód.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Grupo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 230;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.AllowUserToResizeRows = false;
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategorias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCategorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCategorias.ColumnHeadersHeight = 30;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNome});
            this.dgvCategorias.Location = new System.Drawing.Point(6, 20);
            this.dgvCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.RowHeadersVisible = false;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(305, 305);
            this.dgvCategorias.TabIndex = 32;
            this.dgvCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellClick);
            this.dgvCategorias.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvCategorias_KeyUp);
            // 
            // colID
            // 
            this.colID.HeaderText = "Cód.";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 50;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Categoria";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 230;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.Enabled = false;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCategoria,
            this.menuGrupo,
            this.menuSubgrupo});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(964, 24);
            this.menu.TabIndex = 36;
            this.menu.Text = "menuStrip1";
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Controls.Add(this.btnPesquisa);
            this.pnlSuperior.Controls.Add(this.chboxDesativados);
            this.pnlSuperior.Controls.Add(this.txtNome);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 24);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(964, 36);
            this.pnlSuperior.TabIndex = 37;
            // 
            // chboxDesativados
            // 
            this.chboxDesativados.AutoSize = true;
            this.chboxDesativados.Location = new System.Drawing.Point(385, 9);
            this.chboxDesativados.Name = "chboxDesativados";
            this.chboxDesativados.Size = new System.Drawing.Size(143, 18);
            this.chboxDesativados.TabIndex = 38;
            this.chboxDesativados.Text = "Somente desativados";
            this.chboxDesativados.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 7);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(333, 22);
            this.txtNome.TabIndex = 37;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Enabled = false;
            this.btnPesquisa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.Image")));
            this.btnPesquisa.Location = new System.Drawing.Point(348, 7);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(28, 22);
            this.btnPesquisa.TabIndex = 44;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            // 
            // menuCategoria
            // 
            this.menuCategoria.Name = "menuCategoria";
            this.menuCategoria.Size = new System.Drawing.Size(70, 20);
            this.menuCategoria.Text = "Categoria";
            // 
            // menuGrupo
            // 
            this.menuGrupo.Name = "menuGrupo";
            this.menuGrupo.Size = new System.Drawing.Size(52, 20);
            this.menuGrupo.Text = "Grupo";
            // 
            // menuSubgrupo
            // 
            this.menuSubgrupo.Name = "menuSubgrupo";
            this.menuSubgrupo.Size = new System.Drawing.Size(71, 20);
            this.menuSubgrupo.Text = "Subgrupo";
            // 
            // formClassifProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 471);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.gbTabelas);
            this.Controls.Add(this.pnlRodape);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formClassifProdutos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classificação de Produtos";
            this.pnlRodape.ResumeLayout(false);
            this.pnlRodape.PerformLayout();
            this.gbTabelas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubgrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.GroupBox gbTabelas;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.CheckBox chboxDesativados;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgvSubgrupos;
        private System.Windows.Forms.DataGridView dgvGrupos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnNovoSubgrupo;
        private System.Windows.Forms.Button btnNovoGrupo;
        private System.Windows.Forms.Button btnNovaCategoria;
        private System.Windows.Forms.Button btnEditarSubgrupo;
        private System.Windows.Forms.Button btnEditarGrupo;
        private System.Windows.Forms.Button btnEditarCategoria;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.ToolStripMenuItem menuCategoria;
        private System.Windows.Forms.ToolStripMenuItem menuGrupo;
        private System.Windows.Forms.ToolStripMenuItem menuSubgrupo;
    }
}