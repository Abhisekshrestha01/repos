using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropPractice2
{

    public class Student
    {
        private int _id;
        private string _Name;
        private int _passMark = 35;
        

        public string City
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;

        }
        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student Id cannot be negative");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
            
        }
       
        
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be Empty");
                }
                this._Name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
            }
           
        }
        
        public int Mark
        {
            get
            {
                return this._passMark;
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student C1 = new Student();
            C1.Id = 101;
            C1.Name = "Abhisek";

            Console.WriteLine("Student Id = {0}, Name = {1}, PassMark = {2}", C1.Id, C1.Name, C1.Mark);
        }
    }
}
