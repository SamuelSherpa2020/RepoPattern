using RepositoryPattern.Models;

namespace RepositoryPattern.Service;

public interface IEmployeeServices
{
    void SaveEmployee(Employee employee);
}
