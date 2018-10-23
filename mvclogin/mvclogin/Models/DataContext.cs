using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvclogin.Models
{
    public class DataContext:DbContext
    {
        public DbSet<Login> logins { get; set; }
    }
}