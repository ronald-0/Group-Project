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
            catch (Exception e)
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
            return await _context.Salaries.Include(g => g.Grade).Include(u => u.User).ToListAsync();
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
                s.BasicSalary = salary.BasicSalary;
                s.GradeName = salary.GradeName;
                s.Housing = salary.Housing;
                s.HousingPercent = salary.HousingPercent;
                s.HousingItemType = salary.HousingItemType;
                s.UserId= salary.UserId;
                s.Lunch = salary.Lunch;
                s.LunchPercent = salary.LunchPercent;
                s.LunchItemType = salary.LunchItemType;
                s.Transport = salary.Transport;
                s.TransportPercent = salary.TransportPercent;
                s.TransportItemType = salary.TransportItemType;
                s.Medical = salary.Medical;
                s.MedicalPercent = salary.MedicalPercent;
                s.MedicalItemType = salary.MedicalItemType;
               
               
                await _context.SaveChangesAsync();
                return true;
            }

            return false;

        }
    }
}
