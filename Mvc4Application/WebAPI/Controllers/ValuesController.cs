using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml;
using System.Xml.Linq;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ValuesController : ApiController
    {
       
        [HttpPost]
        public APIResponse SaveUserInfo()
        {
            APIResponse outResp = APIResponse.GetInstance();

            var XDoc = new XmlDocument();
            XDoc.LoadXml("<root><status>200</status><message>User info Saved Successfully</message></root>");
            //   return XDoc;

            outResp.Status = 200;
            outResp.Message = "User info Saved Successfully";

            return outResp;
        }

        [HttpGet]
        public APIResponse GetUserInfo()
        {
            APIResponse outResp = APIResponse.GetInstance();

            var xDoc = new XmlDocument();
            xDoc.Load(System.Web.HttpContext.Current.Server.MapPath("~/cd_catalog.xml"));



            //   return XDoc;
            outResp.Data = XElement.Parse(xDoc.InnerXml);
            outResp.Status = 200;
            outResp.Message = "User Information";

            return outResp;
        }
    }
}
