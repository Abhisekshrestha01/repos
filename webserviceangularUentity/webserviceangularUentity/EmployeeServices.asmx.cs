using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using webserviceangularUentity.Models;

namespace webserviceangularUentity
{
    
    /// <summary>
    /// Summary description for EmployeeServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class EmployeeServices : System.Web.Services.WebService
    {
        DatabaseEntities dbentities = new DatabaseEntities();
        [WebMethod]
        public void GetEmployee()
        {
            var Employee = dbentities.Employees.ToList();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(Employee));
        }
    }
}
