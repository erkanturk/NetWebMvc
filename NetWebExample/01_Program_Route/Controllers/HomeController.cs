
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _01_Program_Route.Controllers
{
    /* Controller:Gelen isteği karşılayan sınıf. Sınıf adı "Controller" ile bitmeli ve Controller'dan türemeli
     * Adres sınıf Method eşleşmesi:Home/Index HomeController sınıfındaki index methodu tarafından bana
     * Bir sayfa dönderileceğini belirtir.
     */
    public class HomeController : Controller
    {
        /*Action:dışarıya açık public  ve sonuç (IActionResult) dönderen method
         * bir aksiyon olay sonucunda bir değer gösterir
         * View() Views/Home/Index.cshtml dosyalarını bulur html üretip tarayıcıda çalıştırır
         */
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

    }
}
