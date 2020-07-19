using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CybProjWeb.Data;
using CybProjWeb.Entities;
using CybProjWeb.Inteface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using static CybProjWeb.Enums.Enum;

namespace CybProjWeb.Controllers
{
    public class UserController : BaseController
    {
        private EmployeeDataContext _context;
        private IUser _user;
        public UserController(IUser user, EmployeeDataContext context)
        {
            _user = user;
            _context = context;
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

        [HttpPost]
        public async Task<IActionResult> Create(User u)
        {
            var createUser = await _user.AddAsync(u);

            if (createUser)
            {
                Alert("User created successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("User not created!", NotificationType.error);
            }
            return View();
        }
        public IActionResult Create()
        {
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
        public async Task<IActionResult> Edit(Grade g)
        {
            var editUser = await _user.Update(g);
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
        public JsonResult getLGAbyId(int Id)
        {
            List<LGA> list= new List<LGA>();
            list = _context.LGAs.Where(a => a.States.Id == Id).ToList();
            list.Insert(0, new LGA { Id = 0, Name = "Please select LGA" });
            return Json(new SelectList(list, "Id", "Name"));
        }
    }
}
