using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HWK7.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GiphySticker(int lastWord)
        {
            string giphyAPIKey = System.Web.Configuration.WebConfigurationManager.AppSettings["GiphyAPIKey"];
            string giphyURL = "https://api.giphy.com/v1/stickers/translate?&api_key=" + giphyAPIKey + "&s=" + lastWord;

            WebRequest request = WebRequest.Create(giphyURL);
            WebResponse response = request.GetResponse();

            Stream giphyStream = response.GetResponseStream();
            var giphyString = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<Object>(new StreamReader(giphyStream).ReadToEnd());

            return Json(giphyString, JsonRequestBehavior.AllowGet);


        }
    }
}