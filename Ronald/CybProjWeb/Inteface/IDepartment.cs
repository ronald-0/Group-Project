using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CybProjWeb.Entities;

namespace CybProjWeb.Inteface
{
    public interface IDepartment
    {
        void Add(Department dept);
        Task<bool> AddAsync(Department dept);
        Task<bool> Update(Department dept);
        Task<IEnumerable<Department>> GetAll();
        Task<Department> GetById(int Id);
        Task<bool> Delete(int Id);
    }
}
