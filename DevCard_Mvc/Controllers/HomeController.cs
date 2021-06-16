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
            if (!ModelState.IsValid)
            {
                ViewBag.error = " اطلاعات وارد شده صحیح نیست ، لطفا دوباره تلاش کنید!";
                return View(form);
            }

            ViewBag.Success= "پیغام شما با موفقت ارسال شد با تشکر ";
            return View();
            //return RedirectToAction("Index");

        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
