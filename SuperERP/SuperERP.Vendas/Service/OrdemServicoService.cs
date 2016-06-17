using System;
using System.Collections.Generic;
using SuperERP.Vendas.DTO;
using SuperERP.DAL.Repositories;
using AutoMapper;
using SuperERP.Models;

namespace SuperERP.Vendas.Service
{
    public class OrdemServicoService
    {
        public void savarOrdemServico(OrdemServicoDTO ordem) {

            // converter o dto em obj model antes de enviar para o repositorio
          //  var ordemServico = new Ordem_Servico();
           var ordemServico = Mapper.Map<OrdemServicoDTO , Ordem_Servico>(ordem);       

            var gravar = new OrdemServicoRepositorio();
            gravar.salvarOrdemServico(ordemServico);

        }

        public OrdemServicoDTO buscarOrdemServico(int idOrdem) {

            // converter o retorno que é um objeto model para um dto

            var ordem = new OrdemServicoRepositorio().buscarPorID(idOrdem);

            var ordemDTO = Mapper.Map<Ordem_Servico, OrdemServicoDTO> (ordem);

            return ordemDTO;
        }

        public ICollection<OrdemServicoDTO> listOrdemServico() {

            // ira receber uma coleção de objetos

            var listOrdem = new OrdemServicoRepositorio().listarTudao();

            var listaOrdemDTO = Mapper.Map<ICollection<Ordem_Servico> , ICollection<OrdemServicoDTO>>(listOrdem);

            return listaOrdemDTO;
        }

    }
}
