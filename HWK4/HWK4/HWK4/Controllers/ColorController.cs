using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HWK4.Controllers
{
    /// <summary>
    /// A Controller class for the Color Converter page. The purpose of this page is to take in two colors from the user via a POST method, 
    /// add their hexadecimal values together, and return this new value.
    /// </summary>
    public class ColorController : Controller
    {
        /// <summary>
        /// Controller method that generates the Color Converter page
        /// </summary>
        /// <returns>the view for the color converter page</returns>
        public ActionResult Index()
        {
            return View();
        }
        
        /// <summary>
        /// Takes in two colors, converts them to hexadecimal, then uses them to render a third color. Then adds these colors to the 
        /// ViewBag and returns the View. The Debug.WriteLines are unnecessary to the view, but useful to see that the correct hexadecimal
        /// numbers are being returned.
        /// </summary>
        /// <param name="firstColor">A Color object, the first object chosen by the user</param>
        /// <param name="secondColor">A Color object, the second object chosen by the user</param>
        /// <returns>The View for the Create page</returns>
        [HttpPost]
        public ActionResult Create(Color firstColor, Color secondColor)
        {
            string color1hex = firstColor.R.ToString("X2") + firstColor.G.ToString("X2") + firstColor.B.ToString("X2");
            string color2hex = secondColor.R.ToString("X2") + secondColor.G.ToString("X2") + secondColor.B.ToString("X2");
            string color3hex = ColorAdd(firstColor, secondColor);

            ViewBag.color1 = color1hex;
            ViewBag.color2 = color2hex;
            ViewBag.color3 = color3hex;

            Debug.WriteLine(color1hex);
            Debug.WriteLine(color2hex);
            Debug.WriteLine(color3hex);

            return View();
        }

        /// <summary>
        /// Takes in two colors, separates them into their RGB components and adds these components together. If any of the components' 
        /// values are over 255 (max), then they default to 255. Then combines these separate RGB components into a hexadecimal string
        /// </summary>
        /// <param name="color1">A Color object, one of two that will be combined</param>
        /// <param name="color2">A Color object, one of two that will be combined.</param>
        /// <returns>A string representing the hexadecimal value of the two colors added together</returns>
        public string ColorAdd(Color color1, Color color2)
        {
            int r = color1.R + color2.R;
            int g = color1.G + color2.G;
            int b = color1.B + color2.B;

            if (r > 255)
                r = 255;
            if (g > 255)
                g = 255;
            if (b > 255)
                b = 255;

            string colorhex = r.ToString("X2") + g.ToString("X2") + b.ToString("X2");
            
            return colorhex;
        }
    }
}