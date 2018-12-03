namespace HWK8.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bid
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bid()
        {
            Items = new HashSet<Item>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(64)]
        public string Item { get; set; }

        [Required]
        [StringLength(64)]
        public string Buyer { get; set; }

        public decimal Price { get; set; }

        public DateTime Timestamp { get; set; }

        public virtual Buyer Buyer1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Items { get; set; }
    }
}
