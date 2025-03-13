using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyCVWebsite.Models;

namespace MyCVWebsite.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            var model = new ProjectsViewModel
            {
                Title = "Projects",
                Projects = new List<Project>
                {
                    new Project { Name = "My CV Website", Description = "This webpage that you are looking at right now on git using MVC", Link = "https://github.com/PECDigitalSolutions/MyCVWebsite" },
                    new Project { Name = "PEC Wheel Alignment App", Description = "A test app i created for wheel alignment in react using expo", Link = "https://github.com/PECDigitalSolutions/PECWheelAlignmentApp" },
                    new Project { Name = "My Website in html/css/js", Description = "My other CV that i created before this and uploaded and hosted on git using only html, css and a touch of js", Link = "https://github.com/PECDigitalSolutions/MyCVWebsite" },
                    new Project { Name = "My Wheel Alignment API", Description = "My wheel alignment .NET core project for getting data from DnB and connecting to my database", Link = "https://github.com/PECDigitalSolutions/HjulinstallningAPI" }
                }
            };
            return View(model);
        }
    }
}
