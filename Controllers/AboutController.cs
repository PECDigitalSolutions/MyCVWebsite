using Microsoft.AspNetCore.Mvc;

namespace MyCVWebsite.Controllers;

public class AboutController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "About Me";
        ViewData["Skills"] = new List<string> { "C#", "ASP.NET Core", "Entity Framework Core", "JavaScript" };
        return View();
    }
}
