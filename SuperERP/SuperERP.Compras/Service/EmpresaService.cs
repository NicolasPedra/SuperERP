using SuperERP.Compras.DTO;
using SuperERP.DAL.Repositories;
using SuperERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperERP.Compras.Service
{
    public static class EmpresaService
    {
        public static void Cadastrar(EmpresaDTO empresa)
        {
            ServicoGenerico<Empresa, EmpresaDTO>.Cadastrar(empresa);
        }
        public static void Alterar(EmpresaDTO empresa)
        {
            ServicoGenerico<Empresa, EmpresaDTO>.Alterar(empresa);
        }
        public static ICollection<EmpresaDTO> Listar()
        {
            return ServicoGenerico<Empresa, EmpresaDTO>.Listar();
        }
        public static void Deletar(int IdEmpresa)
        {
            ServicoGenerico<Empresa, EmpresaDTO>.Deletar(IdEmpresa);
        }

        public static EmpresaDTO BuscaPorId(int IdEmpresa)
        {
            return ServicoGenerico<Empresa, EmpresaDTO>.BuscaPorId(IdEmpresa);
        }
    }
}
