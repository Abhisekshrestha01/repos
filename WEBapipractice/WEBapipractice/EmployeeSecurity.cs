using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeAccess;

namespace WEBapipractice
{
    public class EmployeeSecurity
    {
        public static bool Login(string username, string password)
        {
            using (EmployeesEntities entities = new EmployeesEntities())
            {
                return entities.Users.Any(user => user.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && (user.Password == password));
            }
        }
    }
}