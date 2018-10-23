using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvclogin.Models;

namespace mvclogin.Controllers
{
    public class AddUserController : Controller
    {
        DataContext dbc = new DataContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Login login)
        {
            if (ModelState.IsValid)
            {
                
                dbc.logins.Add(login);
                dbc.SaveChanges();
                return RedirectToAction("Index","Login");
            }
            return View(login);
            
        }
    }
}