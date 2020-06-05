using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityProject.Models.repo;
using Microsoft.AspNetCore.Mvc;

namespace IdentityProject.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectRepo _projectRepo;
        public ProjectController(IProjectRepo projectRepo)
        {
            _projectRepo = projectRepo;

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}