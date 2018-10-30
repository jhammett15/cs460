using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HWK5.Models
{
    /// <summary>
    /// Model class that defines all of the input elements in the database and gives restricions to them
    /// </summary>
    public class Request
    {
        /// <summary>
        /// The primary key, is not displayed anywhere but the database
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// The FirstName property in the database, it is a required field with a maximum length of 15
        /// </summary>
        [Required(ErrorMessage = "Please enter your first name")]
        [StringLength(15)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        // <summary>
        /// The LastName property in the database, it is a required field with a maximum length of 15
        /// </summary>
        [Required(ErrorMessage = "Please enter your last name")]
        [StringLength(15)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        /// <summary>
        /// The PhoneNumber property in the database, it is a required field of type PhoneNumber, the format of which is 
        /// described by the regular expression.
        /// </summary>
        [Required(ErrorMessage = "Please enter your ten digit phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\d{10})$")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        // <summary>
        /// The ApartmentName property in the database, it is a required field with a maximum length of 30
        /// </summary>
        [Required(ErrorMessage = "Please enter your apartment name")]
        [StringLength(30)]
        [Display(Name = "Apartment Name")]
        public string ApartmentName { get; set; }

        // <summary>
        /// The UnitNumber property in the database, it is a required field
        /// </summary>
        [Required(ErrorMessage = "Please enter your unit number")]
        [Display(Name = "Unit Number")]
        public int UnitNumber { get; set; }

        // <summary>
        /// The Explanation property in the database, it is a required field with a maximum length of 250
        /// </summary>
        [Required(ErrorMessage = "Please enter your request")]
        [StringLength(250)]
        public string Explanation { get; set; }

        /// <summary>
        /// The CurrTime property in the database, not gotten from the form but is set to the Current Time in this class
        /// </summary>
        [Required]
        public DateTime CurrTime { get; set; }

        /// <summary>
        /// A ToString method which prints out the FirstName, LastName, PhoneNumber, ApartmentName, UnitNumber, and Explanation
        /// properties.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()} {FirstName} {LastName} {PhoneNumber} {ApartmentName} {UnitNumber} {Explanation}";
        }

        /// <summary>
        /// A Constructor method that sets the CurrTime property to the current time
        /// </summary>
        public Request()
        {
            CurrTime = DateTime.Now;
        }
    }
}