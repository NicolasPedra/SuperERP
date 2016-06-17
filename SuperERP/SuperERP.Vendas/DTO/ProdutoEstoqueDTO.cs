using SuperERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperERP.Vendas.DTO
{
    public class ProdutoEstoqueDTO
    {
        public int ID { get; set; }
        public int ID_Categoria { get; set; }
        public Nullable<int> ID_Unidade_Medida { get; set; }
        public string Nome { get; set; }
        public int Codigo_Cliente { get; set; }
        public double Valor_Venda { get; set; }
        public double Valor_Custo { get; set; }
        public int Estoque { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<Compra_Ativos> Compra_Ativos { get; set; }
        public virtual Unidade_Medida Unidade_Medida { get; set; }
        public virtual ICollection<Venda_Ativos> Venda_Ativos { get; set; }        
    }
}
