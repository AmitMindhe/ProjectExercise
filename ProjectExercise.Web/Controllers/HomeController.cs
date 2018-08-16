using ProjectExercise.Core.Common;
using ProjectExercise.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectExercise.Web.Controllers
{
    public class HomeController : BaseController
    {
          private readonly IContactService _contactService;

          public HomeController(IContactService contactService)
        {
            _contactService = contactService;
        }
        
        public ActionResult Index()
        {
            var list = _contactService.GetAll().Select(p => p.ToViewModel<Contact, ContactViewModel>()).ToList();

            if (list.Count == 0)
            {
                list.Add(new ContactViewModel());
            }
            return View(list);
        }
       
        public ActionResult Error(HandleErrorInfo model)
        {
            return View();
        }

        public ActionResult PageNotFound()
        {
            return View();
        }
    }
}
