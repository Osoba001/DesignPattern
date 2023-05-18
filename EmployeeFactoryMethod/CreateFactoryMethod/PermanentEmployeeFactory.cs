using EmployeeFactoryMethod.Manager;
using EmployeeFactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeFactoryMethod.CreateFactoryMethod
{
    internal class PermanentEmployeeFactory : BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee employee) : base(employee)
        {
        }

        public override IEmployeeManager Create()
        {
            var pmt = new PermanentEmployeeManager();
            _employee.HouseAllowance = pmt.GetHouseAllowance();
            _employee.DepartmentName = "Permanent Staff";
            return pmt;
        }
    }
}
