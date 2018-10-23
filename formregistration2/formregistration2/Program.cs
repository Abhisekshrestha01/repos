using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formregistration2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string fname = null;
                string lname = null;
                string city = null;
                bool isnum = false;
                int age = 0;
                string email = null;
                
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("************************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("    The detail of the Employee is:");
                Console.WriteLine("    Full Name : {0} {1}", fname, lname);
                Console.WriteLine("    City : {0}", city);
                Console.WriteLine("    Age : {0}", age);
                Console.WriteLine("    Email : {0}", email);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("************************************");
                Console.ForegroundColor = ConsoleColor.White;
            }


        }

        public static void PrintMessage(string st)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(st);
            Console.ForegroundColor = ConsoleColor.White;

        }
        public static Boolean IsAlpha(string a)
        {
            if (string.IsNullOrEmpty(a))
                return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (!char.IsLetter(a[i]))
                    return false;
            }
            return true;
        }

        public static Boolean Validatemail(string s)
        {
            string expression;
            expression = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]*";
            var regex = new Regex(expression, RegexOptions.IgnoreCase);
            return regex.IsMatch(s);
        }
    }
    public class Register
    {
        Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Please Register yourself in the System");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");
                do
                {
                    if (fname != null)
                    {
                        PrintMessage("Firstname should not contain other then alphabets and length less then 10 characters");

    }
    Console.WriteLine("Enter the FirstName :");
                    fname = Console.ReadLine();

                } while (!IsAlpha(fname) || (fname.Length > 10));
                do
                {
                    if (lname != null)
                    {
                        PrintMessage("Lastname should not contain other then alphabet and length less then 10 characters");

                    }
                    Console.WriteLine("Enter the Lastname :");
                    lname = Console.ReadLine();
                } while (!IsAlpha(lname) || (lname.Length > 10));
                do
                {
                    if (city != null)
                    {
                        PrintMessage("City name must be a alphabet");

                    }
                    Console.WriteLine("Enter the City :");
                    city = Console.ReadLine();
                } while (!IsAlpha(city));
                do
                {
                    if (age != 0)
                    {
                        PrintMessage("age should be between 10 to 80");

                    }
                    Console.WriteLine("Enter the Age :");
                    isnum = Int32.TryParse(Console.ReadLine(), out age);
                } while (!isnum || (age< 10) || (age > 80));
                do
                {
                    if (email != null)
                    {
                        PrintMessage("Email is not valid");

                    }
                    Console.WriteLine("Enter the Email :");
                    email = Console.ReadLine();
                } while (!Validatemail(email));
    }
}
