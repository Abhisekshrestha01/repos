using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class APIResponse
    {
        private static APIResponse instance = null;
        public static APIResponse GetInstance()
        {
            instance = new APIResponse();
            return instance;
        }

        public int Status { get; set; }

        public string Message { get; set; }

        public System.Xml.Linq.XElement Data
        { get; set; }

    }
}