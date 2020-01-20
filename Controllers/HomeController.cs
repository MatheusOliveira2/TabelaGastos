using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using gastos.Models;


namespace gastos.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult gerenciarTabelas() 
        {
            return View();
        }


        [HttpPost]
        public string CarregarItens()
        {
            Resumo itens = new Resumo();
            itens.lerClasses();
            return "Retornou";
        }

        [HttpPost]
        public void SalvarTabelas(List<string> resumo, List<string> origens){
            Resumo classes = new Resumo();
            classes.Resumos = resumo;
            classes.Origens = origens; 
            classes.salvarClasses();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
