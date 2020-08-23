using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CybProjWeb.Entities;
using CybProjWeb.Inteface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static CybProjWeb.Enums.Enum;

namespace CybProjWeb.Controllers
{
   // [Authorize(Roles = "Admin")]
    public class FacultyController : BaseController
    {
        private IFaculty _faculty;
        public FacultyController(IFaculty fac)
        {
            _faculty = fac;
           
        }
        public async Task<IActionResult> Index()
        {
            var model = await _faculty.GetAll();
            if (model != null)
            {
                return View(model);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Faculty fac)
        {
            var createFaculty = await _faculty.AddAsync(fac);

            if (createFaculty)
            {
                Alert("Faculty created successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Faculty not created!", NotificationType.error);
            }
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {

            var deleteAuthor = await _faculty.Delete(id);
            if (deleteAuthor)
            {
                Alert("Faculty Deleted successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Faculty not Deleted!", NotificationType.error);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Faculty f)
        {
            var editFaculty = await _faculty.Update(f);
            if (editFaculty && ModelState.IsValid)
            {
                Alert("Faculty Edited successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("faculty not Edited!", NotificationType.error);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var editFaculty = await _faculty.GetById(id);
            if (editFaculty == null)
            {
                return RedirectToAction("Index");
            }
            return View(editFaculty);
        }

        public IActionResult Cancel()
        {
            return RedirectToAction("Index", "Faculty");
        }
    }
}
