using SuperERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperERP.Vendas.DTO
{
    public class VendaDTO
    {       
        public int ID { get; set; }
        public int ID_Empresa { get; set; }
        public int ID_Usuario { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_FormaPgto { get; set; }
        public int Venda_Num { get; set; }
        public System.DateTime Data_Venda { get; set; }
        public double Desconto { get; set; }
        public virtual ClienteFornecedor ClienteFornecedor { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<Venda_Ativos> Venda_Ativos { get; set; }
        public virtual Forma_Pgto Forma_Pgto { get; set; }
    }
}
