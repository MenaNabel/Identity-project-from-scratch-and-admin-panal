using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityProject.Models.repo
{
    public interface IProjectRepo
    {
        Project GetProject(int Id);
    }
}
