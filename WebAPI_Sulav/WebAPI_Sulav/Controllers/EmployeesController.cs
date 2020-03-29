using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Sulav.Services;
using WebAPI_Sulav.Models;

namespace WebAPI_Sulav.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {

        public IActionResult GetEmployee()
        {
            List<Employees> names = new List<Employees>();
            DataTable dt = new DataTable();
            dt = DataUtile.Getdata();
            foreach (DataRow dr in dt.Rows)
            {
                names.Add(new Employees()
                {
                    Employeeid = Convert.ToInt32(dr["EmployeeId"]),
                    FirstName = dr["FirstName"].ToString(),
                    LastName = dr["LastName"].ToString(),
                    Gender = dr["Gender"].ToString(),
                    Hiredate = dr["HireDate"].ToString(),
                    Email = dr["Email"].ToString()
                });
               
            }
            return Ok(names);
        }
    }
}