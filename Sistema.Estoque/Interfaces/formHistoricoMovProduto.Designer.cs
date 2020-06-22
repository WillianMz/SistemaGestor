namespace Sistema.Estoque.Interfaces
{
    partial class formHistoricoMovProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCarregarHistorico = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.colPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHistorico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVLTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.btnConsultarReg = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnSelecionarPessoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.pnlRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 29;
            this.label1.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 30;
            this.label2.Text = "Produto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 22);
            this.textBox1.TabIndex = 31;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 22);
            this.comboBox1.TabIndex = 32;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(212, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(484, 22);
            this.textBox2.TabIndex = 33;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(333, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 22);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(466, 82);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(96, 22);
            this.dateTimePicker2.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 36;
            this.label3.Text = "Periódo";
            // 
            // btnCarregarHistorico
            // 
            this.btnCarregarHistorico.Location = new System.Drawing.Point(568, 82);
            this.btnCarregarHistorico.Name = "btnCarregarHistorico";
            this.btnCarregarHistorico.Size = new System.Drawing.Size(128, 23);
            this.btnCarregarHistorico.TabIndex = 37;
            this.btnCarregarHistorico.Text = "Carregar Histórico";
            this.btnCarregarHistorico.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Últimos 5 dias",
            "Últimos 15 dias",
            "Últimos 30 dias",
            "Últimos 60 dias",
            "Últimos 90 dias",
            "Período específico"});
            this.comboBox2.Location = new System.Drawing.Point(72, 82);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(145, 22);
            this.comboBox2.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 14);
            this.label4.TabIndex = 39;
            this.label4.Text = "até";
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AllowUserToAddRows = false;
            this.dgvEstoque.AllowUserToDeleteRows = false;
            this.dgvEstoque.AllowUserToResizeRows = false;
            this.dgvEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstoque.BackgroundColor = System.Drawing.Color.White;
            this.dgvEstoque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEstoque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvEstoque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvEstoque.ColumnHeadersHeight = 30;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPessoa,
            this.colMovimento,
            this.colHistorico,
            this.colData,
            this.colQtd,
            this.colValorUN,
            this.colVLTotal});
            this.dgvEstoque.Location = new System.Drawing.Point(12, 111);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.RowHeadersVisible = false;
            this.dgvEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstoque.Size = new System.Drawing.Size(688, 343);
            this.dgvEstoque.TabIndex = 28;
            // 
            // colPessoa
            // 
            this.colPessoa.HeaderText = "Pessoa";
            this.colPessoa.Name = "colPessoa";
            this.colPessoa.ReadOnly = true;
            this.colPessoa.Width = 300;
            // 
            // colMovimento
            // 
            this.colMovimento.HeaderText = "Tp.Movimento";
            this.colMovimento.Name = "colMovimento";
            this.colMovimento.ReadOnly = true;
            this.colMovimento.Width = 200;
            // 
            // colHistorico
            // 
            this.colHistorico.HeaderText = "Histórico";
            this.colHistorico.Name = "colHistorico";
            this.colHistorico.ReadOnly = true;
            this.colHistorico.Width = 250;
            // 
            // colData
            // 
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.colData.DefaultCellStyle = dataGridViewCellStyle1;
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            this.colData.Width = 150;
            // 
            // colQtd
            // 
            this.colQtd.HeaderText = "Quantidade";
            this.colQtd.Name = "colQtd";
            this.colQtd.ReadOnly = true;
            // 
            // colValorUN
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.colValorUN.DefaultCellStyle = dataGridViewCellStyle2;
            this.colValorUN.HeaderText = "Vlr.Unitário";
            this.colValorUN.Name = "colValorUN";
            this.colValorUN.ReadOnly = true;
            // 
            // colVLTotal
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.colVLTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.colVLTotal.HeaderText = "Vlr.Total";
            this.colVLTotal.Name = "colVLTotal";
            this.colVLTotal.ReadOnly = true;
            // 
            // pnlRodape
            // 
            this.pnlRodape.Controls.Add(this.btnConsultarReg);
            this.pnlRodape.Controls.Add(this.lblMensagem);
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(0, 460);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(712, 40);
            this.pnlRodape.TabIndex = 40;
            // 
            // btnConsultarReg
            // 
            this.btnConsultarReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultarReg.Location = new System.Drawing.Point(571, 12);
            this.btnConsultarReg.Name = "btnConsultarReg";
            this.btnConsultarReg.Size = new System.Drawing.Size(129, 22);
            this.btnConsultarReg.TabIndex = 1;
            this.btnConsultarReg.Text = "&Consultar Registro";
            this.btnConsultarReg.UseVisualStyleBackColor = true;
            this.btnConsultarReg.Visible = false;
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 18);
            this.checkBox1.TabIndex = 41;
            this.checkBox1.Text = "Filtrar por pessoa";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 14);
            this.label5.TabIndex = 42;
            this.label5.Text = "Pessoa";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(212, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(445, 22);
            this.textBox3.TabIndex = 43;
            // 
            // btnSelecionarPessoa
            // 
            this.btnSelecionarPessoa.Location = new System.Drawing.Point(660, 53);
            this.btnSelecionarPessoa.Name = "btnSelecionarPessoa";
            this.btnSelecionarPessoa.Size = new System.Drawing.Size(36, 23);
            this.btnSelecionarPessoa.TabIndex = 44;
            this.btnSelecionarPessoa.Text = "...";
            this.btnSelecionarPessoa.UseVisualStyleBackColor = true;
            // 
            // formHistoricoMovProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 500);
            this.Controls.Add(this.btnSelecionarPessoa);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnCarregarHistorico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEstoque);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "formHistoricoMovProduto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico de Movimentação";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.pnlRodape.ResumeLayout(false);
            this.pnlRodape.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCarregarHistorico;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHistorico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVLTotal;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Button btnConsultarReg;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnSelecionarPessoa;
    }
}