using ProjectExercise.Core.Common;
using ProjectExercise.Data;
using ProjectExercise.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ProjectExercise.Web.Controllers
{
    public class ContactController : ApiController
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
       
        [Route("api/Contact/Insert")]
        [HttpPost] 
        public ContactViewModel Insert(ContactViewModel _contact)
        {
            var contact = _contact.ToCoreEntity<ContactViewModel, Contact>();
            _contactService.Insert(contact);
            return _contact;
        }

        [Route("api/Contact/Update")]
        [HttpPost] 
        public bool Update(ContactViewModel _contact)
        {
            var contact = _contactService.GetById(_contact.Id);
            contact.FirstName = _contact.FirstName;
            contact.LastName = _contact.LastName;
            contact.PhoneNumber = _contact.PhoneNumber;
            contact.Status = _contact.Status;
            contact.EmailId = _contact.EmailId;
            _contactService.Update(contact);
            return true;
        }
          [Route("api/Contact/Delete")]
          [HttpPost] 
        public void Delete(ContactViewModel _contact)
        {
            var contact = _contactService.GetById(_contact.Id);
            _contactService.Delete(contact);
        }
    }
}
