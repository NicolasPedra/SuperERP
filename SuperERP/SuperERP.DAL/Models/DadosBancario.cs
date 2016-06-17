using System;
using System.Collections.Generic;

namespace SuperERP.Models
{
    public partial class DadosBancario
    {
        public DadosBancario()
        {
            this.Compras = new List<Compra>();
            this.Vendas = new List<Venda>();
        }

        public int ID { get; set; }
        public string Banco { get; set; }
        public string Conta_Corrente { get; set; }
        public string Agencia { get; set; }
        public Nullable<int> ID_PessoaJuridica { get; set; }
        public Nullable<int> ID_PessoaFisica { get; set; }
        public Nullable<int> ID_Empresa { get; set; }
        public virtual ICollection<Compra> Compras { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual PessoaFisica PessoaFisica { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }
        public virtual ICollection<Venda> Vendas { get; set; }
    }
}
