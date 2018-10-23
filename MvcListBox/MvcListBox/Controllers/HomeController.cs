using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcListBox.Models;
using System.Text;

namespace MvcListBox.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        { 
            
            EmployeeeContext db = new EmployeeeContext();
            List<SelectListItem> listSelectListItem = new List<SelectListItem>();
            foreach(City city in db.Cities)
            {
                SelectListItem selectListItem = new SelectListItem()
                {
                    Text = city.Name,
                    Value = city.ID.ToString(),
                    Selected = city.IsSelected
                };
                listSelectListItem.Add(selectListItem);
            }
            CityViewModel cityViewModel = new CityViewModel();
            cityViewModel.Cities = listSelectListItem;
            return View(cityViewModel);
        }


        [HttpPost]
        public string Index(IEnumerable<string> selectedCities)
        {
            if(selectedCities == null)
            {
                return "You did not select any City";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("You selected - " + string.Join(",", selectedCities));
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