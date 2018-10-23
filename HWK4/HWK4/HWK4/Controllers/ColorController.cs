using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HWK4.Models;

namespace HWK4.Controllers
{
    public class ColorController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create()
        {
            return View();
        }

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