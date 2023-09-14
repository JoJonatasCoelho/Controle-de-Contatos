using Microsoft.AspNetCore.Mvc;
using Primeiro_Site.Models;
using System.Diagnostics;

namespace Primeiro_Site.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            HomeModel usuario = new HomeModel();
            usuario.Nome = "John";
            usuario.Email = "slamano252@gmail.com";

            return View(usuario);
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