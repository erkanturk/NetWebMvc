using _03_ViewToController.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _03_ViewToController.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken] //CSRF koruması  
        public IActionResult Index(string ad,string kisiler,bool onay=false)
        {
            ViewBag.Mesaj = $"Ad:{ad},Seçilen:{kisiler},Onay:{(onay ? "Evet" : "Hayır")}";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
