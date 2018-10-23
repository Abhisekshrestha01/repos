using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication19.Models
{
    public class EmployeeDBcontext : DbContext
    {
        public DbSet<EmployeeClass> Employees { get; set; }
    }
}