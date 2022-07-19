using BuscaVagas.Data;
using BuscaVagas.Models;
using Microsoft.AspNetCore.Mvc;

namespace BuscaVagas.Controllers
{
    public class BuscaController : Controller
    {
        private readonly BuscaVagasContext _context;

        public BuscaController(BuscaVagasContext context)
        {
            _context = context;
        }


        // GET: BuscaController
        public ActionResult Index()
        {
            //tu vai consultar no banco ´para retornar para a VIEW os dados necessarios
            //orientação Fabricio

            //select distinct cargo, nivel, tecnologia, cidade from vaga;

            return View();

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(BuscaVaga buscaVaga)
        {
           return View(Resultado(buscaVaga));

        }

        [HttpPost]
        public async Task<IActionResult> Resultado(BuscaVaga buscaVaga)
        {

            List<Vaga> vagas = _context.Vaga.Where(b => b.Cargo == buscaVaga.Cargo 
            && b.Nivel == buscaVaga.Nivel 
            && b.Tecnologia == buscaVaga.Tecnologia 
            && b.Cidade == buscaVaga.Cidade).ToList();

            return View(vagas);
        }

    }
}
