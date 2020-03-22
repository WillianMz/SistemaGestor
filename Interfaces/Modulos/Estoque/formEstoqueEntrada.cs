using Controller;
using Interfaces.Modulo.Estoque;
using Interfaces.Modulos.Base;
using Interfaces.Utilitario;
using Modelo;
using Modelo.Estoque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace Interfaces.Modulos.Estoque
{
    public partial class formEstoqueEntrada : Form
    {
        public statusForm statusForm;
        DateTime dataAtual = DateTime.Now;
        BLL_Sistema sistema;
        BLL_Pessoa pessoas;

        Produto_Item item;
        List<Produto_Item> itens;
        int contador = 0;

        public formEstoqueEntrada()
        {
            InitializeComponent();
            carregarCombobox();
        }

        public void configForm()
        {
            if(statusForm == statusForm.Novo)
            {

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
        }

        private void bloquearCampos()
        {
            util_sistema.bloquearComponentesTabPage(tabPrincipal,  false);
            util_sistema.bloquearComponentesTabPage(tabProdutos,   false);
            util_sistema.bloquearComponentesTabPage(tabFatura,     false);
            util_sistema.bloquearComponentesTabPage(tabTransporte, false);
        }

        private void ativarCampos()
        {
            util_sistema.bloquearComponentesTabPage(tabPrincipal,  true);
            util_sistema.bloquearComponentesTabPage(tabProdutos,   true);
            util_sistema.bloquearComponentesTabPage(tabFatura,     true);
            util_sistema.bloquearComponentesTabPage(tabTransporte, true);
        }

        private void limparCampos()
        {
            util_sistema.limparComponentesTabPage(tabPrincipal);
            util_sistema.limparComponentesTabPage(tabProdutos);
            util_sistema.limparComponentesTabPage(tabFatura);
            util_sistema.limparComponentesTabPage(tabTransporte);
        }

        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                formConsultaPessoa form = new formConsultaPessoa();
                form.tpConsultaPessoa = consultaPessoaPorTipo.Fornecedor;
                form.Text = "Consulta Fornecedores";
                form.ShowDialog();
                form.Dispose();
            }
            catch(Exception)
            {

            }
        }

        private void adicionarProduto(Produto p)
        {
            try
            {
                txtProdutoCod.Text = Convert.ToString(p.Id);
                txtProdutoCodbarras.Text = p.Codigo;
                txtProdutoDescricao.Text = p.Nome;
                cboxProdutoUN.SelectedValue = p.UnidCompra.Id;
                txtProdutoQtdEmb.Text = Convert.ToString(p.QtdEmb);

            }
            catch(Exception )
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
                    item.unid.Nome = cboxProdutoUN.Text;//teste
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
                    dgvProdutosItens.Rows.Add(contador.ToString(), item.produto.Id, item.produto.Codigo, item.produto.Nome, item.cst.Id, item.cfop.Id, item.unid.Nome, 
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
                Produto pro = new Produto();
                form.ShowDialog();
                pro = form.retornaProduto();
                adicionarProduto(pro);
                form.Dispose();
                
                //BLL_Produto controle = new BLL_Produto();
                //int id = int.Parse(dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells[0].Value.ToString());
                //Produto p = controle.detalhesDoProduto(id);
                //formProduto form = new formProduto();
                //form.statusForm = statusForm.Detalhes;
                //form.configForm();
                //form.detalhes(p);
                //form.ShowDialog();
                //form.Dispose();
               
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

                        sistema = new BLL_Sistema();
                        string cnpj = mtxtCNPJEmpresa.Text;
                        Empresa emp = sistema.filtrarEmpresa_CNPJ(cnpj, true);

                        if (emp == null)
                        {
                            MessageBox.Show("CNPJ da empresa não encontrado. Verifique!", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            lblNomeEmpresa.Text = emp.razaoSocial + " | " + emp.local;
                            lblMsgEmpresa.Text = emp.fantasia;
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
                        MessageBox.Show("Fornecedor não cadastrado!", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        lblMsgFornec.Text = p.Fantasia;
                        txtNomeFornecedor.Text = p.NomeCompleto + " | " + p.Local;
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
            adicionarItem();//teste
        }

    }
}
