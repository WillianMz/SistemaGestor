using Modelo.Localizacao;
using System;

namespace Modelo
{
    public class Pessoa
    {
        public int id { get; set; }
        public bool ativo { get; set; }
        public bool cliente { get; set; }
        public bool fornecedor { get; set; }
        public bool transportador { get; set; }
        public bool funcionario { get; set; }
        public bool outro { get; set; }
        public TipoPessoa tipo { get; set; } = new TipoPessoa();
        public string CPF_CNPJ { get; set; }
        public string nomeCompleto { get; set; }
        public string fantasia { get; set; }
        public string RG_IE { get; set; }

        //Endereco principal
        public string CEP { get; set; }
        public Pais pais { get; set; } = new Pais();
        public UF uf { get; set; } = new UF();
        public Cidade cidade { get; set; } = new Cidade();
        public string bairro { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public long telefone { get; set; }
        public long celular { get; set; }
        public string contato { get; set; }
        public string email { get; set; }
        public DateTime dtNasc { get; set; }
        public DateTime dtCadastro { get; set; }
        public DateTime dtAlteracao { get; set; }
        public string local { get; set; }
    }
}
