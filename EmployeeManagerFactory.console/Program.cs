using EmployeeManagerFactory.console.Factory;
EmployeeManagerFactory.console.Factory.EmployeeManagerFactory employeeManagerFactory = new();


Console.WriteLine(employeeManagerFactory.GetEmployeeManager(0).GetPay());

Console.WriteLine(employeeManagerFactory.GetEmployeeManager(1).GetPay());


Console.ReadLine();
