using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCvidly.Models;

namespace MVCvidly.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> cslist = new List<Customer>
        {

            new Customer
        {
            Id = 1,
            Name = "John Smith"
        },
        new Customer
        {
            Id = 2,
            Name = "Mary Willams"
        }
};
        public ActionResult Index()
        {
            return View(cslist);
        }
        public ActionResult Details(int id)
        {
            
            return Content(cslist.FirstOrDefault(x => x.Id == id).Name);
        }
    }
}