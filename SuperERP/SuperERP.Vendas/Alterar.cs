using AutoMapper;
using SuperERP.DAL.Repositories;
using SuperERP.Models;
using SuperERP.Vendas.DTO;
using System.Collections.Generic;

namespace SuperERP.Vendas
{
    public class Alterar
    {
        public static bool Parcela(int id){
            Config.AutoMapperConfig.Inicializar();
            var parcelamentoRep = new ParcelasAReceberRepositorio();
            ParcelamentoDTO parcela = Listar.Parcelamento(id);
            var p = Mapper.Map<ParcelamentoDTO, Parcelamento>(parcela);
            
            try
            {
                return parcelamentoRep.ReceberParcela(p);
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}
