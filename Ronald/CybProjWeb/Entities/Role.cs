﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CybProjWeb.Entities
{
    public class Role : IdentityRole
    {
        public string RoleName { get; set; }    
    }
}