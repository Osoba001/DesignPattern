using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeFactoryMethod.Models
{
    internal class Employee
    {
        public Employee()
        {
            Name = string.Empty;
            DepartmentName = string.Empty;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int  DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public decimal HourlyPay { get; set; }
        public decimal Bonus { get; set; }
        public decimal HouseAllowance { get; set; }
        public decimal MedicalAllowance { get; set;}

    }
}
