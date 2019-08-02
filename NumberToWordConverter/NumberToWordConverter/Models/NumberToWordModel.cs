using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NumberToWordConverter.Models
{
    public class NumberToWordModel
    {
        [Required(ErrorMessage = "Please enter valid Number")]
        [Display(Name = "Enter Number")]
        public long Number { get; set; }

        public string OutPut { get; set; }
    }
}