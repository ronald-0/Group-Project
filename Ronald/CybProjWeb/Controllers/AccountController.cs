using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CybProjWeb.Data;
using CybProjWeb.Dtos;
using CybProjWeb.Entities;
using CybProjWeb.Inteface;
using CybProjWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static CybProjWeb.Enums.Enum;

namespace CybProjWeb.Controllers
{
    public class AccountController : BaseController
    {
        private EmployeeDataContext _context;
        private readonly IAccount _account;
        
        private readonly SignInManager<Account> _signInManager;
        private readonly UserManager<Account> _userManager;
        

        public AccountController(IAccount account, SignInManager<Account> signInManager,UserManager<Account> userManager, EmployeeDataContext context)
        {
           // _roleManager = roleManager;
            _account = account;
            _signInManager = signInManager;
            _userManager = userManager;
            _context= context;


        }
        public IActionResult Login()
        {
           // ViewBag.role = _context.Roless.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
                Alert("Login Unsuccesful!", NotificationType.error);
                ModelState.AddModelError("", "UserName/Password is incorrect");
                return View();
            }
            Account user = new Account();
           
           // user.UserName = login.;
            user.Email = login.Email;
           // user.RoleName = login.RoleName;


            var signin = await _account.LoginIn(login);
            
            if (signin)
            {
                
                Alert("Login successful.", NotificationType.success);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        

         [HttpPost]
          public async Task<IActionResult> SignUp(UserDto u)
          {
              if (!ModelState.IsValid)
              {
                 // Alert("Sign Up Unsuccesful!", NotificationType.error);
                  ModelState.AddModelError("", "UserName/Password is incorrect");
                  return View();
              }
              Account user = new Account();
              
              user.UserName = u.Username;
              user.Email = u.Email;
            //if User SignUp is successful
            var signUp = await _account.Signupp(user, u.Password);

              if (signUp)
              {
              
                    //Alert("Account Created successfully.", NotificationType.success);
                    return RedirectToAction("login", "Account");
              }
              return View();
          }

        [HttpGet]
        public  IActionResult SignUp()
        {
            ViewBag.role = _context.Roless.ToList();
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
