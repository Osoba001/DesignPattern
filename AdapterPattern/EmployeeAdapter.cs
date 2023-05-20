using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class EmployeeAdapter : EmployeeManager, IEmployee
    {
        public override string GetAllEmployee()
        {
            string result= base.GetAllEmployee();
            var emp = new Employee() { Id = 4, Name = "Adapter employee" };
            result += emp.ToString();
            return result;
        }
    }
}
