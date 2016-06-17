using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperERP.Vendas.DTO;

namespace SuperERP.Compras.DTO
{
    public class CompraAtivosDTO
    {
        public int ID { get; set; }
        public int ID_Compra { get; set; }
        public Nullable<int> ID_Produto { get; set; }
        public Nullable<int> ID_Servico { get; set; }
        public Nullable<decimal> Imposto { get; set; }
        public string Detalhes { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public virtual CompraDTO Compra { get; set; }
        public virtual ProdutoDTO Produto { get; set; }
        public virtual ServicoDTO Servico { get; set; }
    }
}
