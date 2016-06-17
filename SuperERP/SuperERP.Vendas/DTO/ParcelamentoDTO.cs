using SuperERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperERP.Vendas.DTO
{
    public class ParcelamentoDTO
    {
        public int ID { get; set; }
        public int ID_Venda { get; set; }
        public int Numero_Parcela { get; set; }
        public decimal Valor { get; set; }
        public Nullable<bool> Pago { get; set; }
        public System.DateTime Data_Pagamento { get; set; }
        public Nullable<System.DateTime> Data_Pago { get; set; }
        public virtual Venda Venda { get; set; }
    }
}
