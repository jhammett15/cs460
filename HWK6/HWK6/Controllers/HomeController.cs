using HWK6.Models;
using HWK6.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HWK6.Controllers
{
    public class HomeController : Controller
    {
        private WWImportersContext db = new WWImportersContext();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Task1(string person)
        {
            return View(db.People
                        .Where(name => name.SearchName.Contains(person))
                        .OrderBy(name => name.FullName));
        }
    }
}