using AutoMapper;
using SuperERP.DAL.Models;
using SuperERP.DAL.Repositories;
using SuperERP.Vendas.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperERP.Vendas
{
    public class Editar
    {
        public static void Servico(ServicoDTO servico)
        {

            var servicoRep = new ServicoRepositorio();
            var s = Mapper.Map<ServicoDTO, Servico>(servico);
            servicoRep.Alterar(s);
        }

    }
}
