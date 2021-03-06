﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SuperERP.Models;

namespace SuperERP.DAL.Repositories
{
    public class ServicoRepositorio : Repositorio<Servico>
    {

        public ICollection<Empresa> PegarEmpresa()
        {
            return dbContext.Empresas.ToList();
        }

        public ICollection<Servico> PegarServico()
        {
            return dbContext.Servicoes.Include(x => x.Categoria).Include(x => x.Empresa).ToList();
        }
        public Servico PegarServicoUnico(int id)
        {
            return dbContext.Servicoes.Where(x => x.ID == id).FirstOrDefault();
        }



    }
}
