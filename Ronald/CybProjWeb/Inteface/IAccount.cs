using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CybProjWeb.Entities;
using CybProjWeb.Models;

namespace CybProjWeb.Inteface
{
    public interface IAccount
    {
        Task<bool> LoginIn(LoginViewModel loginModel);
        Task<bool> Signupp(Account user, string password);
    }
}
