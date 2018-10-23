using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Custumer[] customer = new Custumer[3];
            customer[0] = new Custumer
            {
                Name = "Mark",
                Gender = Gender.Male
            };
            customer[1] = new Custumer
            {
                Name = "Mary",
                Gender = Gender.Female
            };
            customer[2] = new Custumer
            {
                Name = "Sam",
                Gender = Gender.Unknown
            };
            foreach (Custumer cust in customer)
            {
                Console.WriteLine("Name = {0} && Gender = {1}", cust.Name, GetGender(cust.Gender));
            }

        }
        public static string GetGender(Gender gender)
        {
            switch(gender)
            { 
                case Gender.Unknown:
                    return "unknown";
                    
                case Gender.Male:
                    return "Male";
                    
                case Gender.Female:
                    return "Female";

                default:
                    return "Invalid data detected";
            }
        }
    }

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }




    public class Custumer
    {
        public string Name { set; get; }
        public Gender Gender { set; get; }
    }
}
