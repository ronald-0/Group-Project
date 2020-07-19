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
    public class SalaryController : BaseController
    {
        private ISalary _sal;
        private IGrade _grade;


        private readonly UserManager<Account> _userManager;
        public SalaryController(ISalary sal, IGrade grade, UserManager<Account> userManager)
        {
            _sal = sal;
            _grade = grade;
            _userManager = userManager;

        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await _sal.GetAll();
            if (model != null)
            {
                return View(model);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Salary s)
        {

            //d.DateCreated = DateTime.Now;
            var createSal = await _sal.AddAsync(s);
            if (createSal)
            {
                // Alert("Book Created successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var gradeName = await _grade.GetAll();
            var FacListName = gradeName.Select(g => new SelectListItem()
            {
                Value = g.Id.ToString(),
                Text = g.GradeName
            });
            var gradeLevel = await _grade.GetAll();
            var FacListLevel = gradeLevel.Select(g => new SelectListItem()
            {
                Value = g.Id.ToString(),
                Text = g.Level
            });
            var gradeStep = await _grade.GetAll();
            var FacListStep = gradeStep.Select(g => new SelectListItem()
            {
                Value = g.Id.ToString(),
                Text = g.Step
            });

            ViewBag.gradeName = FacListName;
            ViewBag.gradeLevel = FacListLevel;
            ViewBag.gradeStep = FacListStep;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Salary s)
        {
            
            var editSalary = await _sal.Update(s);
            if (editSalary && ModelState.IsValid)
            {
                Alert("Salary Edited successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Salary not Edited!", NotificationType.error);
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

            var gradeName = await _grade.GetAll();
            var FacListName = gradeName.Select(g => new SelectListItem()
            {
                Value = g.Id.ToString(),
                Text = g.GradeName
            });
            var gradeLevel = await _grade.GetAll();
            var FacListLevel = gradeLevel.Select(g => new SelectListItem()
            {
                Value = g.Id.ToString(),
                Text = g.Level
            });
            var gradeStep = await _grade.GetAll();
            var FacListStep = gradeStep.Select(g => new SelectListItem()
            {
                Value = g.Id.ToString(),
                Text = g.Step
            });

            ViewBag.gradeName = FacListName;
            ViewBag.gradeLevel = FacListLevel;
            ViewBag.gradeStep = FacListStep;

            //return View();
            return View(editGrade);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var deleteSalary = await _sal.Delete(id);
            if (deleteSalary)
            {
                Alert("Salary Details Deleted successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Salary Details not Deleted!", NotificationType.error);
            }
            return View();
        }
        public IActionResult Cancel()
        {
            return RedirectToAction("Index", "Salary");
        }
    }
}
