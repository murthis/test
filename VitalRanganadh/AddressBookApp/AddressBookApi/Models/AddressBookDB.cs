using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AddressBookApi.Models
{
    public class AddressBook
    {
       
        [Key]
        public int AddressBookId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Address { get; set; }
       
    }

    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection") { }

        public DbSet<AddressBook> AddressBooks { get; set; }
       
    }
}