using BLL;
using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace OnlineElection.Controllers
{
    public class NotificationController : Controller
    {
        NotificationManager _notificationManager = null;
        UserManager _userManager = null;

        public NotificationController()
        {
            _notificationManager = new NotificationManager();
            _userManager = new UserManager();

        }
        // GET: Notification
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetAllNotification()
        {
            int userId =  _userManager.GetAll().FirstOrDefault(x=>x.email== User.Identity.Name).userId ;
            var list=_notificationManager.GetAllUnSeenNotification(userId).Select(x=>new Notification {
                message=x.message,
                url=x.url,
                unseen=x.unseen
            });
           
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}