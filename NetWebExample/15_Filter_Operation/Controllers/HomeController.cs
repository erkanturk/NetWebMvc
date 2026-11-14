using _15_Filter_Operation.Filters;
using _15_Filter_Operation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace _15_Filter_Operation.Controllers
{
    public class HomeController(ILogger<HomeController> logger) : Controller
    {
        [ServiceFilter(typeof(ActionFilter))]
        public IActionResult Index()
        {
            logger.LogInformation("Index action çalışıyor (filtreden önce ve sonra logları arasında)");
            return View();
        }
        [ServiceFilter(typeof(AuthorizationFilter))]
        public IActionResult Privacy()
        {
            return View();
        }
        [ServiceFilter(typeof(ExceptionFilter))]
        public IActionResult SpecialAction()
        {
            throw new InvalidOperationException("Test hatası");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
