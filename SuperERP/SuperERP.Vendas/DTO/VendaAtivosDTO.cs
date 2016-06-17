using SuperERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperERP.Vendas.DTO
{
    public class VendaAtivosDTO
    {
        public int ID { get; set; }
        public int ID_Venda { get; set; }
        public Nullable<int> ID_Produto { get; set; }
        public Nullable<double> Imposto { get; set; }
        public string Detalhes { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Venda Venda { get; set; }
    }
}
