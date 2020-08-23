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
    public class FacultyService : IFaculty
    {
        private EmployeeDataContext _context;
        public FacultyService(EmployeeDataContext context)
        {
            _context = context;
        }

        public void Add(Faculty fac)
        {
            fac.DateCreated = DateTime.Now;
            _context.Add(fac);
            _context.SaveChanges();
        }
        public async Task<bool> AddAsync(Faculty fac)
        {
            try
            {
                await _context.AddAsync(fac);
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
            var fac = await _context.Faculties.FindAsync(Id);

            if (fac != null)
            {
                _context.Faculties.Remove(fac);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public async Task<IEnumerable<Faculty>> GetAll()
        {
            return await _context.Faculties.ToListAsync();
        }

        public async Task<Faculty> GetById(int Id)
        {
            var fac = await _context.Faculties.FindAsync(Id);

            return fac;
        }

        public async Task<bool> Update(Faculty f)
        {
            var fac = await _context.Faculties.FindAsync(f.Id);
            if (fac != null)
            {
                fac.FacultyName = f.FacultyName;
                fac.FacultyCode = f.FacultyCode;
                

                await _context.SaveChangesAsync();
                return true;
            }

            return false;

        }
    }
}
