namespace HWK8.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Item
    {
        public int ID { get; set; }

        [Required]
        [StringLength(64)]
        public string Name { get; set; }

        [Required]
        [StringLength(128)]
        public string Description { get; set; }

        [Required]
        [StringLength(64)]
        public string Seller { get; set; }

        public int? BidID { get; set; }

        public virtual Bid Bid { get; set; }

        public virtual Seller Seller1 { get; set; }
    }
}
