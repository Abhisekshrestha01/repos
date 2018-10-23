using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace partialDemoPractice
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
        public string Print()
        {
            return this._firstName + " " + this._lastName;
        }
    }
}