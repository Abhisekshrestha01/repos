using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassPractice
{
    public partial class PartialCustomer
    {
        public string GetFullName()
        {
            return this._firstName + " " + this._lastName;
        }
    }
}
