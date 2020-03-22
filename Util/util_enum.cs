namespace Util
{
    public enum Software
    {
        Estoque,
        Financeiro,
        Comercial
    }

    public enum statusForm
    {
        Novo,
        Detalhes,
        Editar,
        Consulta
    }

    public enum tipoPessoa
    {
        Cliente,
        Fornecedor,
        Transportador,
        Colaborador,
        Outro
    }

    public enum consultaPessoaPorTipo
    {
        Pessoas       = 1,
        Cliente       = 2,
        Fornecedor    = 3,
        Transportador = 4,
        Funcionario   = 5,
        Outros        = 6
    }        
}
