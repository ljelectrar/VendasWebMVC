using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMvc.Models;
using VendasWebMvc.Models.ViewModels;

namespace VendasWebMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Isto é um aplicativo de vendas";
            ViewData["Professor"] = "Leandro Junior Alves Dos Santos";
            ViewData["Email"] = "ljelectrar@outlook.com";
            ViewData["Site"] = "www.ljelectrar.com";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contato";
            ViewData["Site"] = "www.ljelectrar.com";
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
