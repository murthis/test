using AddressManagementSystemApi.AddressBook.Commands;
using AddressManagementSystemApi.AddressBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AddressManagementSystemApi.AddressBook.Implementaions
{
    public class DeleteAddressCommand : ICommand<DeleteAddressCommandContext>
    {
        public void ExecuteCommand(DeleteAddressCommandContext command)
        {
            
        }
    }
}