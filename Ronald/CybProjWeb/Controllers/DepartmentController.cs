using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CybProjWeb.Entities;
using CybProjWeb.Inteface;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static CybProjWeb.Enums.Enum;

namespace CybProjWeb.Controllers
{
    public class DepartmentController : BaseController
    {
        private IDepartment _dept;  
        private IFaculty _fac;
      
    
        private readonly UserManager<Account> _userManager;
        public DepartmentController(IDepartment dept, IFaculty fac, UserManager<Account> userManager)
        {
            _dept = dept;
            _fac = fac;
            _userManager = userManager;
           
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await _dept.GetAll();
            if (model != null)
            {
                return View(model);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Department d)
        {
            
            d.DateCreated = DateTime.Now;

            var createDept = await _dept.AddAsync(d);
            if (createDept)
            {
               // Alert("Book Created successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var fac = await _fac.GetAll();
            var FacList = fac.Select(f => new SelectListItem()
            {
                Value = f.Id.ToString(),
                Text =  f.FacultyName
            });


            ViewBag.fac = FacList;
           
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Department d)
        {
            d.DateCreated = DateTime.Now;
            var editDept = await _dept.Update(d);
            if (editDept && ModelState.IsValid)
            {
                Alert("Department Edited successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Department not Edited!", NotificationType.error);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var editDepartment = await _dept.GetById(id);

            if (editDepartment == null)
            {
                return RedirectToAction("Index");
            }
           
            var fac = await _fac.GetAll();
            var FacList = fac.Select(f => new SelectListItem()
            {
                Value = f.Id.ToString(),
                Text = f.FacultyName
            });

            ViewBag.fac = FacList;
           
            //return View();
            return View(editDepartment);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var deleteBook = await _dept.Delete(id);
            if (deleteBook)
            {
                Alert("Department Deleted successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Department not Deleted!", NotificationType.error);
            }
            return View();
        }
        public IActionResult Cancel()
        {
            return RedirectToAction("Index", "Department");
        }
    }
}
