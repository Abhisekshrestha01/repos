using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entitypractise
{
    public class EmployeeRepository
    {
        private EmployeeDBContext empdb;
        public EmployeeRepository()
        {
            empdb = new EmployeeDBContext();
        }
        public void RegisterEmployee()
        {

        }

    }
}