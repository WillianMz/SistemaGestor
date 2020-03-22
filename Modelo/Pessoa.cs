using Modelo.Localizacao;
using System;

namespace Modelo
{
    public class Pessoa
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public bool Cliente { get; set; }
        public bool Fornecedor { get; set; }
        public bool Transportador { get; set; }
        public bool Funcionario { get; set; }
        public bool Outro { get; set; }
        public TipoPessoa Tipo { get; set; } = new TipoPessoa();
        public string CPF_CNPJ { get; set; }
        public string NomeCompleto { get; set; }
        public string Fantasia { get; set; }
        public string RG_IE { get; set; }

        //Endereco principal
        public string CEP { get; set; }
        public Pais Pais { get; set; } = new Pais();
        public UF UF { get; set; } = new UF();
        public Cidade Cidade { get; set; } = new Cidade();
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public long Telefone { get; set; }
        public long Celular { get; set; }
        public string Contato { get; set; }
        public string Email { get; set; }
        public DateTime DtNasc { get; set; }
        public DateTime DtCadastro { get; set; }
        public DateTime DtAlteracao { get; set; }
        public string Local { get; set; }
    }
}
