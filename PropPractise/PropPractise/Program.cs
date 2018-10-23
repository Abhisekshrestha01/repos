using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropPractise
{
    public class Student
    {
        private int _id;
        private string _Name;
        private int _passMark = 35;

        public void SetID(int Id)
        {
            if(Id <=0 )
            {
                throw new Exception("Student Id cannot be negative");
            }
            this._id = Id;
        }
        public int GetId()
        {
            return this._id;
        }
        public void SetName(string Name)
        {
            if(string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name cannot be Empty");
            }
            this._Name = Name;
        }
        public string GetName()
        {
            return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
        } 
        public int GetPassMark()
        {
            return this._passMark;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student C1 = new Student();
            C1.SetID(101);
            C1.SetName("Abhisek");

            Console.WriteLine("Student Id = {0}, Name = {1}, PassMark = {2}",C1.GetId(), C1.GetName(), C1.GetPassMark());
        }
    }
}
