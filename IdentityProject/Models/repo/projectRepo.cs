using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityProject.Models.repo
{
    public class projectRepo : IProjectRepo
    {
        private List<Project> _project;
        public projectRepo()
        {
            _project = new List<Project>()
            {
                new Project(){Id = 1 , name = "Mena" , ClientName = "Ahmed" ,salary = 2000},
                new Project(){Id = 2 , name = "Besho" , ClientName = "Mohamed" ,salary = 5000},
                new Project(){Id = 3 , name = "Beman" , ClientName = "Salah" ,salary = 3000},
            };
        }
        public Project GetProject(int Id)
        {
            return this._project.FirstOrDefault(p => p.Id == Id);
        }
    }
}
