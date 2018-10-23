using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCheckBox.Models;
using System.Text;

namespace MvcCheckBox.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            EmployeesContext employeEContext = new EmployeesContext();
            return View(employeEContext.Cities);
        }

        [HttpPost]
        public string Index(IEnumerable<City> cities)
        {
            if(cities.Count(n => n.IsSelected)==0)
            {
                return "You sisno tselect any city";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("You selected - ");
                foreach(City city in cities)
                {
                    if(city.IsSelected)
                    {
                        sb.Append(city.Name + " , ");
                    }
                }
                sb.Remove(sb.ToString().LastIndexOf(","), 1);
                return sb.ToString();
            }
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}