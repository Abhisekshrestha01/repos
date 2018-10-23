using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace FileAsDatabase
{

    class Program
    {

        static void Main(string[] args)
        {
            Class1 cs = new Class1();
            cs.CreateFileIfNotExit();
            int id = cs.GreatestId();
            bool statue = true;
            int detailid = 0;
            bool flag = true;
            List<String> lst = new List<String>();
            while (flag == true)
            {

                Console.WriteLine("Enter \"R\" to Register User, \"V\" to View All, \"D\" to View detail, \"U\" to Update the User, \"Remove\" to Remove User and \"E\" to Exit");
                string operation = Console.ReadLine();
                switch (operation.ToUpper())
                {
                    case "R":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Please Register yourself in the System");
                        Console.ForegroundColor = ConsoleColor.White;
                        InputValue(id, cs);
                        id++;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("You have been successfully registered");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case "V":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("************************************");
                        Console.WriteLine("The details are:");
                        Console.WriteLine("Id\tName\tAge\tPhone");
                        Console.ForegroundColor = ConsoleColor.White;
                        lst = cs.ViewAll();
                        foreach (string us in lst)
                        {
                            Console.WriteLine(us);
                        }
                        break;
                    case "U":
                        Console.WriteLine("Enter the id to update");
                        int uid = int.Parse(Console.ReadLine());

                        bool isfound = cs.Checkid(uid);
                        if (isfound)
                        {
                            DisplayIndividual(uid, cs);
                            Update(uid, cs);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("You have been successfully Update");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.WriteLine("Id does not exits");
                        }
                        break;
                    case "D":
                        do
                        {
                            Console.WriteLine("Enter the detail id:");
                            statue = int.TryParse(Console.ReadLine(), out detailid);
                        } while (statue == false);
                        
                        bool isfind = cs.Checkid(detailid);
                        if (isfind)
                        {
                            DisplayIndividual(detailid, cs);
                        }
                        else
                        {
                            Console.WriteLine("Id does not exits");
                        }

                        break;
                    case "REMOVE":
                        Console.WriteLine("Enter the id to delete");
                        uid = int.Parse(Console.ReadLine());

                        isfound = cs.Checkid(uid);
                        if (isfound)
                        {
                            
                            cs.Delete(uid);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("You have been successfully deleted");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.WriteLine("Id does not exits");
                        }
                        break;
                    case "E":
                        flag = false;
                        break;


                    default:
                        Console.WriteLine("Please Enter the valid Operation");
                        break;
                }


            }



        }
        public static void InputValue(int id, Class1 cs)
        {

            string name = "";
            bool statue1 = true;
            bool statue2 = true;
            int age = 0;
            long phone = 0;
            do
            {

                Console.WriteLine("Enter the Name with only alphabets and alphabets should be less than 10 :");
                name = Console.ReadLine();

            } while (!IsAlpha(name) || (name.Length > 10));
            do
            {
                Console.WriteLine("Enter the Age between 18 and 100:");
                statue1 = int.TryParse(Console.ReadLine(), out age);
            } while (statue1 == false || age > 100 || age < 18);
            do
            {
                Console.WriteLine("Enter the Phone of 10 digit:");
                statue2 = long.TryParse(Console.ReadLine(), out phone);
            } while (statue2 == false || phone < 999999999 || phone > 10000000000);

            cs.Register(id, name, age, phone);

        }
        public static void Update(int id, Class1 cs)
        {
            string update = "";
            string name = "";
            bool statue1 = true;
            bool statue2 = true;
            int age = 0;
            long phone = 0;
            do
            {
                Console.WriteLine("Enter \"N\" for Name \n \"A\" for Age \n \"P\" for phone ");
                update = (Console.ReadLine()).ToUpper();
            } while ((update != "N") && (update != "A") && (update != "P"));
            
            switch (update.ToUpper())
            {
                case "N":
                    do
                    {

                        Console.WriteLine("Enter the Name with only alphabets and alphabets should be less than 10 :");
                        name = Console.ReadLine();

                    } while (!IsAlpha(name) || (name.Length > 10));
                    cs.UpdateName(id, name);
                    break;
                case "A":
                    do
                    {
                        Console.WriteLine("Enter the Age between 18 and 100:");
                        statue1 = int.TryParse(Console.ReadLine(), out age);
                    } while (statue1 == false || age > 100 || age < 18);
                    cs.UpdateAge(id, age);
                    break;
                case "P":
                    do
                    {
                        Console.WriteLine("Enter the Phone of 10 digit:");
                        statue2 = long.TryParse(Console.ReadLine(), out phone);
                    } while (statue2 == false || phone < 999999999 || phone > 10000000000);
                    cs.UpdatePhone(id, phone);
                    break;
                default:
                    break;
            }

        }
        
        public static void DisplayIndividual(int id, Class1 cs)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The Detail of id :" + id);
            Console.WriteLine("Id\tName\tAge\tPhone");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(cs.ViewDetail(id));
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("************************************");
            Console.ForegroundColor = ConsoleColor.White;
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
    }
}
