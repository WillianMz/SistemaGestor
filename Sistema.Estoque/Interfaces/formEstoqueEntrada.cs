using Modelo;
using Modelo.Estoque;
using Sistema.Estoque.Utilitario;
using Sistema.Pessoas.Controles;
using Sistema.Pessoas.Interfaces;
using Sistema.Utilitario.Controles;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Util;

namespace Sistema.Estoque.Interfaces
{
    public partial class formEstoqueEntrada : Form
    {
        public statusForm statusForm;
        public tipoNota tpNota;
        DateTime dataAtual = DateTime.Now;
        BLL_Empresa empresa;
        BLL_Pessoa pessoas;

        Produto_Item item;
        List<Produto_Item> itens;
        int contador = 0;

        public formEstoqueEntrada()
        {
            InitializeComponent();
           // carregarCombobox();
        }

        public void configForm()
        {
            if(statusForm == statusForm.Novo)
            {
               // lblTitulo.Text   = "NOVA ENTRADA NO ESTOQUE";
                lblMensagem.Text = "Novo registro";
                carregarCombobox();
                lblNomeEmpresa.Visible = true;
                lblNomeEmpresa.Text    = "";
                lblNomeFornec.Text     = "";
                lblNomeFornec.Visible  = true;
            }

            if(statusForm == statusForm.Editar)
            {

            }

            if (statusForm == statusForm.Detalhes)
            {

            }
        }

        private void carregarCombobox()
        {
            carregarComboBox.unidade(cboxProdutoUN);
            carregarComboBox.tipoNotaFiscal(cbTipoNota);
        }

        private void bloquearCampos()
        {
            util_sistema.bloquearComponentesTabPage(tabPrincipal,  false);
            //util_sistema.bloquearComponentesTabPage(tabProdutos,   false);
        }

        private void ativarCampos()
        {
            util_sistema.bloquearComponentesTabPage(tabPrincipal,  true);
        }

        private void limparCampos()
        {
            util_sistema.limparComponentesTabPage(tabPrincipal);
           // util_sistema.limparComponentesTabPage(tabProdutos);
        }

        private void cadastrarFornedor()
        {
            try
            {
                formPessoa cadFornec = new formPessoa();
                cadFornec.statusForm = statusForm.Novo;
                cadFornec.configForm();
                cadFornec.Text = "Novo fornecedor";
                cadFornec.ShowDialog();
                cadFornec.Dispose();
            }
            catch (Exception)
            {

            }
        }

        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            cadastrarFornedor();
        }

        private void adicionarProduto(Produto p)
        {
            try
            {
                txtProdutoCod.Text          = Convert.ToString(p.Id);
                txtProdutoCodbarras.Text    = p.Codigo;
                txtProdutoDescricao.Text    = p.Nome;
                cboxProdutoUN.SelectedValue = p.UnidCompra.Id;
                txtProdutoQtdEmb.Text       = Convert.ToString(p.QtdEmb);

            }
            catch(Exception)
            {
            }
        }

