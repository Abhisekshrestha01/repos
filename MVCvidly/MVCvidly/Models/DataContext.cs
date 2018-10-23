using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVCvidly.Models;

namespace MVCvidly.Models
{
    public class DataContext:DbContext
    {
        public DbSet<Customer> customers { get; set; }

    }
}