using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using SuperERP.Models;

namespace SuperERP.DAL.Repositories
{
    public class VendasRepository : Repositorio<Venda>
    {        
        public Venda PegarVenda(int vendaId)
        {
            var venda = dbContext.Vendas
                        .Include(x => x.ClienteFornecedor)
                        .Include(x => x.Forma_Pgto)
                        .Include(x => x.Venda_Ativos)
                        .Where(x => x.ID == vendaId).FirstOrDefault();           
            return venda;
        }
    }
}
