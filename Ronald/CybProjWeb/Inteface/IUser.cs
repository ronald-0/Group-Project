using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CybProjWeb.Entities;

namespace CybProjWeb.Inteface
{
    public interface IUser
    {
        void Add(User user);
        Task<bool> AddAsync(User user);
        Task<bool> Update(User user);
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(int Id);
        Task<bool> Delete(int Id);
    }
}
