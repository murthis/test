using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AddressBookApi.Models
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            base.Seed(context);

            var address1 = new AddressBook {
                 FirstName="Vital", LastName="Maddali", Email="Vital.maddali@gmail.com", Address="Bangalore"
            };
            
            context.AddressBooks.Add(address1);
            context.SaveChanges();
        }
    }
}