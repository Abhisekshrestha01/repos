﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstBridge
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public IList<StudentCourse> StudentCourses { get; set; }
    }
}