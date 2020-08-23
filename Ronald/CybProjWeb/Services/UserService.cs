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
    public class UserService : IUser
    {
        private EmployeeDataContext _context;
        public UserService(EmployeeDataContext context)
        {
            _context = context;
        }

        public void Add(User u)
        {
            u.DateCreated = DateTime.Now;
            _context.Add(u);
            _context.SaveChanges();
        }
        public async Task<bool> AddAsync(User user)
        {
            try
            {
                
                await _context.AddAsync(user);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> Delete(int Id)
        {
            // find the entity/object
            var user = await _context.EmpUsers.FindAsync(Id);

            if (user != null)
            {
                _context.EmpUsers.Remove(user);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context.EmpUsers.Include(d => d.Department).Include(g => g.Grade).Include(a => a.Account).Include(s => s.State).Include(l => l.LGA).ToListAsync();
        }

        public async Task<User> GetById(int Id)
        {
            var user = await _context.EmpUsers.FindAsync(Id);
            return user;
        }

        public async Task<bool> Update(User u)
        {
            var user = await _context.EmpUsers.FindAsync(u.Id);
            if (user != null)
            {
                user.FirstName = u.FirstName;
                user.LastName = u.LastName;
               // user.GradeId = u.GradeId;
               // user.FacultyId = u.FacultyId;
                user.DepartmentId = u.DepartmentId;
               // user.Email = user.Email;
                
              //  user.States = user.States;
               // user.LGAs = user.LGAs;

                await _context.SaveChangesAsync();
                return true;
            }

            return false;

        }
    }
}
