using SuperERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperERP.DAL.Repositories
{
    public class ClienteFornecedorRepository : Repositorio<ClienteFornecedor>
    {
        public ICollection<ClienteFornecedor> ListarClientes()
        {
            return dbContext.ClienteFornecedors.ToList();
        }
    }
}
