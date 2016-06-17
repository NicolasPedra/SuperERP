using System;
using System.Collections.Generic;

namespace SuperERP.Models
{
    public partial class Empresa
    {
        public Empresa()
        {
            this.Compras = new List<Compra>();
            this.DadosBancarios = new List<DadosBancario>();
            this.Enderecoes = new List<Endereco>();
            this.PessoaFisicas = new List<PessoaFisica>();
            this.PessoaJuridicas = new List<PessoaJuridica>();
            this.Produtoes = new List<Produto>();
            this.Servicoes = new List<Servico>();
            this.Usuarios = new List<Usuario>();
            this.Vendas = new List<Venda>();
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public virtual ICollection<Compra> Compras { get; set; }
        public virtual ICollection<DadosBancario> DadosBancarios { get; set; }
        public virtual ICollection<Endereco> Enderecoes { get; set; }
        public virtual ICollection<PessoaFisica> PessoaFisicas { get; set; }
        public virtual ICollection<PessoaJuridica> PessoaJuridicas { get; set; }
        public virtual ICollection<Produto> Produtoes { get; set; }
        public virtual ICollection<Servico> Servicoes { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<Venda> Vendas { get; set; }
    }
}
