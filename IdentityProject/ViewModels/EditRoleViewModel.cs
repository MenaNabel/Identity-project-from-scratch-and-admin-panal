﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityProject.ViewModels
{
    public class EditRoleViewModel
    {
        public List<string> Users { get; set; }
        public string Id { get; set; }
        [Required(ErrorMessage = "Role Name is required")]
        public string RoleName { get; set; }
        public EditRoleViewModel()
        {
            Users = new List<string>();
        }


    }
}
