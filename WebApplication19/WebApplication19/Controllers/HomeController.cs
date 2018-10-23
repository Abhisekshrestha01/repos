using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication19.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Countries"] = new List<string>(){
                "India",
                "US",
                "Australia",
                "Canada"
            };
            return View();
             

        }

        public string GetDetails()
        {
            return "MVC Demo Get detail";
        }


    }
}