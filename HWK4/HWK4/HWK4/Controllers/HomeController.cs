using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HWK4.Controllers
{
    /// <summary>
    /// A Controller for the Home page and the Mile Converter page. The home page, also called the Index page, is the landing site for the 
    /// project. It has links to both the Mile Converter page and the Color Chooser page. The Mile Converter page takes in a number 
    /// from the user as well as a radio button value via a HttpGet method and computes a mile conversion.
    /// </summary>
    public class HomeController : Controller
    {
        private double? mi;
        private string measurement;
        private string result;

        /// <summary>
        /// A Controller method that generates the "Home" or "Index" page of the project
        /// </summary>
        /// <returns>The View for the Index page.</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// A Controller method that retrieves a double representing the number of miles and a string representing the measurement to be 
        /// converted to from the View via a GET method. It then converts the miles, storing the result in a new variable. Finally it checks 
        /// so see if the measurement variable is not null. If it is null, this means that the input has not been submitted yet. If it is 
        /// not null, the input has ben submitted and it stores the measurement variable and result of the conversion in a ViewBag.
        /// </summary>
        /// <returns>The View for the Mile Converter page</returns>
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