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
        private double? mi;
        private string measurement;
        private string result;

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Converter()
        {
            Debug.WriteLine(Request.QueryString["miles"]);
            Debug.WriteLine(Request.QueryString["units"]);

            mi = Convert.ToDouble(Request.QueryString["miles"]);
            measurement = Request.QueryString["units"];
            double? total;

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

            result = mi + " miles is equal to " + total + " " + measurement;

            Debug.WriteLine(total);
            Debug.WriteLine(result);

            if (measurement != null)
            {
                ViewBag.measurement = measurement;
                ViewBag.result = result;
            }

            return View();
        }

       
    }
}