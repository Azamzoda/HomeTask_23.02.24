using Domain.Models;
using Infrostructure.Services;

var employee1 = new Employee();
employee1.Firstname = "Mansur";
employee1.Lastname = "Azamzoda";
employee1.BirthDate = new DateTime(2007,05, 21);
employee1.Salary = 4500;

var employee2 = new EmployeeService();
employee2.AddEmployyes(employee1);
System.Console.WriteLine($"----------------------");



var departmewnt1 = new Department();
departmewnt1.Name = "Salmon";
departmewnt1.Description = "TAJIK";
System.Console.WriteLine();

var dep1 = new DepartmentService();
dep1.GetDepartments();
dep1.AddDepartments(departmewnt1);
dep1.CountDepartments();


foreach (var item in employee2.GetEmployees())
{
    System.Console.WriteLine(item.Firstname);
    System.Console.WriteLine(item.Lastname);
    System.Console.WriteLine(item.Salary);
    System.Console.WriteLine(item.BirthDate);
}
System.Console.WriteLine();
System.Console.WriteLine($"----------------------");
System.Console.WriteLine();
foreach (var item in dep1.GetDepartments())
{
    System.Console.WriteLine(item.Name);
    System.Console.WriteLine(item.Description);
    System.Console.WriteLine(item.Manager);
}