using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperERP.Compras.DTO
{
    public class ProdutoFornecedorDTO
    {
        public int ID { get; set; }
        public int ID_Produto { get; set; }
        public int ID_Fornecedor { get; set; }
        public double Valor_Custo { get; set; }
        public virtual ClienteFornecedorDTO ClienteFornecedor { get; set; }
        public virtual ProdutoDTO Produto { get; set; }
    }
}
