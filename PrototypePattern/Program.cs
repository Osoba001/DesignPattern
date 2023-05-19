// See https://aka.ms/new-console-template for more information
using PrototypePattern.Models;

Address address1 = new() { Postecode = 111111, cityName = "Woji", streetName = "Ogbatai" };
Address address2 = new() { Postecode = 44444, cityName = "Choba", streetName = "Aluu" };
Employee emp1=new Employee() { Id=Guid.NewGuid(), DepartmentId=3, Name="James",Address=address1 };
Employee emp2= emp1.DeepCopy();

emp2.Name = "Faith";
emp2.DepartmentId = 8;
emp2.Id = Guid.NewGuid();
//emp2.Address= address2;
emp2.Address.cityName = "Choba";
emp2.Address.streetName = "Aluu";
emp2.Address.Postecode = 44444;

Console.WriteLine(emp1.ToString());
Console.WriteLine("-----------------");
Console.WriteLine(emp2.ToString());
Console.ReadLine();
