using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CybProjWeb.Data;
using CybProjWeb.Entities;
using CybProjWeb.Inteface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static CybProjWeb.Enums.Enum;

namespace CybProjWeb.Controllers
{
   // [Authorize(Roles = "Admin")]
    public class SalaryController : BaseController
    {
        private ISalary _sal;
        private IGrade _grade;
        private IUser _user;
        private EmployeeDataContext _context;


        private readonly UserManager<Account> _userManager;
        public SalaryController(EmployeeDataContext context,ISalary sal, IGrade grade, IUser user, UserManager<Account> userManager)
        {
            _sal = sal;
            _grade = grade;
            _userManager = userManager;
            _user = user;
            _context = context;

        }
        [HttpGet]
       // public async Task<IActionResult> Index()
        //{
            //var model = await _sal.GetAll();
           // if (model != null)
          //  {
           //     return View(model);
          //  }
        //    return View();
       // }
        [HttpGet]
      //  public async Task<IActionResult> PersonalSalary()
       // {
          //  var model = await _sal.GetAll();
        //    if (model != null)
        //    {
         //       return View(model);
       //     }
      //      return View();
      //  }

        [HttpPost]
        public async Task<IActionResult> Create(Salary salary)
        {
            //FOR HOUSING
            salary.Housing = salary.HousingPercent * salary.BasicSalary / 100;
            salary.GrossSalary = salary.BasicSalary;

            if (salary.HousingItemType == "Allowance")
            {

                salary.GrossSalary += salary.Housing;
            }
            else if (salary.HousingItemType == "Deduction")
            {
                salary.GrossSalary -= salary.Housing;
            }

            //FOR LUNCH
            salary.Lunch = salary.LunchPercent * salary.BasicSalary / 100;

            if (salary.LunchItemType == "Allowance")
            {

                salary.GrossSalary += salary.Lunch;
            }

            else if (salary.LunchItemType == "Deduction")
            {

                salary.GrossSalary -= salary.Lunch;
            }

            //FOR TRANSPORT
            salary.Transport = salary.TransportPercent * salary.BasicSalary / 100;

            if (salary.TransportItemType == "Allowance")
            {

                salary.GrossSalary += salary.Transport;
            }
            else if (salary.TransportItemType == "Deduction")
            {

                salary.GrossSalary -= salary.Transport;
            }

            //FOR MEDICAL
            salary.Medical = salary.MedicalPercent * salary.BasicSalary / 100;

            if (salary.MedicalItemType == "Allowance")
            {

                salary.GrossSalary += salary.Medical;
            }
            else if (salary.MedicalItemType == "Deduction")
            {

                salary.GrossSalary -= salary.Medical;
            }

            //TOTAL SALARY
            salary.Tax = salary.TaxPercent * salary.GrossSalary / 100;

            salary.NetSalary = salary.GrossSalary - salary.Tax;

            //var grade = _context.Grade.First(n => n.Id == salary.GradeId);
           // salary.GradeName = grade.GradeName;
           // salary.GradeLevel = grade.GradeLevels;
           // salary.GradeStep = grade.GradeSteps;
            //d.DateCreated = DateTime.Now;
            var createSal = await _sal.AddAsync(salary);

            if (salary != null)
            {
                Alert("UserProfile created successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            Alert("UserProfile not created!", NotificationType.error);
            return View(salary);
        }

        
       
        
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var gradeName = await _grade.GetAll();
            var gradeListName = gradeName.Select(g => new SelectListItem()
            {
                Value = g.Id.ToString(),
                Text = g.GradeName
            });
           /* var gradeLevel = await _grade.GetAll();
            var gradeListLevel = gradeLevel.Select(g => new SelectListItem()
            {
                Value = g.Id.ToString(),
                Text = g.Level
            });
            var gradeStep = await _grade.GetAll();
            var gradeListStep = gradeStep.Select(g => new SelectListItem()
            {
                Value = g.Id.ToString(),
                Text = g.Step
            });*/
            var user = await _user.GetAll();
            var userList = user.Select(u => new SelectListItem()
            {
                Value = u.Id.ToString(),
                Text = u.FirstName
            });

            ViewBag.user = userList;
            ViewBag.gradeName = gradeListName;
          //  ViewBag.gradeLevel = gradeListLevel;
          //  ViewBag.gradeStep = gradeListStep;

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
            var editSal = await _sal.GetById(id);

            if (editSal == null)
            {
                return RedirectToAction("Index");
            }

            var user = await _user.GetAll();
            var userList = user.Select(u => new SelectListItem()
            {
                Value = u.Id.ToString(),
                Text = u.FirstName
            });
            var gradeName = await _grade.GetAll();
            var FacListName = gradeName.Select(g => new SelectListItem()
            {
                Value = g.Id.ToString(),
                Text = g.GradeName
            });
            
            ViewBag.gradeName = FacListName;

            ViewBag.user = userList;
            // ViewBag.gradeLevel = FacListLevel;
            //ViewBag.gradeStep = FacListStep;

            //return View();
            return View(editSal);
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
