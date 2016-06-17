using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperERP.DAL.Repositories;
using SuperERP.Vendas.DTO;
using SuperERP.Models;

namespace SuperERP.Vendas.Service
{
    public class ClienteService
    {
        public static ICollection<PessoaFisicaDTO> ListaPessoasFisicas()
        {
            Config.AutoMapperConfig.Inicializar();            
            var repositorio = new PessoaFisicaRepositorio();
            var repositorioContato = new ContatoRepository();
            var pessoaFisica = repositorio.ObterTodos();
            var p = Mapper.Map<ICollection<PessoaFisica>, ICollection<PessoaFisicaDTO>>(pessoaFisica);
            for (int i = 0; i < pessoaFisica.Count; i++)
            {
                var contato = repositorioContato.ObterPorPessoaFisica(p.ElementAt(i).ID);
                if (contato != null)
                {
                    p.ElementAt(i).Email = contato.Email;
                    p.ElementAt(i).Fone = contato.Email;
                }
            }
            return p;
        }

        public static ICollection<PessoaJuridicaDTO> ListaPessoasJuridicas()
        {
            Config.AutoMapperConfig.Inicializar();
            var repositorio = new PessoaJuridicaRepository();
            var repositorioContato = new ContatoRepository();
            var pessoaJuridica = repositorio.ObterTodos();
            var p = Mapper.Map<ICollection<PessoaJuridica>, ICollection<PessoaJuridicaDTO>>(pessoaJuridica);
            for (int i = 0; i < pessoaJuridica.Count; i++)
            {
                var contato = repositorioContato.ObterPorPessoaJuridica(p.ElementAt(i).ID);
                if (contato != null)
                {
                    p.ElementAt(i).Email = contato.Email;
                    p.ElementAt(i).Fone = contato.Email;
                }
            }
            return p;
        }
    }
}
