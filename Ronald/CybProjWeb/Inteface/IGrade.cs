using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CybProjWeb.Entities;

namespace CybProjWeb.Inteface
{
    public interface IGrade
    {
        void Add(Grade grade);
        Task<bool> AddAsync(Grade grade);
        Task<bool> Update(Grade grade);
        Task<IEnumerable<Grade>> GetAll();
        Task<Grade> GetById(int Id);
        Task<bool> Delete(int Id);
    }
}
