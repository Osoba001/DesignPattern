using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeFactoryMethod.Manager
{
    internal class PermanentEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 10;
        }

        public decimal GetPay()
        {
            return 8;
        }
        public decimal GetHouseAllowance()
        {
            return 250;
        }
    }
}
