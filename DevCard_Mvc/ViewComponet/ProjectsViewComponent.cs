
using System.Collections.Generic;
using DevCard_Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_Mvc.ViewComponet
{
    public class ProjectsViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>()
            {
                 new Project(1,"تاکسی  ", "درخواست تاکسی برای سفر های درون شهری ","project-1.jpg","milad"),
                 new Project(2,"زودفود  ", "درخواست انلاین غذا  ","project-2.jpg","ZoodFood"),
                 new Project(3,"مدارس   ", "سیستم مدیریت یکپارچه مدارس   ","project-3.jpg","Monop"),
                 new Project(4,"فضا پیما  ", "برنامه مدیریت فضا پیما های ناسا   ","project-4.jpg","Nasa"),
            };

            return View("_Projects",projects);
        }
    }
}
