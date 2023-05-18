using EmployeeFactoryMethod.Manager;
using EmployeeFactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeFactoryMethod.CreateFactoryMethod
{
    internal class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee employee) : base(employee)
        {
        }

        public override IEmployeeManager Create()
        {
            var contEmp = new ContractEmployeeManager();
            _employee.MedicalAllowance = contEmp.MedicalAllowance();
            _employee.DepartmentName = "Contract Staff";
            return contEmp;
        }
    }
}
