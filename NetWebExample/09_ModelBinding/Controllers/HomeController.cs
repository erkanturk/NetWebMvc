using _09_ModelBinding.Models;
using _09_ModelBinding.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _09_ModelBinding.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction(nameof(HomePage));
        }
        [HttpGet]
        public IActionResult HomePage()
        {
            var kisi = new Kisi()
            {
                Ad="Erkan",
                Soyad="Türk",
                Yas=32
            };
            return View(kisi);
        }
        [HttpPost]//Tek bir view 2 methodu kontrol edecek
        public IActionResult HomePage(Kisi kisi)
        {
            ViewBag.Mesaj = $"Formdan gelen:{kisi.Ad} {kisi.Soyad} {kisi.Yas} yaşında";
            return View(kisi);
        }
        public IActionResult HomePage2()
        {
            var viewModel = new HomePageViewModel()
            {
                KisiNesnesi=new Kisi { Ad="Tahsin",Soyad="Canpolat",Yas=36},
                AdresNesnesi=new Adres { AdresTanim="Kadıköy Caferağa",Sehir="İstanbul"}
            };
            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
