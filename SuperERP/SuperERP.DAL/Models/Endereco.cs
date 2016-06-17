using System;
using System.Collections.Generic;

namespace SuperERP.Models
{
    public partial class Endereco
    {
        public int ID { get; set; }
        public string CEP { get; set; }
        public Nullable<int> ID_PessoaJuridica { get; set; }
        public Nullable<int> ID_PessoaFisica { get; set; }
        public Nullable<int> ID_Empresa { get; set; }
        public string Endereco1 { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual PessoaFisica PessoaFisica { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }
    }
}
