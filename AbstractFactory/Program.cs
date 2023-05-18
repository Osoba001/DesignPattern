using AbstractFactory.Factory;
using AbstractFactory.Models;

var emp1 = new Employee { Id = 0, Name = "Jaja", DepartmentId = 0,JobDescription=JobDeScription.Manager,ContractType=ContractType.Permanent};
var emp2 = new Employee { Id = 1, Name = "Sunday", DepartmentId = 1, JobDescription = JobDeScription.Staff, ContractType = ContractType.Permanent };
var emp3 = new Employee { Id = 3, Name = "Victory", DepartmentId = 0, JobDescription = JobDeScription.Manager, ContractType = ContractType.Contract};
var emp4 = new Employee { Id = 4, Name = "Iruoma", DepartmentId = 0, JobDescription = JobDeScription.Staff, ContractType = ContractType.Contract };

var emps = new List<Employee> { emp1, emp2, emp3,emp4 };
foreach (var emp in emps)
{
    IComputerFactory empFac =new EmployeeSystemFactory().Create(emp);
    var computer=new EmployeeSystemManager(empFac);
    emp.ComputerDetail=computer.GetSystemDetail();

    Console.WriteLine($"EmployeeType: {emp.ContractType}; Job: {emp.JobDescription}, Computer: {emp.ComputerDetail}.");
}
Console.ReadLine();
