using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HWK6.Models.ViewModels
{
    public class PersonDashboardVM
    {
        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        [Required]
        [StringLength(50)]
        public string PreferredName { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [StringLength(20)]
        public string FaxNumber { get; set; }

        [StringLength(256)]
        public string EmailAddress { get; set; }

        public DateTime ValidFrom { get; set; }

        public byte[] Photo { get; set; }
    }
}