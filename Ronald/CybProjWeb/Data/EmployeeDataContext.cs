using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CybProjWeb.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CybProjWeb.Data
{
    public class EmployeeDataContext : IdentityDbContext<Account, Role, string>
    {
            public EmployeeDataContext(DbContextOptions<EmployeeDataContext> options) : base(options)
            {
            }
            public virtual DbSet<Department> Departments { get; set; }  
            public virtual DbSet<Faculty> Faculties { get; set; }
            public virtual DbSet<Grade> Grade { get; set; }
            public virtual DbSet<User> EmpUsers { get; set; }
            public virtual DbSet<Salary> Salaries { get; set; }
            public virtual DbSet<State> States { get; set; }
            public virtual DbSet<Role> Roless { get; set; }
            public virtual DbSet<LGA> LGAs { get; set; }
           // public virtual DbSet<Role> RoleName { get; set; }
    }
    
}
