﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AddressBookManagementSystem.Models
{
    public class AddressBookModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string StreetNumber { get; set; }

        public string StreetName { get; set; }

        public string City { get; set; }

        public string District { get; set; }

        public string State { get; set; }

        public string Postcode { get; set; }
    }
}