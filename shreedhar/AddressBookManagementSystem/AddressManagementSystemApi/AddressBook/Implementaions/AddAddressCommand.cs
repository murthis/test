using AddressManagementSystemApi.AddressBook.Commands;
using AddressManagementSystemApi.AddressBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressManagementSystemApi.AddressBook.Implementaions
{
    public class AddAddressCommand : ICommand<AddAddressCommandContext>
    {
        public void ExecuteCommand(AddAddressCommandContext command)
        {            
            var data = System.IO.File.ReadAllText(@"D:\shreedhar\AddressBookManagementSystem\AddressManagementSystemApi\AddressBook\Implementaions\AddressBookData.json");
            if (!string.IsNullOrWhiteSpace(data))
            {
                var addresses = Newtonsoft.Json.JsonConvert.DeserializeObject<IList<Models.AddressBook>>(data);
                addresses.Add(Map(command));
                var newdata = Newtonsoft.Json.JsonConvert.SerializeObject(addresses);
                System.IO.File.Delete(@"D:\shreedhar\AddressBookManagementSystem\AddressManagementSystemApi\AddressBook\Implementaions\AddressBookData.json");
                System.IO.File.WriteAllText(@"D:\shreedhar\AddressBookManagementSystem\AddressManagementSystemApi\AddressBook\Implementaions\AddressBookData.json", newdata);
            }
        }

        private Models.AddressBook Map(AddAddressCommandContext context)
        {
            Random rnd = new Random();
            int id = rnd.Next(1, 1000000);
            return new Models.AddressBook
            {
                Id = id,
                Name = context.Name,
                City = context.City,
                District = context.District,
                Postcode = context.Postcode,
                State = context.State,
                StreetName = context.StreetName,
                StreetNumber = context.StreetName
            };
        }
    }
}
