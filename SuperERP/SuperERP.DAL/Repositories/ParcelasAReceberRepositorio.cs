using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using SuperERP.Models;

namespace SuperERP.DAL.Repositories
{
    public class ParcelasAReceberRepositorio : Repositorio<Parcelamento>
    {
        public ICollection<Parcelamento> PegarTodasParcelas()
        {
            var parcelas = dbContext.Parcelamentoes.Include(x => x.Venda.ClienteFornecedor);
            return parcelas.ToList();
        }

        public Parcelamento PegarParcela( int id )
        {
            var parcela = dbContext.Parcelamentoes.Where(x => x.ID == id).FirstOrDefault();

            return parcela;
        }
        public bool ReceberParcela(Parcelamento parcela)
        {
            Parcelamento parcelaAlterada = dbContext.Parcelamentoes.Where(p => p.ID == parcela.ID).FirstOrDefault();
            parcela.Pago = true;
            parcela.Data_Pago = System.DateTime.Now;

            if (parcelaAlterada != null)
            {
                dbContext.Entry(parcelaAlterada).CurrentValues.SetValues(parcela);
            }else{return false;}

            dbContext.SaveChanges();
            
            return true;
        }
    }
}
