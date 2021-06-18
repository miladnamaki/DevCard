using System;
using DevCard_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using DevCard_Mvc.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_Mvc.Controllers
{
    public class HomeController : Controller
    {

        private readonly List<Services> _services = new List<Services>
        {
            new Services(1,"نقره ای "),
            new Services(2,"طلایی "),
            new Services(3,"پلاتین "),
            new Services(4,"الماس "),

        };

        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        //vaghti mikhaym etelato az az contorl befrestim be claient mishe HttpGetAttribute 
        public IActionResult Contact()
        {
            var model = new SendContect
            {
                servicees = new SelectList(_services,"Id","Name")
            };
          
            return View(model); 
        }
        public IActionResult ProjectDetails(long id)
        {
            var project = ProjectStore.GetProjectBy(id);
            return View(project);
        }


        //}
        //[HttpPost]
        //vaghti mikhaym az form etelate befrestim be control mishe post
        //public  JsonResult Contact(IFormCollection from )      2=vaghti daghighan nemidonim fildamon chian 
        //{
        //    var Name = from["name"];

        //    return Json(Ok());
        //}
        //[HttpPost]
        //public JsonResult Contect(SendContect from)      1= modelbinding az tarighe contect class anjam mishe
        //                                                      vaghti middonim che fildaie niaz darim

        //{
        //    Console.WriteLine(from.ToString());

        //    return Json(Ok());

        //}
        [HttpPost]
            public IActionResult Contact(SendContect form)
            {
                form.servicees = new SelectList(_services, "Id", "Name");
            if (!ModelState.IsValid)
                {
                    ViewBag.error = " اطلاعات وارد شده صحیح نیست ، لطفا دوباره تلاش کنید!";
                  
                    return View(form);
                }
                     form = new SendContect()
                     {
                                servicees = new SelectList(_services, "Id", "Name")
                     };
                     ViewBag.Success = "پیغام شما با موفقت ارسال شد با تشکر ";
            ModelState.Clear();//pak mikone foromo
               
                return View(form);
                //return RedirectToAction("Index");
            }


            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }

        }
}
