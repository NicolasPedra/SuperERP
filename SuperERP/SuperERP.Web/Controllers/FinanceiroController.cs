using SuperERP.Financeiro.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperERP.Web.Controllers
{
    public class FinanceiroController : Controller
    {
        // GET: Financeiro
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ContasPagar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ContasPagar(ContasPagarDTO ContasPagar)
        {

            return View();
        }



    }
}