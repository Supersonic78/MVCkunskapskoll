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
        static List<PersonModel> adressBok = new List<PersonModel>();
        public ActionResult Index()
        {
            PersonModel newAdressBok = new PersonModel();
            return View(newAdressBok);
        }
        [HttpPost]
        public ActionResult Create(PersonModel adressbok)
        {
            adressbok.Date = DateTime.Now;
            adressBok.Add(adressbok);
            return PartialView("List", adressBok);
        }
        public ActionResult ListaAlla()
        {
            return PartialView("List", adressBok);
        }
        [HttpPost]
        public ActionResult Delete(Guid id)
        {
            var delete = adressBok.First(x => x.ID == id);
            adressBok.Remove(delete);
            return PartialView("List", adressBok);
        }
    }
 
}