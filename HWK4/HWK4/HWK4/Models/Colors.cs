using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace HWK4.Models
{
    public class Colors
    {
        [Required(ErrorMessage = "Please enter a first color")]
        public Color FirstColor { get; set; }

        [Required(ErrorMessage = "Please enter a second color")]
        public Color SecondColor { get; set; }

        
    }
}