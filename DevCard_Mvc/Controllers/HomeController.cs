using System;
using DevCard_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Diagnostics;

namespace DevCard_Mvc.Controllers
{
    public class HomeController : Controller
    {
        

        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            
            return View();
        }
        [HttpGet]
        //vaghti mikhaym etelato az az contorl befrestim be claient mishe HttpGetAttribute 
        public IActionResult Contact()
        {
            var model = new SendContect();

            return View(model);
        }
        [HttpPost]
        //vaghti mikhaym az form etelate befrestim be control mishe post
        //public  JsonResult Contact(IFormCollection from )
        //{
        //    var Name = from["name"];

        //    return Json(Ok());
        //}
        [HttpPost]
        public JsonResult Contect(SendContect from)
        {
            Console.WriteLine(from.ToString());

            return Json(Ok());

        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
