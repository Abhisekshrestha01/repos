using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication10
{
    public class EmployeeDBcontext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employees> Employee { get; set; }
    }
}