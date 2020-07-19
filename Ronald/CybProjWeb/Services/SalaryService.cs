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
    public class SalaryService :ISalary
    {
        private EmployeeDataContext _context;
        public SalaryService(EmployeeDataContext context)
        {
            _context = context;
        }

        public void Add(Salary s)
        {
           // s.DateCreated = DateTime.Now;
            _context.Add(s);
            _context.SaveChanges();
        }
        public async Task<bool> AddAsync(Salary s)
        {
            try
            {
                await _context.AddAsync(s);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> Delete(int Id)
        {
            // find the entity/object
            var s = await _context.Salaries.FindAsync(Id);

            if (s != null)
            {
                _context.Salaries.Remove(s);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public async Task<IEnumerable<Salary>> GetAll()
        {
            return await _context.Salaries.Include(g=>g.Grade).ToListAsync();
        }

        public async Task<Salary> GetById(int Id)
        {
            var s = await _context.Salaries.FindAsync(Id);

            return s;
        }

        public async Task<bool> Update(Salary salary)
        {
            var s = await _context.Salaries.FindAsync(salary.Id);
            if (s != null)
            {
                s.GradeId = salary.Id;
                s.PayItem = salary.PayItem;
                s.PayItemType = salary.PayItem;
                s.Amount = salary.Amount;
                await _context.SaveChangesAsync();
                return true;
            }

            return false;

        }
    }
}
