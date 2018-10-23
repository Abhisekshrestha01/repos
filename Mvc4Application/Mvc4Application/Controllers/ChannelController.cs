using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc4Application.Controllers
{
    public class ChannelController : Controller
    {
       

        public ViewResult Types()
        {
            ViewBag.ChannelType = new List<string>()
            {
                "Device",
                "Database",
                "API",
                "Files"
            };
            return View();
        }
        public ViewResult ChannelType()
        {
            ViewData["ChannelType"] = new List<string>()
            {
                "Device",
                "Database",
                "API",
                "Files"
            };
            return View();
        }
        public string ChannelName(string type)
        {

            return "Channel type is = " + type;
        }
    }
}
