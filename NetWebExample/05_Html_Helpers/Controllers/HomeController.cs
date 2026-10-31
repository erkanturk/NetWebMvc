using _05_Html_Helpers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace _05_Html_Helpers.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]//Her action result varsayılan olarak get çalışır.
        public IActionResult Index()
        {
            var user = new Users { Name = "Erkan", CountryList = GetCountries() };   
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]//Crsf
        public IActionResult Submit(Users users)
        {
            if (!ModelState.IsValid)
            {
                users.CountryList = GetCountries();
                return View("Index", users);
            }
            ViewBag.Message = $"Ad:{users.Name},Yaş:{users.Age},Cinsiyet:{users.Gender},Ülke:{users.Country}";
            
            return View("Result");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //IEnumarable sıra ile gezilebilmesini sağlar.
        private static IEnumerable<SelectListItem> GetCountries() =>
            [
                new SelectListItem("Türkiye","TR"),
                new SelectListItem("USA","US"),
                new SelectListItem("Japonya","JP"),
            ];
    }
}
