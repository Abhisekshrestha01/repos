using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserManagementSystem.Models;

namespace UserManagementSystem.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Login login)
        {
            UserContext db = new UserContext();
            Login lg = db.Logins.Single(n => n.UserName == login.UserName && n.Password == login.Password);
            if (lg!=null)
            {
                return View("HomePage", lg);
            }
            else
            {
                return View();
            }
            
        }

        [HttpGet]
        public ActionResult HomePage()
        {
            return View();
        }


    }
}