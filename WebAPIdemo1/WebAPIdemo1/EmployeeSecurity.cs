using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataCOnnect;

namespace WebAPIdemo1
{
    public class EmployeeSecurity
    {
        private dataEntities db;
        public EmployeeSecurity()
        {
            this.db = new dataEntities();
        }
        public bool login(string username, string password)
        {
            return db.logins.Any(n => n.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && n.Password == password);
           


        }
    }
}