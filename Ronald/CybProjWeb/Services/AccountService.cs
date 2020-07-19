using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CybProjWeb.Entities;
using CybProjWeb.Inteface;
using CybProjWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace CybProjWeb.Services
{
    public class AccountService :IAccount
    {
        private readonly SignInManager<Account> _signInManager;
        private readonly UserManager<Account> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private IConfiguration _config;
        public AccountService(SignInManager<Account> signInManager,
                                UserManager<Account> userManager,
                                RoleManager<Role> roleManager,
                                 IConfiguration config)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
            _config = config;
        }
        public async Task<bool> LoginIn(LoginViewModel loginDetails)
        {
            try
            {
                // check if user exist
                var checkUser = await _userManager.FindByEmailAsync(loginDetails.Email);
                if (checkUser != null)
                {
                    //signin user
                    var signInResult = await _signInManager.PasswordSignInAsync(checkUser, loginDetails.Password, false, false);
                    // check if signin is successful
                    if (signInResult.Succeeded)
                    {
                        return true;

                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<bool> Signupp(Account user, string password)
        {
            try
            {
                var checkmail = await _userManager.FindByEmailAsync(user.Email);
                if (checkmail == null)
                {
                    var signUpResult = await _userManager.CreateAsync(user, password);
                    if (signUpResult.Succeeded)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
