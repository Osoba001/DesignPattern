using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Models
{
    public class Employee: CloneablePrototype<Employee>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }

        public Address Address { get; set; }

        public override string ToString()
        {
            return $"Name : {Name}, DepartmentId : {DepartmentId}, Address Postecode : {Address.Postecode}"+
                $"StreetName : {Address.streetName }, City : {Address.cityName}";
        }
    }

    public class Address
    {
        public int Postecode { get; set; }
        public string streetName { get; set; }
        public string cityName { get; set; }
    }
}
