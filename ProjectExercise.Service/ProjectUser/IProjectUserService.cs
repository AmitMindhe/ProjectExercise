using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectExercise.Core.Common;
using ProjectExercise.Core;

namespace ProjectExercise.Service
{
    public interface IProjectUserService
    {
        IList<ProjectUser> GetAll();
        void Insert(ProjectUser entity);
        void Update(ProjectUser entity);
        void Delete(ProjectUser entity);
        ProjectUser GetById(int id);
    }
}
