﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerFactory.console.Manager
{
    internal interface IEmployeeManager
    {
        decimal GetBonus();
        decimal GetPay();
    }
}
