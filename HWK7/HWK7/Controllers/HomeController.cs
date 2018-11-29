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
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GiphySticker(int lastWord)
        {
            // gets the API key and builds the URL to Giphy's translate Endpoint using that key.
            string giphyAPIKey = System.Web.Configuration.WebConfigurationManager.AppSettings["GiphyAPIKey"];
            string giphyURL = "https://api.giphy.com/v1/stickers/translate?&api_key=" + giphyAPIKey + "&s=" + lastWord;

            // creates a request and gets a response using the above URL
            WebRequest request = WebRequest.Create(giphyURL);
            WebResponse response = request.GetResponse();

            // converts the response into a readable format and parses the Json returned from Giphy
            Stream giphyStream = response.GetResponseStream();
            var giphyString = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<Object>(new StreamReader(giphyStream).ReadToEnd());

            // closes the streams
            giphyStream.Close();
            response.Close();
            
            // returns the parsed object
            return Json(giphyString, JsonRequestBehavior.AllowGet);


        }
    }
}