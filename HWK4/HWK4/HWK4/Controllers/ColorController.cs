using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HWK4.Controllers
{
    public class ColorController : Controller
    {
        [HttpPost]
        public ActionResult Create()
        {
            return View();
        }
    }
}