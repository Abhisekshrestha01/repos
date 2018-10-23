using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using EmployeeAccess;

namespace WEBapipractice.Controllers
{
    public class EmployeesController : ApiController
    {
        [BasicAuthentication]
        public HttpResponseMessage Get(string gender = "All")
        {
            string username = Thread.CurrentPrincipal.Identity.Name;
            using (EmployeesEntities entities = new EmployeesEntities())
            {
                switch(username.ToLower())
                {
                    case "all":
                        return Request.CreateResponse(HttpStatusCode.OK, entities.tblEmployees.ToList());
                    case "male":
                        return Request.CreateResponse(HttpStatusCode.OK, entities.tblEmployees.Where(emp => emp.Gender.ToLower() == "male").ToList());
                    case "female":
                        return Request.CreateResponse(HttpStatusCode.OK, entities.tblEmployees.Where(emp => emp.Gender.ToLower() == "female").ToList());
                    default:
                        return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
                
            }
        }
        public HttpResponseMessage Get(int id)
        {
            using (EmployeesEntities entities = new EmployeesEntities())
            {
                var entity =  entities.tblEmployees.FirstOrDefault(e => e.EmployeeId == id);
                if(entity != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, entity);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with Id " + id.ToString() + " not found");
                }
            }
        }
        public HttpResponseMessage Post([FromBody] tblEmployee employee)
        {
            try
            {
                using (EmployeesEntities entites = new EmployeesEntities())
                {
                    entites.tblEmployees.Add(employee);
                    entites.SaveChanges();
                    var message = Request.CreateResponse(HttpStatusCode.Created, employee);
                    message.Headers.Location = new Uri(Request.RequestUri + employee.EmployeeId.ToString());
                    return message;
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
            
        }
        public void Delete(int id)
        {
            using (EmployeesEntities entities = new EmployeesEntities())
            {
                entities.tblEmployees.Remove(entities.tblEmployees.FirstOrDefault(e => e.EmployeeId == id));
                entities.SaveChanges();
            }
        }
        public HttpResponseMessage Put(int id, tblEmployee emp)
        {
            try
            {
                using (EmployeesEntities entities = new EmployeesEntities())
                {
                    var entity = entities.tblEmployees.FirstOrDefault(e => e.EmployeeId == id);

                    if(entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with Id =" + id + " not found to update");
                    }
                    else
                    {
                        entity.Name = emp.Name;
                        entity.City = emp.City;
                        entity.Gender = emp.Gender;
                        entity.DepartmentId = emp.DepartmentId;
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, entity);
                    }
                    

                    
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
            
        }

    }
}
