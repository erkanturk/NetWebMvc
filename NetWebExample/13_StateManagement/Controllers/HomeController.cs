using _13_StateManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _13_StateManagement.Controllers
{
    /*HTTP durumsuzdur (stateless) her istek birbirinden bağımsızdır Kullanıcıyı hatırlamak için
     * Session (oturum): Veri sunucuda tutulur tarayıcıya sadece bir oturum kimliği cerezi gider.
     * Kullanıcıya özel geçici veri için (sepet,giriş bilgisi vb) tarayıcı içeriği göremez
     * Bellek içi  sağlayıcıda uygulama yeniden başlayınca silinir.
     * 
     * Cookie(çerez): Veriler tarayıcıda tutulur her istekte sunucuya geri gelir
     * Kullanıcı okuyabilir ve değiştirebilir hassas veriler gönderilmemesi gerekir.
     */
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("UserName", "Erkan Türk");

            var ziyaret = (HttpContext.Session.GetInt32("ZiyaretSayisi") ?? 0) +1;//Null ise bunu yap ??
            HttpContext.Session.SetInt32("ZiyaretSayisi", ziyaret);

            var cookieOptions = new CookieOptions
            {
                Expires = DateTimeOffset.UtcNow.AddMinutes(30),//30 dakika sonra tarayıcı veriyi siler
                HttpOnly= true,//Http isteklerine cevap ver
                Secure= true, //istekler Https tarafından gelecek.
                SameSite=SameSiteMode.Lax, //Başka siteden gelen istekleri bildir.
                IsEssential=true //çerez onayı olmasada yazılır.

            };
            Response.Cookies.Append("UserName", "Erkan Türk", cookieOptions);
            ViewBag.SessionUserName = HttpContext.Session.GetString("UserName");
            ViewBag.CookieUserName = Request.Cookies["UserName"];
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.SessionUserName = HttpContext.Session.GetString("UserName");
            ViewBag.ZiyaretSayisi = HttpContext.Session.GetInt32("ZiyaretSayisi");
            ViewBag.CookieUserName = Request.Cookies["UserName"];
            return View();
        }

        public IActionResult Temizle()
        {
            HttpContext.Session.Clear();
            Response.Cookies.Delete("UserName");
            return RedirectToAction(nameof(Privacy));
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
