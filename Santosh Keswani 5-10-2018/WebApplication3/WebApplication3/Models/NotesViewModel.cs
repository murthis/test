using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class NotesViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string notes { get; set; }
    }
}