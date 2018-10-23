using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practice_2
{
    public class EmployeeRepository
    {
        private EmployeeDBContest db;
        public EmployeeRepository()
        {
            db = new EmployeeDBContest();
        }

        public List<Department> GetDepartment()
        {
            return db.Departments.Include("Employees").ToList();
        }
    }
}