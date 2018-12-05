using HWK8.Models;
using HWK8.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HWK8.Controllers
{
    public class HomeController : Controller
    {
        private AuctionContext db = new AuctionContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ItemList()
        {
            return View(db.Items.ToList());
        }

        [HttpGet]
        public ActionResult ItemCreate()
        {
            List<string> names = new List<string>();

            foreach(Seller i in db.Sellers)
            {
                names.Add(i.Name);
            }

            ViewBag.names = names;

            var item = db.Items;
            return View();
        }

        [HttpPost]
        public ActionResult ItemCreate([Bind(Include = "Name, Description, Seller")]Item item)
        {
            if(ModelState.IsValid)
            {
                db.Items.Add(item);
                db.SaveChanges();
                return RedirectToAction("ItemCreate");
            }

            return View(item);
        }

        [HttpGet]
        public ActionResult ItemDetails(int id)
        {
            var details = db.Items.Where(i => i.ID == id).FirstOrDefault();
            return View(details);
        }

        [HttpGet]
        public ActionResult ItemEdit(int id)
        {
            var details = db.Items.Where(i => i.ID == id).FirstOrDefault();
            return View(details);
        }

        [HttpPost]
        public ActionResult ItemEdit(int id, FormCollection collection)
        {
            try
            {
                var itemToUpdate = db.Items.Find(id);

                itemToUpdate.Name = collection["Name"];
                itemToUpdate.Description = collection["Description"];

                db.SaveChanges();

                return RedirectToAction("ItemList");

            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult ItemDelete(int id)
        {
            var details = db.Items.Where(i => i.ID == id).FirstOrDefault();
            return View(details);
        }

        [HttpPost]
        public ActionResult ItemDelete(int id, FormCollection collection)
        {
            try
            {
                db.Items.Remove(db.Items.Find(id));
                db.SaveChanges();

                return RedirectToAction("ItemList");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult CreateBid()
        {
            List<string> buyers = new List<string>();

            foreach (Buyer i in db.Buyers)
            {
                buyers.Add(i.Name);
            }

            ViewBag.buyers = buyers;
            
            return View();
        }

        [HttpPost]
        public ActionResult CreateBid([Bind(Include = "Item, Buyer, Price")]Bid bid)
        {
            if (ModelState.IsValid)
            {
                db.Bids.Add(bid);
                db.SaveChanges();
                return RedirectToAction("CreateBid");
            }

            return View(bid);
        }

        [HttpGet]
        public JsonResult BidsResult(int id)
        {
            var result = db.Items.Where(i => i.BidID == id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        
        private AuctionVM CreateAuctionVM()
        {
            AuctionVM auction = new AuctionVM
            {
                Seller = db.Sellers.ToList(),
                Item = db.Items.ToList(),
                Buyer = db.Buyers.ToList(),
                Bid = db.Bids.ToList()
            };

            return auction;
        }
    }
}