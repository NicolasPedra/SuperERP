using System;
using System.Collections.Generic;

namespace SuperERP.Models
{
    public partial class Contato
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public Nullable<int> ID_PessoaJuridica { get; set; }
        public Nullable<int> ID_PessoaFisica { get; set; }
        public string Email { get; set; }
        public string Fone { get; set; }
        public string Cargo { get; set; }
        public virtual PessoaFisica PessoaFisica { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }
    }
}
