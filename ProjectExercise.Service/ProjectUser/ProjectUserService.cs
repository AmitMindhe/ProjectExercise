using ProjectExercise.Core.Common;
using ProjectExercise.Core;
using ProjectExercise.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExercise.Service
{
    public class ProjectUserService : IProjectUserService
    {
        private readonly IRepository<ProjectUser> _repository;

        public ProjectUserService(IRepository<ProjectUser> repository)
        {
            _repository = repository;
        }

        public ProjectUser GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IList<ProjectUser> GetAll()
        {
            return _repository.Table.ToList();
        }

        #region crud
        public void Insert(ProjectUser entity)
        {
            if (entity == null)
                throw new ArgumentNullException("ProjectUser");

            _repository.Insert(entity);
        }

        public void Update(ProjectUser entity)
        {
            if (entity == null)
                throw new ArgumentNullException("ProjectUser");

            _repository.Update(entity);
        }

        public void Delete(ProjectUser entity)
        {
            if (entity == null)
                throw new ArgumentNullException("ProjectUser");

            _repository.Delete(entity);
        }
        #endregion crud
    }
}

