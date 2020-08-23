using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CybProjWeb.Data;
using CybProjWeb.Entities;
using CybProjWeb.Inteface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using static CybProjWeb.Enums.Enum;
using Microsoft.AspNetCore.Identity;

namespace CybProjWeb.Controllers
{
    //[Authorize(Roles = "User")]
    public class UserController : BaseController
    {
        private EmployeeDataContext _context;
        private IUser _user;
        private IDepartment _dept;
        private readonly RoleManager<Role> roleManager;
        private IGrade _grade;
       // private IState _state;
        public UserController(IUser user, IDepartment dept, IGrade grade, RoleManager<Role> roleM, EmployeeDataContext context)
        {
            _dept = dept;
            roleManager = roleM;
            _user = user;
            _context = context;
            _grade = grade;
           // _state = state;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _user.GetAll();
            
            if (model != null)
            {
                
                return View(model);
            }
            return View();
        }
        public async Task<IActionResult> PersonalSalary()
        {
            var model = await _user.GetAll();
            if (model != null)
            {
                return View(model);
            }
            return View();
        }

        public async Task<IActionResult> ViewProfile()
        {
            var model = await _user.GetAll();
            
            if (model != null)
            {
                //ViewBag.state = _context.States.ToList();
                return View(model);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(User u)
        {
            var grade = _context.Grade.First(n => n.Id == u.GradeId);
            u.GradeName = grade.GradeName;
            u.GradeLevel = grade.GradeLevel;
            u.GradeStep = grade.GradeStep;
            u.Housing = grade.Housing;
            u.HousingItemType = grade.HousingItemType;
            u.Lunch = grade.Lunch;
            u.LunchItemType = grade.LunchItemType;
            u.Medical = grade.Medical;
            u.MedicalItemType = grade.MedicalItemType;
            u.Transport = grade.Transport;
            u.TransportItemType = grade.TransportItemType;
            u.Tax = grade.Tax;
            u.BasicSalary = grade.BasicSalary;
            u.GrossSalary= grade.GrossSalary;
            u.NetSalary = grade.NetSalary;

            var createUser = await _user.AddAsync(u);

           
            if (createUser)
            {
                
                Alert("User created successfully.", NotificationType.success);
              
                return RedirectToAction("Index","User");
            }
            else
            {
                Alert("User not created!", NotificationType.error);
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var dept = await _dept.GetAll();
          
            var gradeName = await _grade.GetAll();

            var EmailList = _context.EmpUsers.Select(q => q.Account.Email).ToList();
            var users = _context.Users.Where(u => !EmailList.Contains(u.Email)).ToList();

            var usersList = users.Select(u => new SelectListItem()
            {
                Value = u.Id.ToString(),
                Text = u.Email
            });


            var deptList = dept.Select(d => new SelectListItem()
            {
                Value = d.Id.ToString(),
                Text = d.DeptName
            });
            var gradeList = gradeName.Select(d => new SelectListItem()
            {
                Value = d.Id.ToString(),
                Text = d.GradeName
            });


            ///dropdown of unregistered users
          /// var EmailList = _context.EmpUsers.Select(q => q.Email).ToList();
           //var temp = _context.Users.Where(u => !EmailList.Contains(u.Email));

            //ViewBag.emails = temp.ToList();

            ViewBag.grade = gradeList;
            ViewBag.state = _context.States.ToList();
            ViewBag.dept = deptList;
            ViewBag.users = usersList;


            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {

            var deleteUser = await _user.Delete(id);
            if (deleteUser)
            {
                Alert("User Deleted successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("User not Deleted!", NotificationType.error);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(User u)
        {
            var editUser = await _user.Update(u);
            if (editUser && ModelState.IsValid)
            {
                Alert("User Edited successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("User not Edited!", NotificationType.error);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var editUser = await _user.GetById(id);
            if (editUser == null)
            {
                return RedirectToAction("Index");
            }
            return View(editUser);
        }

        public IActionResult Cancel()
        {
            return RedirectToAction("Index", "User");
        }

        public JsonResult getLGAbyId(int id)
        {
            List<LGA> list= new List<LGA>();
            list = _context.LGAs.Where(a => a.State.Id == id).ToList();
            list.Insert(0, new LGA { Id = 0, Name = "Please select LGA" });
            return Json(new SelectList(list, "Id", "Name"));
        }
    }
}
