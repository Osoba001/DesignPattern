using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Employee:IEmployee
    {
        public Employee(string name, string dept)
        {
            Name = name;
            Dept = dept;
        }

        public string Name { get; }
        public string Dept { get; }

        public void GetDetails()
        {
            Console.WriteLine($"Name : {Name}, Dept : {Dept}");
        }
    }
}
