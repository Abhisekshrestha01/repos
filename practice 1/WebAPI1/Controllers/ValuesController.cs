using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI1.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public static List<string> strlist = new List<string>()
        {
            "value1", "value2", "value3"
        };
        public IEnumerable<string> Get()
        {
            return  strlist;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return strlist[id];
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            strlist.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            strlist[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            strlist.RemoveAt(id);
        }
    }
}
