namespace Sistema.Financeiro.Interfaces
{
    partial class formCadastroBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadastroBanco));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodBanco = new System.Windows.Forms.TextBox();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.dbGridListaBanco = new System.Windows.Forms.DataGridView();
            this.gridIdBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCodBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridNomeBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridAgenciaBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridContaBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckAtivo = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnMenuListar = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridListaBanco)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cod. Banco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Agencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Conta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(15, 53);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(123, 53);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(451, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtCodBanco
            // 
            this.txtCodBanco.Enabled = false;
            this.txtCodBanco.Location = new System.Drawing.Point(15, 103);
            this.txtCodBanco.Name = "txtCodBanco";
            this.txtCodBanco.Size = new System.Drawing.Size(116, 20);
            this.txtCodBanco.TabIndex = 2;
            // 
            // txtAgencia
            // 
            this.txtAgencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAgencia.Enabled = false;
            this.txtAgencia.Location = new System.Drawing.Point(141, 103);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(116, 20);
            this.txtAgencia.TabIndex = 3;
            // 
            // txtConta
            // 
            this.txtConta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConta.Enabled = false;
            this.txtConta.Location = new System.Drawing.Point(266, 103);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(116, 20);
            this.txtConta.TabIndex = 4;
            // 
            // dbGridListaBanco
            // 
            this.dbGridListaBanco.BackgroundColor = System.Drawing.Color.White;
            this.dbGridListaBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGridListaBanco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridIdBanco,
            this.gridCodBanco,
            this.gridNomeBanco,
            this.gridAgenciaBanco,
            this.gridContaBanco});
            this.dbGridListaBanco.Location = new System.Drawing.Point(15, 136);
            this.dbGridListaBanco.Name = "dbGridListaBanco";
            this.dbGridListaBanco.ReadOnly = true;
            this.dbGridListaBanco.RowHeadersVisible = false;
            this.dbGridListaBanco.Size = new System.Drawing.Size(773, 330);
            this.dbGridListaBanco.TabIndex = 13;
            // 
            // gridIdBanco
            // 
            this.gridIdBanco.HeaderText = "ID";
            this.gridIdBanco.Name = "gridIdBanco";
            this.gridIdBanco.ReadOnly = true;
            this.gridIdBanco.Width = 60;
            // 
            // gridCodBanco
            // 
            this.gridCodBanco.HeaderText = "Cod. Banco";
            this.gridCodBanco.Name = "gridCodBanco";
            this.gridCodBanco.ReadOnly = true;
            // 
            // gridNomeBanco
            // 
            this.gridNomeBanco.HeaderText = "Nome";
            this.gridNomeBanco.Name = "gridNomeBanco";
            this.gridNomeBanco.ReadOnly = true;
            this.gridNomeBanco.Width = 350;
            // 
            // gridAgenciaBanco
            // 
            this.gridAgenciaBanco.HeaderText = "Agência";
            this.gridAgenciaBanco.Name = "gridAgenciaBanco";
            this.gridAgenciaBanco.ReadOnly = true;
            this.gridAgenciaBanco.Width = 130;
            // 
            // gridContaBanco
            // 
            this.gridContaBanco.HeaderText = "Conta";
            this.gridContaBanco.Name = "gridContaBanco";
            this.gridContaBanco.ReadOnly = true;
            this.gridContaBanco.Width = 130;
            // 
            // ckAtivo
            // 
            this.ckAtivo.AutoSize = true;
            this.ckAtivo.Checked = true;
            this.ckAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckAtivo.Location = new System.Drawing.Point(738, 40);
            this.ckAtivo.Name = "ckAtivo";
            this.ckAtivo.Size = new System.Drawing.Size(50, 17);
            this.ckAtivo.TabIndex = 20;
            this.ckAtivo.Text = "Ativo";
            this.ckAtivo.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuListar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnMenuListar
            // 
            this.btnMenuListar.Name = "btnMenuListar";
            this.btnMenuListar.Size = new System.Drawing.Size(47, 20);
            this.btnMenuListar.Text = "Listar";
            this.btnMenuListar.Click += new System.EventHandler(this.btnMenuListar_Click);
            // 
            // pnlRodape
            // 
            this.pnlRodape.Controls.Add(this.btnNovo);
            this.pnlRodape.Controls.Add(this.btnEditar);
            this.pnlRodape.Controls.Add(this.btnSalvar);
            this.pnlRodape.Controls.Add(this.btnCancelar);
            this.pnlRodape.Controls.Add(this.lblResultado);
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(0, 500);
            this.pnlRodape.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(798, 47);
            this.pnlRodape.TabIndex = 57;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(380, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 40);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(484, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 40);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(587, 3);
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
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(690, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(13, 14);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(24, 15);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "</>";
            // 
            // formCadastroBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 547);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.ckAtivo);
            this.Controls.Add(this.dbGridListaBanco);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.txtAgencia);
            this.Controls.Add(this.txtCodBanco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCadastroBanco";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Banco";
            ((System.ComponentModel.ISupportInitialize)(this.dbGridListaBanco)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlRodape.ResumeLayout(false);
            this.pnlRodape.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodBanco;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.DataGridView dbGridListaBanco;
        private System.Windows.Forms.CheckBox ckAtivo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridIdBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridCodBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridNomeBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridAgenciaBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridContaBanco;
        private System.Windows.Forms.ToolStripMenuItem btnMenuListar;
    }
}