using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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
        private readonly IAccount _account;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<Account> _signInManager;

        public AccountController(IAccount account, SignInManager<Account> signInManager,RoleManager<IdentityRole> roleManager)
        {
            _account = account;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
               // Alert("Login Unsuccesful!", NotificationType.error);
                ModelState.AddModelError("", "UserName/Password is incorrect");
                return View();
            }
            var signin = await _account.LoginIn(login);
            if (signin)
            {
               // Alert("Login successful.", NotificationType.success);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        //////////

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

            var signUp = await _account.Signupp(user, u.Password);

            if (signUp)
            {
                //Alert("Account Created successfully.", NotificationType.success);
                return RedirectToAction("login", "Account");
            }
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
