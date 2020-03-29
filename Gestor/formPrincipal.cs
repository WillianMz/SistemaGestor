using Sistema.Estoque.Interfaces;
using Sistema.Pessoas.Interfaces;
using Sistema.Utilitario.Interfaces;
using Sistema.Financeiro.Interfaces;
using System;
using System.Windows.Forms;
using Util;

namespace Gestor
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void TratarExcecao(Exception ex)
        {
            MessageBox.Show(util_msg.msgErro + ex, util_msg.sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void mArq_config_Click(object sender, EventArgs e)
        {
            try
            {
                formConfigurar form = new formConfigurar();
                form.ShowDialog();
                form.Dispose();
            }
            catch
            {

            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mEstoqueProdNovo_Click(object sender, EventArgs e)
        {
            formProduto form = new formProduto();
            form.statusForm = statusForm.Novo;
            form.configForm();
            form.ShowDialog();
            form.Dispose();
        }

        private void mEstoqueProdConsulta_Click(object sender, EventArgs e)
        {
            formConsultaProduto form = new formConsultaProduto();
            form.ShowDialog();
            form.Dispose();
        }

        private void mEstoqueProdCateg_Click(object sender, EventArgs e)
        {
            formConsultaCategoria form = new formConsultaCategoria();
            form.ShowDialog();
            form.Dispose();
        }

        private void mEstoqueProdGrupo_Click(object sender, EventArgs e)
        {
            formConsultaGrupo form = new formConsultaGrupo();
            form.ShowDialog();
            form.Dispose();
        }

        private void mEstoqueProdSubgrupo_Click(object sender, EventArgs e)
        {
            formConsultaSubgrupo form = new formConsultaSubgrupo();
            form.ShowDialog();
            form.Dispose();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLogin form = new formLogin();
            form.ShowInTaskbar = false;            
            form.ShowDialog();
            //this.Dispose();
            form.Dispose();
        }

        private void mArq_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mEstoqueFornec_Click(object sender, EventArgs e)
        {
            try
            {
                formConsultaPessoa form = new formConsultaPessoa();
                form.tpConsultaPessoa = consultaPessoaPorTipo.Fornecedor;
                form.Text = "Fornecedores";
                form.ShowDialog();
                form.Dispose();
            }
            catch (Exception ex)
            {
                TratarExcecao(ex);
            }
        }

        private void mEstoqueTransp_Click(object sender, EventArgs e)
        {
            try
            {
                formConsultaPessoa form = new formConsultaPessoa();
                form.tpConsultaPessoa = consultaPessoaPorTipo.Transportador;
                form.Text = "Transportadores";
                form.ShowDialog();
                form.Dispose();
            }
            catch (Exception ex)
            {
                TratarExcecao(ex);
            }
        }

        private void mEstoqueEntradaManual_Click(object sender, EventArgs e)
        {
            formEstoqueEntrada form = new formEstoqueEntrada();
            form.statusForm = statusForm.Novo;
            form.configForm();
            form.ShowDialog();
            form.Dispose();
        }

        private void mComercialCliente_Click(object sender, EventArgs e)
        {
            try
            {
                formConsultaPessoa form = new formConsultaPessoa();
                form.tpConsultaPessoa = consultaPessoaPorTipo.Cliente;
                form.Text = "Clientes";
                form.ShowDialog();
                form.Dispose();
            }
            catch (Exception ex)
            {
                TratarExcecao(ex);
            }
        }


        private void mFinConsultas_Click_1(object sender, EventArgs e)
        {
            formConsultaPagar form = new formConsultaPagar();
            form.ShowDialog();
        }
    }
}
