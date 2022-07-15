using BuscaVagas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BuscaVagas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Empresa empresa = new Empresa();
            //empresa.Nome = "Atos Brasil Soluções";
            //empresa.Email = "ana_carolina@atos.com.br";
            //empresa.Telefone = "35-99892-6483";

            //return View(empresa);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}