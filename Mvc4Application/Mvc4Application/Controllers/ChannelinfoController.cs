using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc4Application.Models;
namespace Mvc4Application.Controllers
{
    public class ChannelinfoController : Controller
    {
        //
        // GET: /Channelinfo/

        public ActionResult Details(int type)
        {

            ChannelDbContext objChnDbContext = new ChannelDbContext();
            MyChannels objChannel = objChnDbContext.Mychannel.Single(chn => chn.ID == type);

            return View(objChannel);
        }
        public ActionResult ChannelDetails()
        {

            ChannelDbContext objChnDbContext = new ChannelDbContext();
            List<MyChannels> lstChannels = objChnDbContext.Mychannel.ToList<MyChannels>();

            return View(lstChannels);
        }

        public ActionResult ChannelDetailList()
        {

            ChannelDbContext objChnDbContext = new ChannelDbContext();
            List<MyChannels> lstChannels = objChnDbContext.Mychannel.ToList<MyChannels>();

            return View(lstChannels);
        }

        [HttpGet]
        public ActionResult CreateChannel()
        {
            return View();
        }


        [HttpPost]
        [ActionName("CreateChannel")]
        public ActionResult CreateChannel_Post()
        {
            if (ModelState.IsValid)
            {
                MyChannels objChannel = new MyChannels();
                UpdateModel(objChannel);
                MyChannelBL objBl = new MyChannelBL();
                objBl.AddChannel(objChannel);

                return RedirectToAction("ChannelDetails");
            } 
            return View();
        }

        /*
         *  [HttpPost]
        public ActionResult CreateChannel(FormCollection objFormCollection)
        {
            MyChannels objChannel = new MyChannels();
            objChannel.Name = objFormCollection["Name"];
            objChannel.Type = objFormCollection["Type"];
            objChannel.Status =true;

            MyChannelBL objBl = new MyChannelBL();
            objBl.AddChannel(objChannel);

            return RedirectToAction("ChannelDetails");
        }
        [HttpPost]
        public ActionResult CreateChannel(string Name, string Type)
        {
            MyChannels objChannel = new MyChannels();
            objChannel.Name = Name;
            objChannel.Type = Type;
            objChannel.Status = true;
            MyChannelBL objBl = new MyChannelBL();
            objBl.AddChannel(objChannel);

            return RedirectToAction("ChannelDetails");
        }*/
    }
}
