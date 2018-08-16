using ProjectExercise.Core.Common;
using ProjectExercise.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExercise.Service
{
    public class ContactService : IContactService
    {
        private readonly IRepository<Contact> _repository;

        public ContactService(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public Contact GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IList<Contact> GetAll()
        {
            return _repository.Table.ToList();
        }

        #region crud
        public void Insert(Contact entity)
        {
            if (entity == null)
                throw new ArgumentNullException("Contact");

            _repository.Insert(entity);
        }

        public void Update(Contact entity)
        {
            if (entity == null)
                throw new ArgumentNullException("Contact");

            _repository.Update(entity);
        }

        public void Delete(Contact entity)
        {
            if (entity == null)
                throw new ArgumentNullException("Contact");

            _repository.Delete(entity);
        }
        #endregion crud
    }
}
