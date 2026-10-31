using _04_ViewData_ViewBag_TempData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _04_ViewData_ViewBag_TempData.Controllers
{
    public class HomeController : Controller
    {
        /* ViewData: Sözlük (key-value) Sadece o istek için geçerlidir Okurken cast gerekir 
         * ViewBag: Dinamik bir yapıdadır içerisinde bir çok değeri barındırır tek istek için geçerlidir.
         * TempData:2 Action result boyunca çalışır key value ilişkisi vardır Okununca bu veri silinir
         * Keep ile korunur Peek ile gösterilir.
         */
        public IActionResult Index()
        {
            ViewBag.ad = "Erkan";
            ViewBag.liste = new List<object> { "ABC", 10, 'B' };
            ViewBag.sonuc = true;

            ViewData["soyad"] = "Türk";
            TempData["cinsiyet"] = "Erkek";
            TempData.Keep("cinsiyet");//Cinsiyet bilgisi okunsada silme
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.text = ViewBag.ad;
            TempData["c"] = TempData["cinsiyet"];
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
