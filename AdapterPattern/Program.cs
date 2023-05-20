using AdapterPattern;

EmployeeManager employeeManager= new EmployeeManager();

Console.WriteLine($"Normal employees:\n{employeeManager.GetAllEmployee()}");

IEmployee adapterEmp = new EmployeeAdapter();

Console.WriteLine($"adapter employees:\n{adapterEmp.GetAllEmployee()}");
Console.ReadLine();
