namespace Sistema.Financeiro.Interfaces
{
    partial class formPlanoDeContas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPlanoDeContas));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvPlanoContas = new System.Windows.Forms.DataGridView();
            this.dvgPlanoContaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgPlanoContanome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgPlanoContaDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgplanoContaNatureza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.ckCredito = new System.Windows.Forms.CheckBox();
            this.ckDebito = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalhesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desativarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanoContas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lblMensagem);
            this.panel2.Controls.Add(this.btnNovo);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Location = new System.Drawing.Point(1, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 53);
            this.panel2.TabIndex = 2;
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(11, 17);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(196, 17);
            this.lblMensagem.TabIndex = 7;
            this.lblMensagem.Text = "Nenhum resultado encontrado";
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(408, 6);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 40);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(511, 6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 40);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(614, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // dgvPlanoContas
            // 
            this.dgvPlanoContas.AllowUserToAddRows = false;
            this.dgvPlanoContas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlanoContas.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlanoContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanoContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgPlanoContaID,
            this.dvgPlanoContanome,
            this.dvgPlanoContaDescricao,
            this.dvgplanoContaNatureza});
            this.dgvPlanoContas.Location = new System.Drawing.Point(12, 94);
            this.dgvPlanoContas.Name = "dgvPlanoContas";
            this.dgvPlanoContas.ReadOnly = true;
            this.dgvPlanoContas.Size = new System.Drawing.Size(703, 298);
            this.dgvPlanoContas.TabIndex = 3;
            // 
            // dvgPlanoContaID
            // 
            this.dvgPlanoContaID.HeaderText = "ID";
            this.dvgPlanoContaID.Name = "dvgPlanoContaID";
            this.dvgPlanoContaID.ReadOnly = true;
            this.dvgPlanoContaID.Width = 60;
            // 
            // dvgPlanoContanome
            // 
            this.dvgPlanoContanome.HeaderText = "Nome";
            this.dvgPlanoContanome.Name = "dvgPlanoContanome";
            this.dvgPlanoContanome.ReadOnly = true;
            this.dvgPlanoContanome.Width = 200;
            // 
            // dvgPlanoContaDescricao
            // 
            this.dvgPlanoContaDescricao.HeaderText = "Descrição";
            this.dvgPlanoContaDescricao.Name = "dvgPlanoContaDescricao";
            this.dvgPlanoContaDescricao.ReadOnly = true;
            this.dvgPlanoContaDescricao.Width = 300;
            // 
            // dvgplanoContaNatureza
            // 
            this.dvgplanoContaNatureza.HeaderText = "Natureza";
            this.dvgplanoContaNatureza.Name = "dvgplanoContaNatureza";
            this.dvgplanoContaNatureza.ReadOnly = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(255, 20);
            this.txtNome.TabIndex = 0;
            // 
            // ckCredito
            // 
            this.ckCredito.AutoSize = true;
            this.ckCredito.Checked = true;
            this.ckCredito.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckCredito.Location = new System.Drawing.Point(593, 51);
            this.ckCredito.Name = "ckCredito";
            this.ckCredito.Size = new System.Drawing.Size(59, 17);
            this.ckCredito.TabIndex = 3;
            this.ckCredito.Text = "Credito";
            this.ckCredito.UseVisualStyleBackColor = true;
            // 
            // ckDebito
            // 
            this.ckDebito.AutoSize = true;
            this.ckDebito.Location = new System.Drawing.Point(654, 51);
            this.ckDebito.Name = "ckDebito";
            this.ckDebito.Size = new System.Drawing.Size(57, 17);
            this.ckDebito.TabIndex = 4;
            this.ckDebito.Text = "Debito";
            this.ckDebito.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.detalhesToolStripMenuItem,
            this.desativarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // detalhesToolStripMenuItem
            // 
            this.detalhesToolStripMenuItem.Name = "detalhesToolStripMenuItem";
            this.detalhesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.detalhesToolStripMenuItem.Text = "Detalhes";
            // 
            // desativarToolStripMenuItem
            // 
            this.desativarToolStripMenuItem.Name = "desativarToolStripMenuItem";
            this.desativarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.desativarToolStripMenuItem.Text = "Desativar";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(534, 49);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(34, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(273, 51);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(255, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 35);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(270, 35);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 9;
            this.lblDescricao.Text = "Descrição";
            // 
            // formPlanoDeContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(728, 464);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.ckDebito);
            this.Controls.Add(this.ckCredito);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvPlanoContas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formPlanoDeContas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plano de contas";
            this.Load += new System.EventHandler(this.formPlanoDeContas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanoContas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.CheckBox ckCredito;
        private System.Windows.Forms.CheckBox ckDebito;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalhesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desativarToolStripMenuItem;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.DataGridView dgvPlanoContas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgPlanoContaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgPlanoContanome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgPlanoContaDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgplanoContaNatureza;
        private System.Windows.Forms.Label lblMensagem;
    }
}