using AbstractFactory.Models;

namespace AbstractFactory.Factory
{
    internal class EmployeeSystemFactory
    {
        public IComputerFactory Create(Employee employee)
        {
            if (employee.ContractType==ContractType.Permanent)
                if (employee.JobDescription == JobDeScription.Manager)
                    return new MACLaptopFactory();
                else
                    return new MACDeskTopFactory();
            else
                if(employee.JobDescription==JobDeScription.Manager)
                    return new DellLaptopFactory();
                else
                    return new DellDesktopFactory();

        }
    }
}