        private void adicionarItem()
        {
            try
            {
                itens = new List<Produto_Item>();;

                if(itens.Count > 0)
                {

                }
                else
                {
                    item = new Produto_Item();
                    //teste
                    item.produto.Id     = Convert.ToInt32(txtProdutoCod.Text);
                    item.produto.Codigo = txtProdutoCodbarras.Text;
                    item.produto.Nome = txtProdutoDescricao.Text;
                    item.unid.nome = cboxProdutoUN.Text;//teste
                    item.cst.Id         = Convert.ToInt32(txtProdutoCST.Text);
                    item.cfop.Id        = Convert.ToInt32(txtProdutoCFOP.Text);
                    item.qtd            = double.Parse(txtProdutoQTD.Text);
                    item.vlUnit         = double.Parse(txtProdutoValorUN.Text);
                    item.vlDesc         = double.Parse(txtProdutoDesconto.Text);
                    item.vlTotal        = double.Parse(txtProdutoValorTotal.Text);
                    item.bcICMS         = double.Parse(txtProdutoBC_ICMS.Text);
                    item.vlICMS         = double.Parse(txtProdutoVL_ICMS.Text);
                    item.vlIPI          = double.Parse(txtProdutoVL_IPI.Text);
                    item.alqICMS        = double.Parse(txtProdutoAlqICMS.Text);
                    item.alqIPI         = double.Parse(txtProdutoAlqIPI.Text);

                    itens.Add(item);
                }

                //teste();
                atualizarGrid(itens);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void atualizarGrid(List<Produto_Item> lst)
        {
            try
            {
                // dgvProdutosItens.Rows.Clear();            

                foreach (Produto_Item item in lst)
                {
                    contador++;
                    dgvProdutosItens.Rows.Add(contador.ToString(), item.produto.Id, item.produto.Codigo, item.produto.Nome, item.cst.Id, item.cfop.Id, item.unid.nome, 
                                               item.qtd, item.vlUnit, item.vlTotal, item.vlDesc, item.bcICMS, item.vlICMS, item.vlIPI, item.alqICMS, item.alqIPI);
                }
            }
            catch
            {
                //fazer tratamento de excessão
            }

        }

        private void btnProduto_Click(object sender, EventArgs e)
        {            
            try
            {
                formConsultaProduto form = new formConsultaProduto();
                form.statusForm = statusForm.Selecionar;
                form.configForm();
                Produto pro = new Produto();
                form.ShowDialog();
                pro = form.selecionarProduto();
                adicionarProduto(pro);               
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void mtxtCNPJEmpresa_KeyDown(object sender, KeyEventArgs e)
        {            
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (mtxtCNPJEmpresa.MaskCompleted)
                    {
                        util_sistema.removerMascara(mtxtCNPJEmpresa);

                        empresa = new BLL_Empresa();
                        string cnpj = mtxtCNPJEmpresa.Text;
                        Empresa emp = empresa.filtrarEmpresa_CNPJ(cnpj, true);

                        if (emp == null)
                        {
                            MessageBox.Show("CNPJ da empresa não encontrado. Verifique!", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            lblNomeEmpresa.Text = emp.razaoSocial + " | " + emp.local;
                          //  lblMsgEmpresa.Text = emp.fantasia;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_cnpjFornec_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter )                    
                {
                    pessoas = new BLL_Pessoa();
                    string cpfCNPJ = txt_cnpjFornec.Text;
                    Pessoa p = pessoas.filtroPessoaCPFcnpj(cpfCNPJ, true);

                    if (p == null)
                    {
                        DialogResult result = MessageBox.Show("Forncedor não cadastrado. Deseja cadastar?", util_msg.sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            cadastrarFornedor();
                        }
                        else
                            return;
                    }
                    else
                    {
                       // lblMsgFornec.Text = p.Fantasia;
                        lblNomeFornec.Text = p.nomeCompleto + " | " + p.local;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_cnpjFornec_Leave(object sender, EventArgs e)
        {
            if (txt_cnpjFornec.TextLength == 14)
                txt_cnpjFornec.Text = util_dados.formataCNPJ(txt_cnpjFornec.Text);

            if (txt_cnpjFornec.TextLength == 11)
                txt_cnpjFornec.Text = util_dados.formataCPF(txt_cnpjFornec.Text);
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            #region VERIFICAÇÕES
            if (txtProdutoCod.Text == string.Empty)
            {
                MessageBox.Show("Código do produto não informado!", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtProdutoCod.Focus();
                return;
            }

            if (txtProdutoCodbarras.Text == string.Empty)
            {
                MessageBox.Show("GTIN do produto não informado!", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtProdutoCodbarras.Focus();
                return;
            }

            if (txtProdutoCST.Text == string.Empty)
            {
                MessageBox.Show("CST não informado!", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtProdutoCST.Focus();
                return;
            }

            if (txtProdutoCFOP.Text == string.Empty)
            {
                MessageBox.Show("CFOP não informado!", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtProdutoCFOP.Focus();
                return;
            }

            if (txtProdutoQTD.Text == string.Empty)
            {
                MessageBox.Show("Quantidade de entrada não informado!", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtProdutoQTD.Focus();
                return;
            }

            if (txtProdutoValorUN.Text == string.Empty)
            {
                MessageBox.Show("Valor Unitário não informado!", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtProdutoValorUN.Focus();
                return;
            }

            if (txtProdutoDesconto.Text == string.Empty)
            {
                txtProdutoDesconto.Text = "0";
            }

            if (txtProdutoValorTotal.Text == string.Empty)
            {
                MessageBox.Show("Valor Total não informado!", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtProdutoValorTotal.Focus();
                return;
            }

            if (txtProdutoBC_ICMS.Text == string.Empty)
            {
                MessageBox.Show("Base de Cálculo do ICMS não informado! \nCaso não tenha informe 0 (Zero)", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtProdutoBC_ICMS.Focus();
                return;
            }

            if (txtProdutoVL_ICMS.Text == string.Empty)
            {
                MessageBox.Show("Valor do ICMS não informado! \nCaso não tenha informe 0 (Zero)", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtProdutoVL_ICMS.Focus();
                return;
            }

            if (txtProdutoVL_IPI.Text == string.Empty)
            {
                MessageBox.Show("Valor do IPI não informado! \nCaso não tenha informe 0 (Zero)", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtProdutoVL_IPI.Focus();
                return;
            }

            if (txtProdutoAlqICMS.Text == string.Empty)
            {
                MessageBox.Show("Aliquota ICMS não informado! \nCaso não tenha informe 0 (Zero)", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtProdutoAlqICMS.Focus();
                return;
            }

            if (txtProdutoAlqIPI.Text == string.Empty)
            {
                MessageBox.Show("Aliquota IPI não informado! \nCaso não tenha informe 0 (Zero)", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtProdutoAlqIPI.Focus();
                return;
            }

            #endregion

            adicionarItem();
        }

        private void btnEditarCadProduto_Click(object sender, EventArgs e)
        {
            formEntradaAdicionarProduto f = new formEntradaAdicionarProduto();
            f.ShowDialog();
            f.Close();
            f.Dispose();
        }
    }
}
