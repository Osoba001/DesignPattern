using EmployeeFactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeFactoryMethod.CreateFactoryMethod
{
    internal class EmployeeManagerFactory
    {
        public static BaseEmployeeFactory CreateEmployeeFactory(Employee employee)
        {
            if (employee.DepartmentId== 0)
                return new PermanentEmployeeFactory(employee);
            else
                return new ContractEmployeeFactory(employee);
        }
    }
}
