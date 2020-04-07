using Modelo.Localizacao;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Empresa
    {
        public int Id { get; set; }
        public bool ativo { get; set; }
        public string cnpj { get; set; }
        public bool matriz { get; set; }
        public bool filial { get; set; }
        public string razaoSocial { get; set; }
        public string fantasia { get; set; }
        public string ie { get; set; }
        public string im { get; set; }
        public int crt { get; set; }//codigo regime tributario
        public int segmento { get; set; }

        public string cep { get; set; }
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
        public string site { get; set; }

        public DateTime dtCadastro { get; set; }
        public DateTime dtAlteracao { get; set; }
        public string local { get; set; }

        public string descricao
        {
            get { return Id + " - " +fantasia; }
        }
    }
}
