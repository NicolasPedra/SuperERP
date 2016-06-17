using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using SuperERP.Models;

namespace SuperERP.DAL.Repositories
{
    public class EstoqueRepository : Repositorio<Produto>
    {
        public ICollection<Produto> PegarEstoque()
        {
            return dbContext.Produtoes
                            .Include( x=> x.Categoria)
                            .Include( x => x.Unidade_Medida )
                            .ToList();
        }
        public ICollection<Venda_Ativos> PegarVendaAtivosDoProduto(int produtoId)
        {
            return dbContext.Venda_Ativos
                            .Include(x => x.Venda)
                            .Include(x => x.Venda.ClienteFornecedor)
                            .Include(x => x.Produto)
                            .Where(x => x.ID_Produto == produtoId)
                            .ToList();
        }
        public ICollection<Compra_Ativos> PegarCompraAtivosDoProduto(int produtoId)
        {
            return dbContext.Compra_Ativos
                            .Include(x => x.Compra)
                            .Include(x => x.Compra.ClienteFornecedor)
                            .Include(x => x.Produto)
                            .Where( x => x.ID_Produto == produtoId)
                            .ToList();
        }
    }
}
