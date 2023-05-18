using EmployeeManagerFactory.console.Manager;

namespace EmployeeManagerFactory.console.Factory
{
    internal class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int id)
        {
            if (id == 0)
                return new PermanentEmployeeManager();
            else
                return new ContractEmployeeManager();
        }
    }
}
