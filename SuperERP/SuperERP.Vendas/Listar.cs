﻿using AutoMapper;
using SuperERP.DAL.Models;
using SuperERP.DAL.Repositories;
using SuperERP.Vendas.DTO;
using System.Collections.Generic;

namespace SuperERP.Vendas
{
    public class Listar
    {
        public static ICollection<PessoaFisicaDTO> PessoasFisicas()
        {
            //ToDo: Ainda deverá ser refatorado
            var pessoaRepo = new PessoaFisicaRepositorio();
            var listaDePessoasFisicas = pessoaRepo.ObterLista();
            var listarDePessoaFisicaDTO = Mapper.Map<ICollection<PessoaFisica>, ICollection<PessoaFisicaDTO>>(listaDePessoasFisicas);
            return new List<PessoaFisicaDTO>();
        }
        public static PessoaFisicaDTO PessoaFisica(int id)
        {
            //ToDo: Ainda deverá ser refatorado
            var pessoaRepo = new PessoaFisicaRepositorio();
            var pessoaFisica = pessoaRepo.ObterPorEntidadePorId(id);
            var pessoaFisicaDTO = Mapper.Map<PessoaFisica, PessoaFisicaDTO>(pessoaFisica);
            return new PessoaFisicaDTO();
        }

        public static ICollection<PessoaJuridicaDTO> PessoasJuridicas()
        {
            //ToDo: Ainda deverá ser implementado
            return new List<PessoaJuridicaDTO>();
        }

        public static ICollection<ParcelamentoDTO>[] Parcelamentos()
        {
            Config.AutoMapperConfig.Inicializar();
            List<ParcelamentoDTO> parcelasAreceber = new List<ParcelamentoDTO>();
            List<ParcelamentoDTO> parcelasRecebidas = new List<ParcelamentoDTO>();
            List<ParcelamentoDTO> parcelasVencidas = new List<ParcelamentoDTO>();

            ICollection<ParcelamentoDTO>[] parcelas = new ICollection<ParcelamentoDTO>[3];

            var parcelamentoRep = new ParcelasAReceberRepositorio();
            var parcelamentos = parcelamentoRep.PegarTodasParcelas();
            
            var parcelasDTO = Mapper.Map<ICollection<Parcelamento>, ICollection<ParcelamentoDTO>>(parcelamentos);

            foreach (var p in parcelasDTO)
            {
                if (p.Pago == false && System.DateTime.Compare(p.Data_Pagamento, System.DateTime.Today) < 0)
                {
                    parcelasVencidas.Add(p);
                }
                else if (p.Pago == true)
                {
                    parcelasRecebidas.Add(p);
                }
                else if (p.Pago == false && System.DateTime.Compare(p.Data_Pagamento, System.DateTime.Today) > 0)
                {
                    parcelasAreceber.Add(p);
                }
            }
            parcelas[0] = parcelasAreceber;
            parcelas[1] = parcelasRecebidas;
            parcelas[2] = parcelasVencidas;

            return parcelas;
        }
        public static ParcelamentoDTO Parcelamento(int id)
        {
            Config.AutoMapperConfig.Inicializar();
            var parcelamentosRep = new ParcelasAReceberRepositorio();
            var parcela = parcelamentosRep.PegarParcela(id);
            var p = Mapper.Map<Parcelamento, ParcelamentoDTO>(parcela);
            return p;
        }

        public static PessoaJuridicaDTO PessoaJuridica()
        {
            //ToDo: Ainda deverá ser implementado
            return new PessoaJuridicaDTO();
        }
    }
}
