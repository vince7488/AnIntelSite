using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using WebsiteData;

namespace AnIntelSite.Pages.Projects
{
    public class ListModel : PageModel
    {

        private readonly IConfiguration config;
        private readonly IProjectData projectData;

        public string ProjectsContent { get; set; }

        public ListModel(IConfiguration config,
                         IProjectData projectData)
        {
            this.config = config;
            this.projectData = projectData;
        }

        public void OnGet()
        {
            ProjectsContent = config["ProjectsContent"];
        }
    }
}
