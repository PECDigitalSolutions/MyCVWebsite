using Microsoft.AspNetCore.Mvc;

namespace MyCVWebsite.Controllers;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Contact";
        return View();
    }

    [HttpPost]
    public IActionResult Index(string name, string email, string message)
    {
        // Handle form submission logic here
        // For example, send an email or save the message to a database

        ViewData["Title"] = "Contact";
        ViewData["Message"] = "Thank you for your message!";
        return View();
    }
}
