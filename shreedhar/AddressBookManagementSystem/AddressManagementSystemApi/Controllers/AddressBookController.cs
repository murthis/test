namespace AddressManagementSystemApi.Controllers
{
    using AddressBook.Implementaions;
    using AddressManagementSystemApi.AddressBook.Commands;
    using AddressManagementSystemApi.AddressBook.Interfaces;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public class AddressBookController : ApiController
    {
        private readonly IQueryAll<IEnumerable<AddressBook.Models.AddressBook>> getAllAddressQuery;
        private readonly ICommand<AddAddressCommandContext> addAddressCommand;
        private readonly ICommand<UpdateAddressCommandContext> updateAddressCommand;
        private readonly ICommand<DeleteAddressCommandContext> delteAddressCommand;

        public AddressBookController()
        {
            // These dependencies can be injected with DI frameworks such as structuremap, castle windsor etc. 
            // Due to time constraint I hvae manually instantiated them.
            this.getAllAddressQuery = new GetAllAddressBookQuery();
            this.addAddressCommand = new AddAddressCommand();
            this.updateAddressCommand = new UpdateAddressCommand();
            this.delteAddressCommand = new DeleteAddressCommand();
        }

        /// <summary>
        /// Gets all addresses from the source.
        /// </summary>
        /// <returns>Returns all addresses from the data source.</returns>
        public HttpResponseMessage Get()
        {
            var addresses = this.getAllAddressQuery.QueryAll();
            return this.Request.CreateResponse(HttpStatusCode.OK, addresses);
        }

        /// <summary>
        /// Adds the new posted address record to the data source.
        /// </summary>
        /// <param name="address">Posted address details</param>
        /// <returns>Returns Http response message.</returns>
        public HttpResponseMessage Post(AddressBook.Models.AddressBook address)
        {
            var context = new AddAddressCommandContext
            {                
                Name = address.Name,
                City = address.City,
                District = address.District,
                Postcode = address.Postcode,
                State = address.State,
                StreetName = address.StreetName,
                StreetNumber = address.StreetName
            };

            this.addAddressCommand.ExecuteCommand(context);
            return this.Request.CreateResponse(HttpStatusCode.Created);
        }

        /// <summary>
        /// Updates the given address details.
        /// </summary>
        /// <param name="address">Given address detals to update.</param>
        /// <returns></returns>
        public HttpResponseMessage Put(AddressBook.Models.AddressBook address)
        {
            var context = new UpdateAddressCommandContext { };
            this.updateAddressCommand.ExecuteCommand(context);
            return this.Request.CreateResponse(HttpStatusCode.OK);
        }

        /// <summary>
        /// Deletes the given address details from the data source.
        /// </summary>
        /// <param name="addressId">Address Id to be deleted.</param>
        /// <returns></returns>
        public HttpResponseMessage Delete([FromUri]int addressId)
        {
            var context = new DeleteAddressCommandContext { };
            this.delteAddressCommand.ExecuteCommand(context);
            return this.Request.CreateResponse(HttpStatusCode.NoContent);
        }
    }
}
