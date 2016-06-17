using SuperERP.Compras.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperERP.Web.Controllers
{
    public class PerfilController : Controller
    {
        // GET: Perfil
        public ActionResult Index()
        {
            return View(Compras.Service.PerfilService.Listar());
        }

        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Incluir(PerfilDTO perfil)
        {

            try
            {
                Compras.Service.PerfilService.Cadastrar(perfil);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }

        public ActionResult Alterar(int pefilID)
        {
            return View(Compras.Service.PerfilService.BuscaPorId(pefilID));
        }

        [HttpPost]
        public ActionResult Alterar(PerfilDTO perfil)
        {
            try
            {
                Compras.Service.PerfilService.Alterar(perfil);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }

        public ActionResult Excluir(int pefilID)
        {
            return View(Compras.Service.PerfilService.BuscaPorId(pefilID));
        }

        [HttpPost]
        public ActionResult Excluir(PerfilDTO pefil)
        {
            try
            {
                Compras.Service.PerfilService.Deletar(pefil.ID);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}