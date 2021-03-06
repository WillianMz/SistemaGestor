﻿using Modelo.Estoque;
using Sistema.Estoque.Controles;
using Sistema.Estoque.Utilitario;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Util;

namespace Sistema.Estoque.Interfaces
{
    public partial class formProduto : Form
    {
        public statusForm statusForm;
        DateTime dataAtual = DateTime.Now;
        BLL_Produto controler;
        Categoria c;
        Grupo g;
        Subgrupo s;
        int idCateg;
        int idGrupo;
        int idSubg;

        public formProduto()
        {
            InitializeComponent();
            carregarCbox();
            configForm();
        }

        #region ROTINAS

        public void configForm()
        {
            if (statusForm == statusForm.Novo)
            {
                lblMensagem.Text = "Novo registro";
                lblTitulo.Text   = "NOVO PRODUTO";
                btnSalvar.Visible = true;
                btnCancelar.Text = "Cancelar";
                btnNovo.Visible = false;
            }

            if (statusForm == statusForm.Editar)
            {
                lblMensagem.Text = "Alterando dados do produto";
                txtNome.Focus();
                txtCodbarras.Enabled = false;
                btnNovo.Visible = false;
            }

            if (statusForm == statusForm.Detalhes)
            {
                bloquearCampos();
                lblMensagem.Text = "Visualizando dados do produto";                
                btnSalvar.Visible = false;
                btnCancelar.Text = "Voltar";
                btnNovo.Visible = true;
            }            
        }

        private void carregarCbox()
        {
            carregarComboBox.tipoProduto(cbTpProduto);
            carregarComboBox.unidade(cbUnidade);
            carregarComboBox.unidade(cbUnCompra);
           // carregarComboBox.categoriaProduto(cbCategoria);
        }

        private void bloquearCampos()
        {
            util_sistema.bloquearComponentesTabPage(tabPrincipal,  false);
            util_sistema.bloquearComponentesTabPage(tabValores,    false);
            util_sistema.bloquearComponentesTabPage(tabTributacao, false);
            util_sistema.bloquearComponentesTabPage(tabCodigos,    false);
        }

        private void ativarCampos()
        {            
            util_sistema.bloquearComponentesTabPage(tabPrincipal,  true);
            util_sistema.bloquearComponentesTabPage(tabValores,    true);
            util_sistema.bloquearComponentesTabPage(tabTributacao, true);
            util_sistema.bloquearComponentesTabPage(tabCodigos,    true);

            txtID.Enabled = false;//sempre manter este campo bloqueado
        }

        private void limparCampos()
        {
            util_sistema.limparComponentesTabPage(tabPrincipal);
            util_sistema.limparComponentesTabPage(tabValores);
        }

