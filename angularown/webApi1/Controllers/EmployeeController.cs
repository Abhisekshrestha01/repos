using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webApi1.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (testloginEntities entities = new testloginEntities())
            {
                return entities.Employees.ToList();
            }
        }
        public Employee Get(string code)
        {
            using (testloginEntities entities = new testloginEntities())
            {
                return entities.Employees.FirstOrDefault(e => e.code == code);
            }
        }
    }
}
