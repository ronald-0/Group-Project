using System.Threading.Tasks;
using CybProjWeb.Entities;
using static CybProjWeb.Enums.Enum;
using CybProjWeb.Inteface;
using Microsoft.AspNetCore.Mvc;


namespace CybProjWeb.Controllers
{
    // [Authorize(Roles = "Admin")]
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
            //FOR HOUSING
            g.Housing = g.HousingPercent * g.BasicSalary / 100;
            g.GrossSalary = g.BasicSalary;

            if (g.HousingItemType == "Allowance")
            {

                g.GrossSalary += g.Housing;
            }
            else if (g.HousingItemType == "Deduction")
            {
                g.GrossSalary -= g.Housing;
            }

            //FOR LUNCH
            g.Lunch = g.LunchPercent * g.BasicSalary / 100;

            if (g.LunchItemType == "Allowance")
            {

                g.GrossSalary += g.Lunch;
            }

            else if (g.LunchItemType == "Deduction")
            {

                g.GrossSalary -= g.Lunch;
            }

            //FOR TRANSPORT
            g.Transport = g.TransportPercent * g.BasicSalary / 100;

            if (g.TransportItemType == "Allowance")
            {

                g.GrossSalary += g.Transport;
            }
            else if (g.TransportItemType == "Deduction")
            {

                g.GrossSalary -= g.Transport;
            }

            //FOR MEDICAL
            g.Medical = g.MedicalPercent * g.BasicSalary / 100;

            if (g.MedicalItemType == "Allowance")
            {

                g.GrossSalary += g.Medical;
            }
            else if (g.MedicalItemType == "Deduction")
            {

                g.GrossSalary -= g.Medical;
            }

            //TOTAL g
            g.Tax = g.TaxPercent * g.GrossSalary / 100;

            g.NetSalary = g.GrossSalary - g.Tax;

           

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
