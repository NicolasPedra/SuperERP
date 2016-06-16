using SuperERP.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperERP.Vendas
{
    public class Editar
    {
        public static void Servico(int id)
        {

            var servicoRep = new ServicoRepositorio();
            var servico = servicoRep.PegarServicoUnico(id);
            servicoRep.Editar(servico);
        }

    }
}
