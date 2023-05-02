using RepositoryPattern.Data;
using RepositoryPattern.Infrastructure;
using RepositoryPattern.Models;

namespace RepositoryPattern.Service;

public class EmployeeService : IEmployeeServices
{
    EmployeeContext _ext;
    IEmployee _employee;
    public EmployeeService(IEmployee employee,EmployeeContext ext)
    {
        _ext = ext;
        _employee = employee;
    }
    public void SaveEmployee(Employee employee)
    {
        employee.Name = employee.Name + " SiliconSoft";
        _ext.Add(employee);
        _ext.SaveChanges();
    }
}
