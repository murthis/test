using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignments.Models
{
    public class AddressBookModels
    {
        public int AddressID { get; set; }
        public string PersonName { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string CityName { get; set; }
        public string StateName { get; set; }
    }
    public class StateModels
    {
        public string StateName { get; set; }
    }
    public class CityModels
    {
        public int StateID { get; set; }
        public string CityName { get; set; }
    }
}