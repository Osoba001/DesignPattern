using EmployeeFactoryMethod.Manager;
using EmployeeFactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeFactoryMethod.CreateFactoryMethod
{
    internal abstract class BaseEmployeeFactory
    {
        protected Employee _employee;

        public BaseEmployeeFactory(Employee employee)
        {
            _employee = employee;
        }

        public abstract IEmployeeManager Create();

        public Employee ApplySalary()
        {
            IEmployeeManager manager = this.Create();
            _employee.Bonus=manager.GetBonus();
            _employee.HourlyPay=manager.GetPay();
            return _employee;
        }
    }
}
