using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityProject.Models
{
    public class Project
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please provide a value for Name field")]
        public string name { get; set; }
        public double salary { get; set; }
        [Required(ErrorMessage = "Please provide a value for Name field")]
        [Display(Name = "Client Name")]
        public string ClientName { get; set; }
    }
}
