using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Id : {Id}, Name : {Name}\n";
        }
    }

    public class EmployeeManager
    {
        public List<Employee> employees;
        public EmployeeManager()
        {
            employees= new List<Employee>();
            employees.Add(new Employee{ Id=1, Name="James"});
            employees.Add(new Employee{ Id=2, Name="Michael"});
            employees.Add(new (){ Id=3, Name="Jason"});
        }

        public virtual string GetAllEmployee()
        {
            var strBuilder=new StringBuilder();
            foreach (var employee in employees)
            {
                strBuilder.Append(employee.ToString());
            }
            return strBuilder.ToString();
        }
    }
}
