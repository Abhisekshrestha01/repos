using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace partialDemoPractice
{
    public partial class PartialCustomer
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get
            {
                return this._firstName;
            }
            set
            {
                this._firstName = value;               
            }

        }
        public string LastName
        {
            get
            {
                return this._lastName;
            }
            set
            {
                this._lastName = value;
            }

        }
    }
}