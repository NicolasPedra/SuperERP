using AutoMapper;
using SuperERP.DAL.Models;
using SuperERP.DAL.Repositories;
using SuperERP.Vendas.DTO;
using System.Collections.Generic;

namespace SuperERP.Vendas
{
    public class Deletar
    {
        public static void Servico(int id)
        {
            
            var servicoRep = new ServicoRepositorio();
            var servico = servicoRep.PegarServicoUnico(id);
            servicoRep.Deletar(servico);
        }
    }
}
