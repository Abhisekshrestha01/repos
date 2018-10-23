using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication11practiceTwo
{
    public class EmployeeDBcontext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employees> Employees { get; set; }
    }
}