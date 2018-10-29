using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HWK5.Models
{
    public class Request
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter your first name")]
        [StringLength(15)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [StringLength(15)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your ten digit phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\d{10})$")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter your apartment name")]
        [StringLength(30)]
        [Display(Name = "Apartment Name")]
        public string ApartmentName { get; set; }

        [Required(ErrorMessage = "Please enter your unit number")]
        [Display(Name = "Phone Number")]
        public int UnitNumber { get; set; }

        [Required(ErrorMessage = "Please enter your request")]
        [StringLength(250)]
        public string Explanation { get; set; }

        [Required]
        public DateTime CurrTime { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} {FirstName} {LastName} {PhoneNumber} {ApartmentName} {UnitNumber}";
        }

        public Request()
        {
            CurrTime = DateTime.Now;
        }
    }
}