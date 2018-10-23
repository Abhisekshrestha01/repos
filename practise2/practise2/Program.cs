using System;
using System.Collections.Generic;
using System.Linq;

namespace practise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string YesOrNo = string.Empty;
            do
            {
                Country C1 = new Country()
                {
                    Code = "AUS",
                    Name = "Australia",
                    Capital = "Canberra"
                };
                Country C2 = new Country()
                {
                    Code = "IND",
                    Name = "India",
                    Capital = "NewDelhi"
                };
                Country C3 = new Country()
                {
                    Code = "USA",
                    Name = "United States",
                    Capital = "WashingtonDC"
                };

                List<Country> countrylist = new List<Country>();
                countrylist.Add(C1);
                countrylist.Add(C2);
                countrylist.Add(C3);

                Dictionary<string, Country> dict = countrylist.ToDictionary(x => x.Code, x => x);


                Console.WriteLine("Enter the code to know the name and capital of that country");
                string codeEntered = Console.ReadLine();
                Country C5 = dict.ContainsKey(codeEntered) ? dict[codeEntered] : null ;
                Console.WriteLine("Code is {0}, Name of Country is {1} and Capital is {2}", C5.Code, C5.Name, C5.Capital);
                 do
                {
                    Console.WriteLine("Do you want to Try another: Yes or No");
                    YesOrNo = Console.ReadLine().ToUpper();                 
                } while ((YesOrNo != "YES") && (YesOrNo != "NO"));
                
            } while (YesOrNo == "YES");
            

        }
    }
    public class Country
    {
        public string Name { set; get; }
        public string Code { set; get; }
        public string Capital { set; get; }
    }
}
