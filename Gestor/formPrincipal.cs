using CustomAlertBoxDemo;
using Modelo;
using Modelo.User;
using Sistema.Estoque.Interfaces;
using Sistema.Financeiro.Interfaces;
using Sistema.Pessoas.Interfaces;
using Sistema.Utilitario.Controles;
using System;
using System.Windows.Forms;
using Util;
using static Modelo.Config.Parametro;

namespace Gestor
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
            empresaLogada();            
        }

        private void empresaLogada()
        {
            BLL_Empresa controle = new BLL_Empresa();
            Empresa e = controle.filtrarEmpresa_ID(UsuarioLogado.empresa, true);
            lblEmpresa.Text = e.razaoSocial + " | " + e.local;

            BLL_Usuario users = new BLL_Usuario();
            Usuario u = users.userID(UsuarioLogado.idUser);
            lblUsuario.Text = "Olá, " + u.login;
            lblNivel.Text = "@" + u.nivel;
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

        private void mFinPagar_Click(object sender, EventArgs e)
        {
            formCadastroPagar form = new formCadastroPagar();
            form.ShowDialog();
        }

        private void cadastroDeBancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCadastroBanco form = new formCadastroBanco();
            form.ShowDialog();
        }

        private void cadastroDePlanoDeContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPlanoDeContas form = new formPlanoDeContas();
            form.Show();
        }

        private void mArq_users_Click(object sender, EventArgs e)
        {
            formConsultaUsuarios f = new formConsultaUsuarios();
            f.ShowDialog();
            f.Dispose();
        }

        private void mEstoqueProdEstMercadologica_Click(object sender, EventArgs e)
        {
            formClassifProdutos f = new formClassifProdutos();
            f.status = statusForm.Consulta;
            f.configForm();
            f.ShowDialog();
            f.Dispose();
        }

        private void formPrincipal_Shown(object sender, EventArgs e)
        {
            Notificador.notificacao("Versão de Teste", Form_Alert.enmType.Info);
        }
    }
}
