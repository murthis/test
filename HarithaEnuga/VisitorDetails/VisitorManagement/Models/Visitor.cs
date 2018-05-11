using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VisitorManagement.Models
{
    public class Visitor
    {
        public int VisitorId { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string VisitorName { get; set; }
        [Required]
        [Phone]
        public int ContactNo { get; set; }
        [Required]
        [EmailAddress]
        public string EMail { get; set; }
        public string Address { get; set; }
    }
}