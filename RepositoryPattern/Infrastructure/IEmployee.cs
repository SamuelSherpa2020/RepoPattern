﻿using RepositoryPattern.Models;

namespace RepositoryPattern.Infrastructure;

public interface IEmployee
{
    List<Employee> GetAll();
    Employee GetById(int id);
    void Insert(Employee employee);
    void Update(Employee employee);
    void Delete(Employee employee);
    void Save(); 
}
