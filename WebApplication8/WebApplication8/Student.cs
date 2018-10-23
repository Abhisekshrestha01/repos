using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication8
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public static List<Student> GetAllStudent()
        {
            List<Student> listStudent = new List<Student>();
            Student S1 = new Student()
            {
                Id = 101,
                Name = "Mark",
                Gender = "Male"
            };
            listStudent.Add(S1);
            Student S2 = new Student()
            {
                Id = 102,
                Name = "Mary",
                Gender = "Female"
            };
            listStudent.Add(S2);
            Student S3 = new Student()
            {
                Id = 103,
                Name = "John",
                Gender = "Male"
            };
            listStudent.Add(S3);
            Student S4 = new Student()
            {
                Id = 104,
                Name = "Steve",
                Gender = "Male"

            };
            listStudent.Add(S4);
            Student S5 = new Student()
            {
                Id = 105,
                Name = "Pam",
                Gender = "Female"

            };
            listStudent.Add(S5);
        

            return listStudent;
        }
    }
}