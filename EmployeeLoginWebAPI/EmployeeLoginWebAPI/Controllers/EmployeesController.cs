using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeLoginWebAPI.Controllers
{
   [Authorize]
    public class EmployeesController : ApiController
    {
        private test123Entities db;
        public EmployeesController()
        {
            db = new test123Entities();
        }
        [HttpGet]
        public IEnumerable<Employee> TotalDate()
        {
            return db.Employees.ToList();
        }
    }
}
