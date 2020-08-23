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
    public class GradeService :IGrade
    {
        private EmployeeDataContext _context;
        public GradeService(EmployeeDataContext context)
        {
            _context = context;
        }

        public void Add(Grade g)
        {
            g.DateCreated = DateTime.Now;
            _context.Add(g);
            _context.SaveChanges();
        }
        public async Task<bool> AddAsync(Grade g)
        {
            try
            {
                await _context.AddAsync(g);
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
            var g = await _context.Grade.FindAsync(Id);

            if (g != null)
            {
                _context.Grade.Remove(g);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public async Task<IEnumerable<Grade>> GetAll()
        {
            return await _context.Grade.ToListAsync();
        }

        public async Task<Grade> GetById(int Id)
        {
            var g = await _context.Grade.FindAsync(Id);

            return g;
        }

        public async Task<bool> Update(Grade grade)
        {
            var g = await _context.Grade.FindAsync(grade.Id);
            if (g != null)
            {
                g.GradeName = grade.GradeName;
                g.GradeLevel= grade.GradeLevel;
                g.GradeStep = grade.GradeStep;

                await _context.SaveChangesAsync();
                return true;
            }

            return false;

        }
    }
}
