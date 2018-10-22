using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HWK4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult MileConverter()
        {
            double mi = Convert.ToDouble(Request.QueryString["miles"]);
            string measurement = Request.QueryString["units"];
            double total;
            string result;

            if(measurement == "millimeters")
            {
                total = mi * 1609.34 * 1000;
            }
            else
            {
                if(measurement == "centimeters")
                {
                    total = mi * 1609.34 * 100;
                }
                else
                {
                    if(measurement == "meters")
                    {
                        total = mi * 1609.34;
                    }
                    else
                    {
                        total = mi * 1.60934;
                    }
                }
            }

            if(mi != null && measurement != null)
            {
                result = mi + " miles is equal to " + total + " " + measurement + ".";
            }

            return View();
        }        
    }
}