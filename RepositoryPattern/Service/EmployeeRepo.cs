using RepositoryPattern.Data;
using RepositoryPattern.Infrastructure;
using RepositoryPattern.Models;

namespace RepositoryPattern.Service;

public class EmployeeRepo : IEmployee
{
    private readonly EmployeeContext _context;

    public EmployeeRepo(EmployeeContext context)
    {
        _context = context;  
    }

    public void Delete(Employee employee)
    {
        _context.Remove(employee);
    } 

    public List<Employee> GetAll()
    {
        return _context.Employees.ToList();
    }

    public Employee GetById(int id)
    {
        return _context.Employees.Where(x =>x.Id== id).FirstOrDefault();
    }

    public void Insert(Employee employee)
    {
        _context.Add(employee);
    }

    public void Save()
    {
        _context.SaveChanges();
    }

    public void Update(Employee employee)
    {
        _context.Update(employee);
    }
}
