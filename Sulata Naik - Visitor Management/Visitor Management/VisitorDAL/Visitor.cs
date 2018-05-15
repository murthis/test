//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VisitorDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Visitor
    {
        public int VisitorId { get; set; }

        [Required]
        [Display(Name = "Visitor Name")]
        public string VisitorName { get; set; }

        [Display(Name = "Contact No")]
        public int ContactNo { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string EMail { get; set; }

        public string Address { get; set; }

        [Required]
        public string Purpose { get; set; }

        [Required]
        [Display(Name = "meeting Person")]
        public string meetingPerson { get; set; }
    }
}
