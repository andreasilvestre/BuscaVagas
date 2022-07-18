using Microsoft.AspNetCore.Mvc;

namespace BuscaVagas.Controllers
{
    public class BuscaController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        // GET: BuscaController
        public ActionResult Index()
        {
            //tu vai consultar no banco ´para retornar para a VIEW os dados necessarios
            //orientação Fabricio

            //select distinct cargo, nivel, tecnologia, cidade from vaga;

            return View();

        }


        //// POST: BuscaController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Busca(IFormCollection collection)
        //{
        //    //adaptar e filtrar conforme os dados selecionados pelo usuario

        //    //var buscaVagasContext = _context.Vaga.Include(v => v.Empresa);
        //    //return View(await buscaVagasContext.ToListAsync());
        //}


    }
}
