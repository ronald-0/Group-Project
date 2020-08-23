using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CybProjWeb.Entities;

namespace CybProjWeb.Inteface
{
    public interface IRole
    {
        Task<IEnumerable<Role>> GetAll();
    }
}
