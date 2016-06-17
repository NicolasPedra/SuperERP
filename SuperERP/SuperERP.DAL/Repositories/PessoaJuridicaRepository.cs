using SuperERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperERP.DAL.Repositories
{
    public class PessoaJuridicaRepository : Repositorio<PessoaJuridica>
    {
        public PessoaJuridica ObterPorEmail(string email)
        {
            return (from pessoaJuridica in dbContext.PessoaJuridicas
                    join fornecedorCliente in dbContext.ClienteFornecedors on pessoaJuridica.ID equals fornecedorCliente.ID_PF
                    join contato in dbContext.Contatoes on fornecedorCliente.ID equals contato.ID_PessoaJuridica
                    where contato.Email == email
                    select pessoaJuridica).FirstOrDefault();
        }

        public PessoaJuridica ObterPorCNPJ(string cnpj)
        {
            return dbContext.PessoaJuridicas.FirstOrDefault(x => x.CNPJ == cnpj);
        }
        public List<PessoaJuridica> ObterTodos()
        {
            var clientes = dbContext.PessoaJuridicas.ToList();
            if (clientes.Count() > 0)
            {
                return clientes;
            }
            else
            {
                return null;
            }
        }
    }
}