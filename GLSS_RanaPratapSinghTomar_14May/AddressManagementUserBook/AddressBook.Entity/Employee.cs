using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AddressBook.Entity
{
    [Table("Employees")]
    public partial class Employees : BaseEntity
    {
        [Key]
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmployeeAddress { get; set; }
        public DateTime? JoiningDate { get; set; }

    }
}
