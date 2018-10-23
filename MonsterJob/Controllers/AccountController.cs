using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonsterJob.Models;

namespace MonsterJob.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(UserAccount us)
        {
            if(ModelState.IsValid)
            {
                //Code to save in the address
            }
            return View();
        }
    }
}