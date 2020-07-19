using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CybProjWeb.Entities;
using CybProjWeb.Inteface;
using Microsoft.AspNetCore.Mvc;
using static CybProjWeb.Enums.Enum;


namespace CybProjWeb.Controllers
{
    public class GradeController : BaseController
    {
        private IGrade _grade;
        public GradeController(IGrade grade)
        {
            _grade = grade;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _grade.GetAll();
            if (model != null)
            {
                return View(model);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Grade g)
        {
            var createGrade = await _grade.AddAsync(g);

            if (createGrade)
            {
                Alert("Grade created successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Grade not created!", NotificationType.error);
            }
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {

            var deleteGrade = await _grade.Delete(id);
            if (deleteGrade)
            {
                Alert("Grade Deleted successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Grade not Deleted!", NotificationType.error);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Grade g)
        {
            var editGrade = await _grade.Update(g);
            if (editGrade && ModelState.IsValid)
            {
                Alert("Grade Edited successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Grade not Edited!", NotificationType.error);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var editGrade = await _grade.GetById(id);
            if (editGrade == null)
            {
                return RedirectToAction("Index");
            }
            return View(editGrade);
        }

        public IActionResult Cancel()
        {
            return RedirectToAction("Index", "Grade");
        }
    }
}
