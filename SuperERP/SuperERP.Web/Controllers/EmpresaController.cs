using SuperERP.Compras.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperERP.Web.Controllers
{
    public class EmpresaController : Controller
    {
        // GET: Empresa
        public ActionResult Index()
        {
            return View(Compras.Service.EmpresaService.Listar());
        }

        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Incluir(EmpresaDTO empresa)
        {
            try
            {
                Compras.Service.EmpresaService.Cadastrar(empresa);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }

        public ActionResult Alterar(int empresaID)
        {
            return View(Compras.Service.EmpresaService.BuscaPorId(empresaID));
        }

        [HttpPost]
        public ActionResult Alterar(EmpresaDTO empresa)
        {
            try
            {
                Compras.Service.EmpresaService.Alterar(empresa);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }

        public ActionResult Excluir(int empresaID)
        {
            return View(Compras.Service.EmpresaService.BuscaPorId(empresaID));
        }

        [HttpPost]
        public ActionResult Excluir(UsuarioDTO empresa)
        {
            try
            {
                Compras.Service.EmpresaService.Deletar(empresa.ID);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}