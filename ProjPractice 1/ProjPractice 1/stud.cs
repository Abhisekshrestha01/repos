using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjPractice_1
{
    class stud
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }

        public static List<stud> GetAllStudents()
        {
            List<stud> listStudents = new List<stud>
        {
            new stud
            {
                StudentID= 101,
                Name = "Tom",
                TotalMarks = 800
            },
            new stud
            {
                StudentID= 102,
                Name = "Mary",
                TotalMarks = 900
            },
            new stud
            {
                StudentID= 103,
                Name = "Valarie",
                TotalMarks = 800
            },
            new stud
            {
                StudentID= 104,
                Name = "John",
                TotalMarks = 800
            },
        };

            return listStudents;
        }
    }
}
