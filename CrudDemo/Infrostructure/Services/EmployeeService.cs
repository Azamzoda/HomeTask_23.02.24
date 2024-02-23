using Domain.Models;

namespace Infrostructure.Services;

public class EmployeeService
{
     List<Employee> _employees = new List<Employee>();
    public List<Employee> GetEmployees()
    {
        return _employees;
    }
    public void AddEmployyes(Employee employee)
    {
        _employees.Add(employee);

    }
    public int CountEmployees()
    {
        return _employees.Count;
    }

}
