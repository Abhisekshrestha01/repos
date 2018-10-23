using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication12
{
    public class EmployeeDBcontext : DbContext
    {
        public DbSet<Department> Department { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}