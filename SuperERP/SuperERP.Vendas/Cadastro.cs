using SuperERP.Models;
using SuperERP.Vendas.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SuperERP.Vendas
{
    public class Cadastro
    {
        public static void PessoaFisica(PessoaFisicaDTO pessoa) { 

        }
        public static void Servico(ServicoDTO servico)
        {
            var rep = new DAL.Repositories.Repositorio<Servico>();
            //var novoServico = Mapper.Map<ServicoDTO, Servico>(servico);
            Servico novoServico = new Servico();


            novoServico.ID_Empresa = servico.ID_Empresa;

            novoServico.ID_Categoria_Servico = servico.ID_Categoria_Servico;

            novoServico.Nome = servico.Nome;

            novoServico.ISS = servico.ISS;

            novoServico.ICMS = servico.ICMS;

            novoServico.IVA = servico.IVA;

            novoServico.ST = servico.ST;

            novoServico.PIS = servico.PIS;

            novoServico.COFINS = servico.COFINS;

            novoServico.valor = servico.valor;

            novoServico.custo = servico.custo;




            rep.Cadastrar(novoServico);
        }
        public static void PessoaJuridica(PessoaJuridicaDTO pessoa) { }
    }
}
