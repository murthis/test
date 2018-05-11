using AddressManagementSystemApi.AddressBook.Interfaces;
using AddressManagementSystemApi.AddressBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace AddressManagementSystemApi.AddressBook.Implementaions
{
    public class GetAllAddressBookQuery : IQueryAll<IEnumerable<Models.AddressBook>>
    {
        public IEnumerable<Models.AddressBook> QueryAll()
        {             
            var data = System.IO.File.ReadAllText(@"D:\shreedhar\AddressBookManagementSystem\AddressManagementSystemApi\AddressBook\Implementaions\AddressBookData.json");
            if (!string.IsNullOrWhiteSpace(data))
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Models.AddressBook>>(data);
            }

            return Enumerable.Empty<Models.AddressBook>();
        }
    }
}