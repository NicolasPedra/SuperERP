using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperERP.Web.Controllers
{
    public class ServicoController : Controller
    {
        //
        // GET: /Servico/
        public ActionResult Index()
        {
            var servicos = Vendas.Listar.Servico();

            return View(servicos);
        }

        //
        // GET: /Servico/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Servico/Create
        public ActionResult Create()
        {
            ViewBag.ID_Categoria_Servico = new SelectList(Vendas.Listar.CategoriasServico(), "ID", "Nome");
            ViewBag.ID_Empresa = new SelectList(Vendas.Listar.Empresas(), "ID", "Nome");
            return View();
        }

        //
        // POST: /Servico/Create
        [HttpPost]
        public ActionResult Create(SuperERP.Vendas.DTO.ServicoDTO servicoDTO)
        {
            try
            {
                // TODO: Add insert logic here
                SuperERP.Vendas.Cadastro.Servico(servicoDTO);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Servico/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.ID_Categoria_Servico = new SelectList(Vendas.Listar.CategoriasServico(), "ID", "Nome");
            ViewBag.ID_Empresa = new SelectList(Vendas.Listar.Empresas(), "ID", "Nome");
            var s = Vendas.Listar.ServicoUnico(id);
            return View(s);
        }

        //
        // POST: /Servico/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                Vendas.Editar.Servico(Vendas.Listar.ServicoUnico(id));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Servico/Delete/5
        public ActionResult Delete(int id)
        {
            var s = Vendas.Listar.ServicoUnico(id);
            return View(s);
        }

        //
        // POST: /Servico/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Vendas.Deletar.Servico(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
