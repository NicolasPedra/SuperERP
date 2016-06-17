using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using SuperERP.Models;

namespace SuperERP.DAL.Repositories
{
    public class VendaAtivosRepository : Repositorio<Venda_Ativos>
    {
        public ICollection<Venda_Ativos> PegarVendaAtivos(int vendaId)
        {
            var venda = dbContext.Venda_Ativos
                        .Include(x => x.Produto)
                        .Include(x => x.Produto.Ncm)
                        .Include(x => x.Produto.Unidade_Medida)
                        .Include(x => x.Produto.Categoria)
                        .Where(x => x.ID_Venda == vendaId).ToList();
            return venda;
        }
    }
}
