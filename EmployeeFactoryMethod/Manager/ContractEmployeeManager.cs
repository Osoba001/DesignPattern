using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeFactoryMethod.Manager
{
    internal class ContractEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 5;
        }

        public decimal GetPay()
        {
            return 12;
        }
        public decimal MedicalAllowance()
        {
            return 120;
        }
    }
}
