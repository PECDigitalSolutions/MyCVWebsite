using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyCVWebsite.Models;

namespace MyCVWebsite.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["WelcomeMessage"] = "Welcome to My CV Website!";
        ViewData["RecentClients"] = new List<string> { "ITAB", "Ammizing.se" };
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
