using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWK8.Models.ViewModels
{
    public class AuctionVM
    {
        public IEnumerable<Item> Item { get; set; }
        public IEnumerable<Seller> Seller { get; set; }
        public IEnumerable<Buyer> Buyer { get; set; }
        public IEnumerable<Bid> Bid { get; set; }
    }
}