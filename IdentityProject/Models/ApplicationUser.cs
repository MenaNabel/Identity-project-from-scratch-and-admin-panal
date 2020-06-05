﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityProject.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Department { get; set; }
    }
}
