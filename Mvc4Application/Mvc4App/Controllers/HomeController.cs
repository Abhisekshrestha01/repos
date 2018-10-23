using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc4App.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public string Index(string type)
        {
            return "Channel type is " + type;
        }

    }
}
