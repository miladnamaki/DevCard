
using System.Collections.Generic;
using DevCard_Mvc.Data;
using DevCard_Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_Mvc.ViewComponet
{
    public class ProjectsViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = ProjectStore.GetProjects();


            return View("_Projects",projects);
        }
    }
}
