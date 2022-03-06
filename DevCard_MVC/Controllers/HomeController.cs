using DevCard_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
           
        }

        public IActionResult Index()
        {
            var model = new ContactModel();
            return View(model);
        }

     
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }


        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    ///var name = form["name"];
        //    return Json(Ok());
        //}


        [HttpPost]
        public JsonResult Contact(ContactModel contact)
        {
            Console.WriteLine(contact.ToString());
            return Json(Ok());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
