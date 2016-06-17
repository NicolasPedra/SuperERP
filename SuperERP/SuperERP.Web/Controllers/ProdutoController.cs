using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SuperERP.Compras;
using SuperERP.Compras.DTO;


namespace SuperERP.Web.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Index()
        {
            var lista = Compras.Service.ProdutoService.Listar();
            return View(lista);
        }

        //
        // GET: /Produto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Produto/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Produto/Create
        [HttpPost]
        public ActionResult Create(ProdutoDTO produto)
        {
            try
            {
                Compras.Service.ProdutoService.Cadastrar(produto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Produto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Produto/Edit/5
        [HttpPost]
        public ActionResult Edit(ProdutoDTO produto)
        {
            try
            {
                Compras.Service.ProdutoService.Alterar(produto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Produto/Delete/5
        [HttpPost]
        public ActionResult Delete(ProdutoDTO produto)
        {
            Compras.Service.ProdutoService.Deletar(produto.ID);
            return View();
        }
    }
}
