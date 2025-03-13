using System.Collections.Generic;

namespace MyCVWebsite.Models
{
    public class ProjectsViewModel
    {
        public string Title { get; set; } = string.Empty;
        public List<Project> Projects { get; set; } = new List<Project>();
    }
}
