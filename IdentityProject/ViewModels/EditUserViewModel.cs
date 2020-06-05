using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityProject.ViewModels
{
    public class EditUserViewModel
    {
        public string Id { get; set; }
        [Required]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public List<string> Claims { get; set; }
        public List<string> Roles { get; set; }


        public EditUserViewModel()
        {
            Claims = new List<string>();
            Roles = new List<string>();
        }
    }
}
