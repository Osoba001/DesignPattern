
using EmployeeFactoryMethod.CreateFactoryMethod;
using EmployeeFactoryMethod.Models;

var emp1 = new Employee { Id = 0, Name = "Jaja", DepartmentId = 0 };
var emp2 = new Employee { Id = 1, Name = "Sunday", DepartmentId = 1 };
var emp3 = new Employee { Id = 3, Name = "Victory", DepartmentId = 0 };

var emps=new List<Employee> { emp1, emp2, emp3 };
foreach (var e in emps)
{
    var employeeManagerFactory = EmployeeManagerFactory.CreateEmployeeFactory(e);
    var emp = employeeManagerFactory.ApplySalary();
    Console.WriteLine($"DepartmentName: {emp.DepartmentName}, employeeName: {emp.Name}, HourlyPay: {emp.HourlyPay}, Bonus: {emp.Bonus}, HouseAllowance:{emp.HouseAllowance}, MedicalAllowance: {emp.MedicalAllowance}");
}


Console.ReadLine();
