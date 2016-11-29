using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC2kunskapskoll.Models;
using System.Net;

namespace MVC2kunskapskoll.Controllers
{
    public class PersonController : Controller
    {
        static List<PersonModel> ListofPersons = new List<PersonModel>();
        public ActionResult Index()
        {
            PersonModel newAdressBok = new PersonModel();
            return View(newAdressBok);
        }
        [HttpPost]
        public ActionResult Create(PersonModel addressbok)
        {
            addressbok.Date = DateTime.Now;
            ListofPersons.Add(addressbok);
            return PartialView("List", ListofPersons);
        }
        public ActionResult ListaAlla()
        {
            return PartialView("List", ListofPersons);
        }
        [HttpPost]
        public ActionResult Delete(Guid id)
        {
            var delete = ListofPersons.First(x => x.ID == id);
            ListofPersons.Remove(delete);
            return PartialView("List", ListofPersons);
        }
    }
 
}