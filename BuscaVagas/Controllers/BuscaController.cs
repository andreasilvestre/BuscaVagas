using BuscaVagas.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

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

            return View();
        }

        // GET: BuscaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

       

        // POST: BuscaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>  Busca(IFormCollection collection)
        {
            //adaptar e filtrar conforme os dados selecionados pelo usuario

            var buscaVagasContext = _context.Vaga.Include(v => v.Empresa);
            return View(await buscaVagasContext.ToListAsync());
        }
      
    }
}
