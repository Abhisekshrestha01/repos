using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassPractice
{
    public class Customer
    {
        private string _firstName;
        private string _lastName;
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public string GetFullName()
        {
            return this._firstName + " " + this._lastName;
        }
    }
}
