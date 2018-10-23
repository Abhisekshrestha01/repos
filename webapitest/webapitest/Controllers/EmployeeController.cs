using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataAcces;

namespace webapitest.Controllers
{
    public class EmployeeController : ApiController
    {
       
            public IEnumerable<Employee> Get()
            {
                using (test123Entities entities = new test123Entities())
                {
                    return entities.Employees.ToList();
                }
            }

            public Employee Get(int id)
            {
                using (test123Entities entities = new test123Entities())
                {
                    return entities.Employees.FirstOrDefault(e => e.ID == id);
                }
            }
        }
    
}
