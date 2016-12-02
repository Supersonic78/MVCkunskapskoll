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
        public ActionResult Create(PersonModel addressbook)
        {
            addressbook.Date = DateTime.Now;
            ListofPersons.Add(addressbook);
            return PartialView("List", ListofPersons);
        }
        public ActionResult ListAll()
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
        public ActionResult Edit(PersonModel addressbook)
        {
            var edit = ListofPersons.Find(x => x.ID == addressbook.ID);
            return PartialView("Edit", edit);
        }
        [HttpPost]
        public ActionResult Edit(PersonModel addressbook, FormCollection formcollection)
        {
            var edit = ListofPersons.Find(x => x.ID == addressbook.ID);
            edit.Name = addressbook.Name;
            edit.Address = addressbook.Address;
            edit.PhoneNumber = addressbook.PhoneNumber;
            return PartialView("List", ListofPersons);
        }
    }
 
}