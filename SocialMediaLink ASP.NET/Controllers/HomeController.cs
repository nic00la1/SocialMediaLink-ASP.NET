using Microsoft.AspNetCore.Mvc;

namespace SocialMediaLink_ASP.NET.Controllers;

public class HomeController : Controller
{
    [Route("/")]
    public IActionResult Index()
    {
        return View();
    }
}
