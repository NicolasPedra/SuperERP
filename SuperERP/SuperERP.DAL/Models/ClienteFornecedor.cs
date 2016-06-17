using System;
using System.Collections.Generic;

namespace SuperERP.Models
{
    public partial class ClienteFornecedor
    {
        public ClienteFornecedor()
        {
            this.Compras = new List<Compra>();
            this.ProdutoFornecedors = new List<ProdutoFornecedor>();
            this.Vendas = new List<Venda>();
        }

        public int ID { get; set; }
        public Nullable<int> ID_PJ { get; set; }
        public Nullable<int> ID_PF { get; set; }
        public int Tipo { get; set; }
        public virtual PessoaFisica PessoaFisica { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }
        public virtual ICollection<Compra> Compras { get; set; }
        public virtual ICollection<ProdutoFornecedor> ProdutoFornecedors { get; set; }
        public virtual ICollection<Venda> Vendas { get; set; }
    }
}
