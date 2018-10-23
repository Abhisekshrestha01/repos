using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace partialDemoPractice
{
    public partial class PartialCustomer
    {
        public string Print()
        {
            return _firstName + ", " + _lastName;
        }
    }
}