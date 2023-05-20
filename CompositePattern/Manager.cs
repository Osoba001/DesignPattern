using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class Manager : IEmployee
    {
        public List<Employee> Subordinate;
        public Manager(string name, string dept)
        {
            Name = name;
            Dept = dept;
            Subordinate =new List<Employee>();
        }

        public string Name { get; }
        public string Dept { get; }

        public void GetDetails()
        {
            Console.WriteLine($"Name : {Name}, Dept : {Dept}");
            foreach (var emp in Subordinate)
            {
                emp.GetDetails();
            }
        }
    }
}
