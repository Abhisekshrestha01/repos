using System;
using System.Collections.Generic;

namespace NetCoreAPI.Model
{
    public partial class Employees
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime? HireDate { get; set; }
        public string Email { get; set; }
    }
}