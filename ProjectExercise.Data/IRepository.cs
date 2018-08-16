using ProjectExercise.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExercise.Data
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> Table { get; }

        TEntity GetById(object id);
        void Insert(TEntity entity);
        void Insert(List<TEntity> entities);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}