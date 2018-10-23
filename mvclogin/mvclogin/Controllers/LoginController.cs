using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvclogin.Models;

namespace mvclogin.Controllers
{
    public class LoginController : Controller
    {
        DataContext dbc = new DataContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Authentication(Login login)
        {
            if (ModelState.IsValid)
            {
                Login log = dbc.logins.Where(x => x.Username == login.Username && x.Password == login.Password).FirstOrDefault();
                if(log == null)
                {
                    return View();
                }
                else
                {
                    Session["Username"] = login.Username;
                    Session["Password"] = login.Password;
                    return RedirectToAction("HomePage", "HomePage");
                }
            }
            return RedirectToAction("Index");
            
            
        }
    }
}