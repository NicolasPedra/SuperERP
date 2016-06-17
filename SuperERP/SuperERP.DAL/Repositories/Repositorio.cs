using SuperERP.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperERP.DAL.Repositories
{
    public class Repositorio<T> : IRepository<T> where T : class
    {
        protected SuperERPContext dbContext = new SuperERPContext();

        public ICollection<T> ObterLista()
        {
            return dbContext.Set<T>().ToList();
        }

        public T ObterPorEntidadePorId(int id)
        {
            return dbContext.Set<T>().Find(id);
        }

        public bool Cadastrar(T entidade)
        {
            try
            {
                var d = dbContext.Set<T>().Add(entidade);

                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool Alterar(T entidade)
        {
            try
            {
                dbContext.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool Deletar(T entidade)
        {
            try
            {
                dbContext.Set<T>().Remove(entidade);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool Deletar(int id)
        {
            try
            {
                var entidade = ObterPorEntidadePorId(id);
                dbContext.Set<T>().Remove(entidade);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private void Dispose(bool disposing)
        {
            if (!disposing) return;
            if (dbContext == null) return;
            dbContext.Dispose();
            dbContext = null;
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}