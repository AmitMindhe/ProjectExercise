using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectExercise.Core.Common;
using ProjectExercise.Core;

namespace ProjectExercise.Service
{
    public interface IContactService
    {
        IList<Contact> GetAll();
        void Insert(Contact entity);
        void Update(Contact entity);
        void Delete(Contact entity);
        Contact GetById(int id);
    }
}
