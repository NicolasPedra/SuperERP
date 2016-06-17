using System.Web.Mvc;
using SuperERP.Vendas.DTO;
using SuperERP.Vendas.Service;

namespace SuperERP.Web.Controllers
{
    public class OrdemServicoController : Controller
    {

        public ActionResult ListarTodasOrdens() // listar todos os itens ok
        {
            var listaOrdens = new OrdemServicoService().listOrdemServico();

            return View(listaOrdens); // view criada
        }

        public ActionResult DetalheOrdem(int id) // detalhes da ordem passada ok
        {
            var buscarOrdem = new OrdemServicoService().buscarOrdemServico(id);
            return View(buscarOrdem);  // view criada
        }

        public ActionResult CadastrarNovaOrdem() // chamar tela de cadastro ok
        {
            return View(); // view criada
        }

        [HttpPost]
        public ActionResult CadastrarNovaOrdem(OrdemServicoDTO ordemDTO) // receber objeto para gravar
        {
            if (ordemDTO != null)
            {
                var gravarOrdem = new OrdemServicoService();
                gravarOrdem.savarOrdemServico(ordemDTO);
            }
           // return RedirectToAction("detalheOrdem"); // passar o id da ordem cadastrada
            return RedirectToAction("ListarTodasOrdens");
        }

        public ActionResult EditarOrdemServico(int id)  // receber id do obj selecionado, buscar e mostrar na tela
        {
            var buscarOrdem = new OrdemServicoService().buscarOrdemServico(id);
            return View(buscarOrdem);  // view criada
        }

        [HttpPost]
        public ActionResult EditarOrdemServico(OrdemServicoDTO ordemDTO) // receber o obj editado e gravar
        {
            if (ordemDTO != null)
            {
                var  atualizarOrdem = new OrdemServicoService();
                atualizarOrdem.savarOrdemServico(ordemDTO);
            }

            return RedirectToAction("detalheOrdem"); // jogar para a tela de detalhes depois de gravar a edicao
        }

	}
}