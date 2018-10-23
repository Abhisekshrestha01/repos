using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication11practiceTwo
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Employees> Employees { get; set; }
    }
}