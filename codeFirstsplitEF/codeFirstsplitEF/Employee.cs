﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codeFirstsplitEF
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        // These property values should be stored in EmployeeContactDetails Table
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Landline { get; set; }
    }
}