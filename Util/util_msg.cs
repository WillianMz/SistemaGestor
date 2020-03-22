namespace Util
{
    public class util_msg
    {
        public static string sistema = "Gestor Comercial";
       //public static string sistema2 = 


        #region MENSAGENS DE MANIPULAÇÃO DE DADOS

        public static string msgSalvar    = "Dados salvos com sucesso!";
        public static string msgAlterar   = "Dados alterados com sucesso!";
        public static string msgGravarID  = "Dados salvos com sucesso!\nCódigo: ";
        public static string msgExcluir   = "Dados excluídos com sucesso!";
        public static string msgDesativar = "Dados desativados com sucesso!";
        public static string msgNenhumRegistroSelecionado = "Nenhum registro foi selecionado!";

        public static string msgConectado    = "Conectado a base de dados";
        public static string msgDesconectado = "Sem conexão com a base de dados";

        #endregion

 
        #region MENSAGENS DE ERRO

        public static string msgErro                = "Ocorreu um erro! \nDetalhes: ";
        public static string msgFiltroPesquisaVazio = "Digite algum filtro para a pesquisa";
        public static string msgConfigForm          = "Erro ao exibir tela!";

        #endregion


        #region MENSAGENS DIVERSAS

        public static string msgCPFCNPJ_Vazio         = "Para continuar, informe o CPF/CNPJ da pessoa!";
        public static string msgCPF_CNPJ_Cadastrado   = "Já existe um cadastro com este CNPJ/CPF! Verifique!";
        public static string msgCampoSomenteNumero    = "Somente é permitido números!";
        public static string msgCampoObrigatorioVazio = "Campo obrigatório, verifique";
        public static string msgFormAberto            = "Já existe uma janela aberta, Deseja fechá-la e abrir novamente?\n\n**ATENÇÃO**: Os dados não salvos, serão perdidos!";
        public static string msgFiltroPorCodigo       = "O filtro de pesquisa aplicado 'CÓDIGO' recebe apenas NÚMERO! Verifique.";

        #endregion

        #region ESTOQUE

        public static string msgDesativarProduto = "Produto desativado com sucesso!";
        public static string msgCodProdutoCadastrado = "Este código já está cadastrado!";
        
        #endregion

        #region PROGRAMADORES

        public static string msg_RecursoNaoImplementado = "Funcionalidade não disponível no momento!";

        #endregion
    }
}
