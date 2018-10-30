using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HWK5.DAL;
using HWK5.Models;

namespace HWK5.Controllers
{
    /// <summary>
    /// The controller class that handles the Home page, the RequestForm page, and the ViewRequests page
    /// </summary>
    public class HomeController : Controller
    {
        // creates an instance of the RequestContext, allows access to the database.
        private RequestContext db = new RequestContext();

        /// <summary>
        /// Controller method that generates the Home, or Index, page
        /// </summary>
        /// <returns>The view for the Home page</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// HttpGet Controller method that returns the view for the RequstForm page. This page is the blank form.
        /// </summary>
        /// <returns>The View for the RequestForm page</returns>
        [HttpGet]
        public ActionResult RequestForm()
        {
            return View();
        }

        /// <summary>
        /// HttpPost method for the RequestForm page. Takes in a Request object with the given parameters, and if they create 
        /// a valid Model object, adds them to the database and saves the changes and redirects to the ViewRequests. If the 
        /// ModelState was not valid, meaning that some information is missing or not the right type, return the view with the 
        /// information given (will give error messages telling user what is missing)
        /// Controller method
        /// </summary>
        /// <param name="request">A Request object that is to be added to the database</param>
        /// <returns>If ModelState is Valid, redirect to ViewRequests method, if not return the RequestForm view partially
        /// filled out with the information that was given</returns>
        [HttpPost]
        public ActionResult RequestForm([Bind(Include = "ID, FirstName, LastName, PhoneNumber, ApartmentName, UnitNumber, Explanation, ")] Request request)
        {
            if(ModelState.IsValid)
            {
                db.Requests.Add(request);
                db.SaveChanges();
                return RedirectToAction("ViewRequests");
            }

            return View(request);
        }

        /// <summary>
        /// Controller method that returns the View for the ViewRequest page. The View takes in the database entries in 
        /// ascending order
        /// </summary>
        /// <returns>The View for the ViewRequests page</returns>
        public ActionResult ViewRequests()
        {
            return View(db.Requests.OrderBy(x => x.CurrTime).ToList());
        }
    }
}