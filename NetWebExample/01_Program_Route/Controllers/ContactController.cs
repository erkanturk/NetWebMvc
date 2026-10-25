using Microsoft.AspNetCore.Mvc;

namespace _01_Program_Route.Controllers;

[Route("iletisim")]
[Route("[controller]")]
public class ContactController:Controller
{
    [Route("")]
    [Route("[action]")]
    public IActionResult Index()
    {
        return View();
    }
}
