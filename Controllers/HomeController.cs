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
        /// <summary>
        /// Retorna a página inicial
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        /// <summary>
        /// Retorna a página de gerenciarTabelas
        /// </summary>
        /// <returns></returns>
        public IActionResult gerenciarTabelas() 
        {
            return View();
        }

        /// <summary>
        /// Comunica com o model para ler o arquivo de classes
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public Resumo CarregarItens()
        {
            Resumo itens = new Resumo();
            Resumo classes = itens.lerClasses();
            return classes;
        }

        /// <summary>
        /// Comunica com  o model para salvas as classes no arquivo
        /// </summary>
        /// <param name="resumo"></param>
        /// <param name="origens"></param>
        [HttpPost]
        public void SalvarTabelas(List<string> resumo, List<string> origens){
            Resumo classes = new Resumo();
            classes.Resumos = resumo;
            classes.Origens = origens; 
            classes.salvarClasses();
        }

        public bool AutenticarSenha(string senha)
        {
            if (senha == "senha dificil@adm")
                return true;

            return false;
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
