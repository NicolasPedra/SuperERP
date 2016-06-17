using SuperERP.Vendas;
using SuperERP.Vendas.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SuperERP.Compras.DTO;

namespace SuperERP.Web.Controllers
{
    public class CadastroController : Controller
    {
        public ActionResult Empresa()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Empresa(Compras.DTO.EmpresaDTO empresa)

        {
            Compras.Service.EmpresaService.Cadastrar(empresa);
            return View();
        }

        public ActionResult Usuario()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Usuario(UsuarioDTO usuario)
        {

            Compras.Service.UsuarioService.Cadastrar(usuario);
            return View();
        }

        public ActionResult PessoaFisica()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PessoaFisica(PessoaFisicaDTO pessoa)
        {
            // var pessoaFisica = SuperERP.Vendas.Listar.PessoaFisica();

            var teste = new List<string>();
            return View();
        }

        public ActionResult PessoaJuridica()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PessoaJuridica(PessoaJuridicaDTO pessoa)
        {
            return View();
        }
    }
}