using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using System.Web.Http.Cors;
using DataCOnnect;

namespace WebAPIdemo1.Controllers
{
    [EnableCorsAttribute("*","*","*")]
    public class EmpController : ApiController
    {
        private dataEntities db;

        public EmpController()
        {
            this.db = new dataEntities();
        }
       
        [BasicAuthentication]
        public HttpResponseMessage Get(string gender = "All")
        {
            string username = Thread.CurrentPrincipal.Identity.Name;
            switch(username.ToLower())
            {
                case "male":
                    
                    return Request.CreateResponse(HttpStatusCode.OK, db.Employees.Where(n => n.Gender == "male").ToList());
                   
                case "female":
                    return Request.CreateResponse(HttpStatusCode.OK, db.Employees.Where(n => n.Gender == "female").ToList());

                default:
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
        public HttpResponseMessage Get(int id)
        {
            Employee emp = db.Employees.FirstOrDefault(n => n.ID == id);
            if(emp  != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, emp);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with Id =" + id.ToString() + "not found");
            }
        }
        public HttpResponseMessage Post([FromBody]Employee employee)
        {
            try
            {
                db.Employees.Add(employee);
                db.SaveChanges();

                var message = Request.CreateResponse(HttpStatusCode.Created, employee);
                message.Headers.Location = new Uri(Request.RequestUri + employee.ID.ToString());
                return message;
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
            
        }
        
        public void Delete(int id)
        {
            Employee emp = db.Employees.FirstOrDefault(n => n.ID == id);
            db.Employees.Remove(emp);
            db.SaveChanges();
        }
        public HttpResponseMessage Put(int id, Employee emp)
        {
            try
            {
                Employee employee = db.Employees.FirstOrDefault(n => n.ID == id);

                if (employee != null)
                {
                    employee.FirstName = emp.FirstName;
                    employee.LastName = emp.LastName;
                    employee.Gender = emp.Gender;
                    employee.Salary = emp.Salary;
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, employee);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with Id:" + id + " does not Exist");
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
            
        }
    }
}
