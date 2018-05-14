﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Entity
{
    public partial class BaseEntity
    {
        public DateTime DateCreated { get; set; }

       
        public string UserCreated { get; set; }

        public DateTime? DateModified { get; set; }

        
        public string UserModified { get; set; }

        public bool Deleted { get; set; }


    }
}
