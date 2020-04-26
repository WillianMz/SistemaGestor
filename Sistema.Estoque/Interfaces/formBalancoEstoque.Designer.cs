namespace Sistema.Estoque.Interfaces
{
    partial class formBalancoEstoque
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
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.colEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldoDisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldoReservado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldoTroca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldoTransf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.SuspendLayout();
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
            this.colEmpresa,
            this.colEstMinimo,
            this.colEstMax,
            this.colSaldoDisp,
            this.colSaldoReservado,
            this.colSaldoTroca,
            this.colSaldoTransf,
            this.colSaldoTotal});
            this.dgvEstoque.Location = new System.Drawing.Point(12, 65);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.RowHeadersVisible = false;
            this.dgvEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstoque.Size = new System.Drawing.Size(833, 382);
            this.dgvEstoque.TabIndex = 28;
            // 
            // colEmpresa
            // 
            this.colEmpresa.HeaderText = "Empresa";
            this.colEmpresa.Name = "colEmpresa";
            this.colEmpresa.ReadOnly = true;
            // 
            // colEstMinimo
            // 
            this.colEstMinimo.HeaderText = "Estoque Mínimo";
            this.colEstMinimo.Name = "colEstMinimo";
            this.colEstMinimo.ReadOnly = true;
            // 
            // colEstMax
            // 
            this.colEstMax.HeaderText = "Estoque Máximo";
            this.colEstMax.Name = "colEstMax";
            this.colEstMax.ReadOnly = true;
            // 
            // colSaldoDisp
            // 
            this.colSaldoDisp.HeaderText = "Saldo Disponível";
            this.colSaldoDisp.Name = "colSaldoDisp";
            this.colSaldoDisp.ReadOnly = true;
            // 
            // colSaldoReservado
            // 
            this.colSaldoReservado.HeaderText = "Saldo Reservado";
            this.colSaldoReservado.Name = "colSaldoReservado";
            this.colSaldoReservado.ReadOnly = true;
            // 
            // colSaldoTroca
            // 
            this.colSaldoTroca.HeaderText = "Saldo Troca";
            this.colSaldoTroca.Name = "colSaldoTroca";
            this.colSaldoTroca.ReadOnly = true;
            // 
            // colSaldoTransf
            // 
            this.colSaldoTransf.HeaderText = "Saldo em Transferência";
            this.colSaldoTransf.Name = "colSaldoTransf";
            this.colSaldoTransf.ReadOnly = true;
            // 
            // colSaldoTotal
            // 
            this.colSaldoTotal.HeaderText = "Saldo Total";
            this.colSaldoTotal.Name = "colSaldoTotal";
            this.colSaldoTotal.ReadOnly = true;
            // 
            // formBalancoEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 459);
            this.Controls.Add(this.dgvEstoque);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "formBalancoEstoque";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEstoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldoDisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldoReservado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldoTroca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldoTransf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldoTotal;
    }
}