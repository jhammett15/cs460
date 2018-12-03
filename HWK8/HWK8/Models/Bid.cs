namespace HWK8.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bid
    {
        [Required]
        [StringLength(64)]
        public string Item { get; set; }

        [Required]
        [StringLength(64)]
        public string Buyer { get; set; }

        public decimal Price { get; set; }

        [Key]
        public DateTime Timestamp { get; set; }

        public virtual Buyer Buyer1 { get; set; }
    }
}
