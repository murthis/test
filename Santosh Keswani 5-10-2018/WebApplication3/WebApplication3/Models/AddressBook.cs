using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class AddressBook
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string address { get; set; }
        [Required]
        public string city { get; set; }

        [Required]
        [StringLength(6, MinimumLength = 6, ErrorMessage="Pincode must have length of 6")]
        public string pincode { get; set; }
    }
}