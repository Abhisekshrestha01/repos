﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Manager
{
    public class PermanentEmployeeManager:IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 10;
        }

        public decimal GetPay()
        {
            return 8;
        }
    }
}