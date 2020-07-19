using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CybProjWeb.Entities;

namespace CybProjWeb.Inteface
{
    public interface ISalary
    {
        void Add(Salary sal);
        Task<bool> AddAsync(Salary sal);
        Task<bool> Update(Salary dept);
        Task<IEnumerable<Salary>> GetAll();
        Task<Salary> GetById(int Id);
        Task<bool> Delete(int Id);
    }
}