        private void adicionar()
        {
            controler = new BLL_Produto();

            if (controler.codbarrasCadastrado(txtCodbarras.Text.Trim()) == true)
            {
                MessageBox.Show(util_msg.msgCodProdutoCadastrado, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodbarras.Focus();
                return;
            }

            try
            {
                Produto p = new Produto();
                p.Ativo           = true; //default padrão
                p.TipoProduto.Id  = int.Parse(cbTpProduto.SelectedValue.ToString());
                p.Codigo          = txtCodbarras.Text.Trim();
                p.Nome            = txtNome.Text.Trim();
                p.Descricao       = txtDescricao.Text.Trim();
                p.Unidade.Id      = int.Parse(cbUnidade.SelectedValue.ToString());
                p.Marca           = txtMarca.Text.Trim();
                p.Fabricante      = txtFabricante.Text.Trim();
                p.Categoria.Id = idCateg;//int.Parse(cbCategoria.SelectedValue.ToString());
                p.Grupo.Id = idGrupo; //int.Parse(cbGrupo.SelectedValue.ToString());
                p.Subgrupo.Id = idSubg; //int.Parse(cbSubgrupo.SelectedValue.ToString());
                p.Custo           = double.Parse(txtCusto.Text);
                p.VendaComissao   = double.Parse(txtComissao.Text);
                p.VendaPorcCom    = double.Parse(txtPorcComissao.Text);
                p.VendaDesconto   = double.Parse(txtDesconto.Text);
                p.VendaPorcDesc   = double.Parse(txtPorcDesconto.Text);
                p.VendaOutros     = double.Parse(txtOutros.Text);
                p.VendaPorcOutros = double.Parse(txtPorcOutros.Text);
                p.VendaMargem     = double.Parse(txtMargem.Text);
                p.VendaLucro      = double.Parse(txtLucro.Text);
                p.PrecoVenda      = double.Parse(txtVenda.Text);
                p.QtdMinina       = double.Parse(txtQtdMinima.Text);
                p.QtdMaxima       = double.Parse(txtQtdMaxima.Text);
                p.UnidCompra.Id   = int.Parse(cbUnCompra.SelectedValue.ToString());
                p.QtdEmb          = double.Parse(txtQtdEmb.Text);
                p.PesoBruto       = double.Parse(txtPesoBruto.Text);
                p.PesoLiquido     = double.Parse(txtPesoLiquido.Text);
                p.Altura          = double.Parse(txtAltura.Text);
                p.Largura         = double.Parse(txtLargura.Text);
                p.Comprimento     = double.Parse(txtComprimento.Text);
                p.Localizacao     = txtLocalizacao.Text;
                p.DtCadastro      = dataAtual;
                p.DtAlteracao     = dataAtual;

                if (chBoxBalanca.Checked == true)
                    p.Balanca = true;
                else
                    p.Balanca = false;

                if (pbImagem.ImageLocation != null)
                {   //nome do diretorio a ser criado
                    string pasta = util_sistema.caminhoImagensProdutos;

                    if (!Directory.Exists(pasta))
                        Directory.CreateDirectory(pasta);
                    //salvar imagem
                    pbImagem.Image.Save(pasta + p.Nome + ".jpg", ImageFormat.Jpeg);
                    p.Imagem = pasta + p.Nome + ".jpg";
                }
                else
                    p.Imagem = "NC";//NC = NAO CONTEM
                
                controler.novoProduto(p);
                MessageBox.Show(util_msg.msgSalvar, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);   
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void alterar()
        {
            controler = new BLL_Produto();

            try
            {
                Produto p = new Produto();
                p.Id              = int.Parse(txtID.Text);
                p.TipoProduto.Id  = int.Parse(cbTpProduto.SelectedValue.ToString());
                p.Codigo          = txtCodbarras.Text.Trim();
                p.Nome            = txtNome.Text.Trim();
                p.Descricao       = txtDescricao.Text.Trim();
                p.Unidade.Id      = int.Parse(cbUnidade.SelectedValue.ToString());
                p.Marca           = txtMarca.Text.Trim();
                p.Fabricante      = txtFabricante.Text.Trim();
                p.Categoria.Id = idCateg;//int.Parse(cbCategoria.SelectedValue.ToString());
                p.Grupo.Id = idGrupo; //int.Parse(cbGrupo.SelectedValue.ToString());
                p.Subgrupo.Id = idSubg; //int.Parse(cbSubgrupo.SelectedValue.ToString());
                p.Custo           = double.Parse(txtCusto.Text);
                p.VendaComissao   = double.Parse(txtComissao.Text);
                p.VendaPorcCom    = double.Parse(txtPorcComissao.Text);
                p.VendaDesconto   = double.Parse(txtDesconto.Text);
                p.VendaPorcDesc   = double.Parse(txtPorcDesconto.Text);
                p.VendaOutros     = double.Parse(txtOutros.Text);
                p.VendaPorcOutros = double.Parse(txtPorcOutros.Text);
                p.VendaMargem     = double.Parse(txtMargem.Text);
                p.VendaLucro      = double.Parse(txtLucro.Text);
                p.PrecoVenda      = double.Parse(txtVenda.Text);
                p.QtdMinina       = double.Parse(txtQtdMinima.Text);
                p.QtdMaxima       = double.Parse(txtQtdMaxima.Text);
                p.UnidCompra.Id   = int.Parse(cbUnCompra.SelectedValue.ToString());
                p.QtdEmb          = double.Parse(txtQtdEmb.Text);
                p.PesoBruto       = double.Parse(txtPesoBruto.Text);
                p.PesoLiquido     = double.Parse(txtPesoLiquido.Text);
                p.Altura          = double.Parse(txtAltura.Text);
                p.Largura         = double.Parse(txtLargura.Text);
                p.Comprimento     = double.Parse(txtComprimento.Text);
                p.Localizacao     = txtLocalizacao.Text;
                p.DtAlteracao     = dataAtual;

                if (pbImagem.ImageLocation != null)
                {   //nome do diretorio a ser criado
                    string pasta = util_sistema.caminhoImagensProdutos;

                    if (!Directory.Exists(pasta))
                        Directory.CreateDirectory(pasta);
                    //salvar imagem
                    pbImagem.Image.Save(pasta + p.Nome + ".jpg", ImageFormat.Jpeg);
                    p.Imagem = pasta + p.Nome + ".jpg";
                }
                else
                    p.Imagem = "NC";

                if (chBoxAtivo.Checked == true)
                    p.Ativo = true;
                else
                    p.Ativo = false;

                if (chBoxBalanca.Checked == true)
                    p.Balanca = true;
                else
                    p.Balanca = false;
               
                controler.editarProduto(p);
                MessageBox.Show(util_msg.msgSalvar, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //preenche os campos do form com dados do objeto Produto
        public void detalhes(Produto p)
        {
            try
            {
                lblTitulo.Text              = p.Nome;
                txtID.Text                  = Convert.ToString(p.Id);
                chBoxAtivo.Checked          = p.Ativo;
                cbTpProduto.SelectedValue = p.TipoProduto.Id;
                txtCodbarras.Text           = p.Codigo;
                txtNome.Text                = p.Nome;
                txtDescricao.Text           = p.Descricao;
                cbUnidade.SelectedValue   = p.Unidade.Id;
                chBoxBalanca.Checked        = p.Balanca;
                txtMarca.Text               = p.Marca;
                txtFabricante.Text          = p.Fabricante;
                txtCategoria.Text           = p.Categoria.Id + " - " + p.Categoria.nome;
                txtGrupo.Text               = p.Grupo.Id + " - " + p.Grupo.nome;
                txtSubgrupo.Text            = p.Subgrupo.Id + " - " + p.Subgrupo.nome;
                //cbCategoria.SelectedValue = p.Categoria.Id;
                //cbGrupo.SelectedValue     = p.Grupo.Id;
                //cbSubgrupo.SelectedValue  = p.Subgrupo.Id;               
                txtQtdMinima.Text           = Convert.ToString(p.QtdMinina);
                txtQtdMaxima.Text           = Convert.ToString(p.QtdMaxima);
                cbUnCompra.SelectedValue  = p.UnidCompra.Id;
                txtQtdEmb.Text              = Convert.ToString(p.QtdEmb);
                txtPesoBruto.Text           = Convert.ToString(p.PesoBruto);
                txtPesoLiquido.Text         = Convert.ToString(p.PesoLiquido);
                txtAltura.Text              = Convert.ToString(p.Altura);
                txtLargura.Text             = Convert.ToString(p.Largura);
                txtComprimento.Text         = Convert.ToString(p.Comprimento);
                txtLocalizacao.Text         = p.Localizacao;
                mtxtCadastro.Text           = Convert.ToString(p.DtCadastro);
                mtxtAlteracao.Text          = Convert.ToString(p.DtAlteracao);
                pbImagem.ImageLocation      = p.Imagem;
                txtCusto.Text               = Convert.ToString(p.Custo);
                txtComissao.Text            = Convert.ToString(p.VendaComissao);
                txtPorcComissao.Text        = Convert.ToString(p.VendaPorcCom);
                txtDesconto.Text            = Convert.ToString(p.VendaDesconto);
                txtPorcDesconto.Text        = Convert.ToString(p.VendaPorcDesc);
                txtOutros.Text              = Convert.ToString(p.VendaOutros);
                txtPorcOutros.Text          = Convert.ToString(p.VendaPorcOutros);
                txtMargem.Text              = Convert.ToString(p.VendaMargem);
                txtLucro.Text               = Convert.ToString(p.VendaLucro);
                txtVenda.Text               = Convert.ToString(p.PrecoVenda);               
            }
            catch (Exception ex)
            {
                MessageBox.Show(util_msg.msgErro + ex.Message, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvar()
        {
            #region VERIFICAR CAMPOS PREENCHIDOS
            if (cbTpProduto.Text == "")
            {
                MessageBox.Show("Selecione o tipo de produto!", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbTpProduto.Focus();
                return;
            }

            if (txtCodbarras.Text == "")
            {
                txtCodbarras.BackColor = Color.Yellow;
                MessageBox.Show("Informe o código do produto!", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodbarras.Focus();
                return;
            }

            if (txtNome.Text == "")
            {
                txtNome.BackColor = Color.Yellow;
                MessageBox.Show("Informe o nome do produto!", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

            if (cbUnidade.Text == "")
            {
                cbUnidade.BackColor = Color.Yellow;
                MessageBox.Show("Selecione o tipo de unidade!", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbUnidade.Focus();
                return;
            }

            if (txtDescricao.Text == "")
            {
                txtDescricao.Text = "NC";
            }

            if (txtMarca.Text == "")
                txtMarca.Text = "NC";

            if (txtFabricante.Text == "")
                txtFabricante.Text = "NC";

            //if (cbCategoria.Text == "")
            //{
            //    MessageBox.Show("Selecione uma categoria!", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    cbCategoria.Focus();
            //    return;
            //}

            //if (cbGrupo.Text == "")
            //{
            //    MessageBox.Show("Selecione um grupo!", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    cbGrupo.Focus();
            //    return;
            //}

            //if (cbSubgrupo.Text == "")
            //{
            //    MessageBox.Show("Selecione um subgrupo!", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    cbSubgrupo.Focus();
            //    return;
            //}

            if (txtLocalizacao.Text == "")
                txtLocalizacao.Text = "NC";

            if (txtQtdMinima.Text == "")
                txtQtdMinima.Text = "0";

            if (txtQtdMaxima.Text == "")
                txtQtdMaxima.Text = "0";

            if (cbUnCompra.Text == "")
            {
                MessageBox.Show("Selecione a unidade de compra!", util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbUnCompra.Focus();
                return;
            }

            if (txtQtdEmb.Text == "")
                txtQtdEmb.Text = "1";

            if (txtAltura.Text == "")
                txtAltura.Text = "0";

            if (txtLargura.Text == "")
                txtLargura.Text = "0";

            if (txtComprimento.Text == "")
                txtComprimento.Text = "0";

            if (txtPesoBruto.Text == "")
                txtPesoBruto.Text = "0";

            if (txtPesoLiquido.Text == "")
                txtPesoLiquido.Text = "0";        

            #endregion

            if (statusForm == statusForm.Novo)
                adicionar();
            else if (statusForm == statusForm.Editar)
                alterar();

            statusForm = statusForm.Detalhes;
            configForm();
        }

        #endregion

        #region COMBOBOX

        //private void cboxCategoria_SelectedValueChanged(object sender, EventArgs e)
        //{            
        //    carregarComboBox.grupoProduto(cbGrupo, cbCategoria);
        //}

        //private void cboxGrupo_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    carregarComboBox.subgrupoProduto(cbSubgrupo, cbGrupo);
        //}

        #endregion


        #region TEXTBOX

        private void txtCodbarras_Leave(object sender, EventArgs e)
        {
           // ProdutoCadastrado();
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if(txtNome.Text != "")
                lblTitulo.Text = txtNome.Text;
        }

        private void txtCusto_Leave(object sender, EventArgs e)
        {
            if (txtCusto.Text.Trim() == string.Empty)
                txtCusto.Text = "0";

            txtCusto.Text = util_dados.configurarNumeroDecimal(txtCusto.Text, 2);
            //mudar
            txtLucro.Text = "0";
        }

        private void txtMargem_Leave(object sender, EventArgs e)
        {
            if (txtMargem.Text.Trim() == string.Empty)
                txtMargem.Text = "0";

            if (Convert.ToDouble(txtMargem.Text) < 0 || Convert.ToDouble(txtMargem.Text) > 99)
            {
                MessageBox.Show("Valor Inválido!\n0% ~ 99%");
                txtMargem.Text = "0";
            }

            txtMargem.Text = util_dados.configurarNumeroDecimal(txtMargem.Text, 2);

            double margem = Convert.ToDouble(txtMargem.Text);

            double custoFinal = util_dados.verificaDouble(txtCusto.Text);
            custoFinal += util_dados.verificaDouble(txtOutros.Text);

            txtVenda.Text = util_dados.configurarNumeroDecimal(util_matematica.calculaValor(custoFinal, margem), 2);

            
        }

        private void txtVenda_Leave(object sender, EventArgs e)
        {
            if (txtVenda.Text.Trim() == string.Empty)
                txtVenda.Text = "0";

            txtVenda.Text = util_dados.configurarNumeroDecimal(txtVenda.Text, 2);
        }

        private void txtComissao_Leave(object sender, EventArgs e)
        {
            if (txtComissao.Text.Trim() == string.Empty)
                txtComissao.Text = "0";

            txtComissao.Text = util_dados.configurarNumeroDecimal(txtComissao.Text, 2);
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            if (txtDesconto.Text.Trim() == string.Empty)
                txtDesconto.Text = "0";

            txtDesconto.Text = util_dados.configurarNumeroDecimal(txtDesconto.Text, 2);
        }

        private void txtOutros_Leave(object sender, EventArgs e)
        {
            if (txtOutros.Text.Trim() == string.Empty)
                txtOutros.Text = "0";

            txtOutros.Text = util_dados.configurarNumeroDecimal(txtOutros.Text, 2);
        }

        private void txtPorcComissao_Leave(object sender, EventArgs e)
        {
            if (txtPorcComissao.Text.Trim() == string.Empty)
                txtPorcComissao.Text = "0";

            txtPorcComissao.Text = util_dados.configurarNumeroDecimal(txtPorcComissao.Text, 2);
        }

        private void txtPorcDesconto_Leave(object sender, EventArgs e)
        {
            if (txtPorcDesconto.Text.Trim() == string.Empty)
                txtPorcDesconto.Text = "0";

            txtPorcDesconto.Text = util_dados.configurarNumeroDecimal(txtPorcDesconto.Text, 2);
        }

        private void txtPorcOutros_Leave(object sender, EventArgs e)
        {
            if (txtPorcOutros.Text.Trim() == string.Empty)
                txtPorcOutros.Text = "0";

            txtPorcOutros.Text = util_dados.configurarNumeroDecimal(txtPorcOutros.Text, 2);
        }

        #endregion

        #region BOTOES

        private void btnCateg_Click(object sender, EventArgs e)
        {
            //formProdutoCategoria fCateg = new formProdutoCategoria();
            //fCateg.statusForm = statusForm.Novo;
            //fCateg.configForm();
            //fCateg.ShowDialog();
            //carregarComboBox.categoriaProduto(cbCategoria);
            //fCateg.Close();
            //fCateg.Dispose();
        }

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            //idCateg = Convert.ToInt32(cbCategoria.SelectedValue);
            //formProdutoGrupo fGrupo = new formProdutoGrupo();
            //fGrupo.statusForm = statusForm.Novo;
            //fGrupo.configForm(idCateg);
            //fGrupo.ShowDialog();
            //fGrupo.Close();
            //carregarComboBox.grupoProduto(cbCategoria, cbGrupo);
            //fGrupo.Dispose();
        }

        private void btnSubgrupo_Click(object sender, EventArgs e)
        {
            //idGrupo = Convert.ToInt32(cbGrupo.SelectedValue);
            //formProdutoSubgrupo fSub = new formProdutoSubgrupo();
            //fSub.statusForm = statusForm.Novo;
            //fSub.configForm(idGrupo);
            //fSub.ShowDialog();
            //fSub.Close();
            //carregarComboBox.subgrupoProduto(cbSubgrupo, cbGrupo);
            //fSub.Dispose();
        }

        private void btnAdicionarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagem = new OpenFileDialog();
            imagem.Filter = "jpg|*.jpg";

            if (imagem.ShowDialog() == DialogResult.OK)
            {
                FileInfo arq = new FileInfo(imagem.FileName);

                //testa se tem menos de 1MB (1MB em bytes = 1048576)
                if (arq.Length <= 1048576)
                    pbImagem.ImageLocation = imagem.FileName;
                else
                    MessageBox.Show("O tamanho da imagem não pode exceder 1MB!", "Tamanho inválido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparCampos();
            ativarCampos();
            statusForm = statusForm.Novo;
            configForm();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if ((statusForm == statusForm.Novo) || (statusForm == statusForm.Editar))
            {
                DialogResult result = MessageBox.Show("Cancelar alterações?", util_msg.sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    this.Close();
                else
                    return;
            }
            else if (statusForm == statusForm.Detalhes)
                Close();
        }


        #endregion

        private void btnClassifProdutos_Click(object sender, EventArgs e)
        {
            formClassifProdutos fClass = new formClassifProdutos();
            fClass.status = statusForm.Selecionar;
            fClass.configForm();

            c = new Categoria();
            g = new Grupo();
            s = new Subgrupo();

            fClass.ShowDialog();
            //tem que mudar isso aqui -> ainda nao sei fazer de outro jeito
            c = fClass.selecionarCategoria();
            g = fClass.selecionarGrupo();
            s = fClass.selecionarSubgrupo();

            classificacao(c, g, s);

            fClass.Close();
            fClass.Dispose();
        }


        private void classificacao(Categoria c, Grupo g, Subgrupo s)
        {
            idCateg = c.Id;
            idGrupo = g.Id;
            idSubg  = s.Id;
            txtCategoria.Text = c.Id + " - " + c.nome;
            txtGrupo.Text     = g.Id + " - " + g.nome;
            txtSubgrupo.Text  = s.Id + " - " + s.nome;
        }

    }
}
