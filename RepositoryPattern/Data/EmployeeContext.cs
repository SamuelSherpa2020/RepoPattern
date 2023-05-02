﻿using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Models;

namespace RepositoryPattern.Data;

public class EmployeeContext:DbContext
{
    public EmployeeContext(DbContextOptions<EmployeeContext> opts):base (opts)
    {

    }
    public DbSet<Employee> Employees { get; set; }
}
