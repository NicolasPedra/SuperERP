using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using SuperERP.Models;


namespace SuperERP.DAL.Repositories
{
    public class OrdemServicoRepositorio : Repositorio<Ordem_Servico>
    {
        public ICollection<Ordem_Servico> listarTudao()
        {
            return dbContext.Ordem_Servico
                .Include(x => x.Servico)
                .Include(x => x.Status_Servico)
                .ToList(); 
        }

        public Ordem_Servico buscarPorID(int ordemID)
        {
            /* var ordem = dbContext.OrdemServico.FirstOrDefault(x=> x.ID == ordemID);
             return ordem;*/
            return dbContext.Ordem_Servico.FirstOrDefault(x => x.ID == ordemID);

        }

        public void salvarOrdemServico(Ordem_Servico ordem)
        {
            try
            {
                dbContext.Ordem_Servico.Add(ordem);
            }
            catch (Exception)
            {

                throw;
            }

            dbContext.SaveChanges();
        }

        public void deletarOrdemServico(Ordem_Servico ordem)
        {
            dbContext.Ordem_Servico.Remove(ordem);
            dbContext.SaveChanges();
        }
    }
}
