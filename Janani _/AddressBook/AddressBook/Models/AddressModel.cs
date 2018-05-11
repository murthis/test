using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AddressBook.Models
{
    [Table("AddressTbl")]
    public class AddressModel
    {
        [Key]
        public string AddressLine { get; set; }
    }
}