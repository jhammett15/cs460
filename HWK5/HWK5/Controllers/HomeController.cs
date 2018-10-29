using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HWK5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RequestForm()
        {
            ViewBag.Message = "Form to fill out a maintenance request.";

            return View();
        }

        public ActionResult ViewRequests()
        {
            ViewBag.Message = "All current requests.";

            return View();
        }
    }
}