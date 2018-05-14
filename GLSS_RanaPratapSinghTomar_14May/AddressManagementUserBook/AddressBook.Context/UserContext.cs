using AddressBook.DataAccess;
using AddressBook.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AddressBook.Context
{
    public class UserContext : BaseContext<UserContext>
    {
        public virtual DbSet<Employees> Employees { get; set; }


        public override int SaveChanges()
        {
            
          
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync()
        {
        
          
           
            return base.SaveChangesAsync();
        }



       
    }
}
