using ProjectExercise.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExercise.Data
{
    public class RepositoryService<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private IDbContext _context;

        public RepositoryService(IDbContext context)
        {
            _context = context;
        }

        private IDbSet<TEntity> Entities
        {
            get { return _context.Set<TEntity>(); }
        }

        public IQueryable<TEntity> Table
        {
            get { return Entities; }
        }

        public TEntity GetById(object id)
        {
            return Entities.Find(id);
        }

        public void Insert(TEntity entity)
        {
            if (entity.Created == default(DateTime) || entity.Created == null)
                entity.Created = DateTime.UtcNow;

            if (entity.Modified == default(DateTime) || entity.Modified == null)
                entity.Modified = DateTime.UtcNow;

            Entities.Add(entity);
            _context.SaveChanges();
        }

        public void Insert(List<TEntity> entities)
        {
            foreach (var entity in entities)
                Entities.Add(entity);

            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            Entities.Remove(entity);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }
    }
}
