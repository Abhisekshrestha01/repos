using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCProject.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage ="Please enter student name.")]
        public string StudentName { get; set; }
        [Range(5,50)]
        public int StudentAge { get; set; }
    }
}