using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CybProjWeb.Data;
using CybProjWeb.Entities;
using CybProjWeb.Inteface;
using Microsoft.EntityFrameworkCore;

namespace CybProjWeb.Services
{
    public class RoleService :IRole
    {
        private EmployeeDataContext _context;
        public RoleService(EmployeeDataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Role>> GetAll()
        {

            return await _context.Roles.ToListAsync();
        }

    }
}
