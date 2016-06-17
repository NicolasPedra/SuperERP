using SuperERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperERP.DAL.Repositories
{
    public class PessoaFisicaRepositorio : Repositorio<PessoaFisica>
    {
        public PessoaFisica ObterPorEmail(string email)
        {
            return (from pessoaFisica in dbContext.PessoaFisicas join fornecedorCliente in dbContext.ClienteFornecedors on pessoaFisica.ID equals fornecedorCliente.ID_PF
                        join contato in dbContext.Contatoes on fornecedorCliente.ID equals contato.ID_PessoaJuridica where contato.Email == email select pessoaFisica).FirstOrDefault();
        }

        public PessoaFisica ObterPorCPF(string cpf)
        {
            return dbContext.PessoaFisicas.FirstOrDefault(x => x.CPF == cpf);
        }

        public List<PessoaFisica> ObterTodos()
        {
            //var clientes = (from pessoaFisica in dbContext.PessoaFisicas select pessoaFisica).ToList();
            var clientes = dbContext.PessoaFisicas.ToList();
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
