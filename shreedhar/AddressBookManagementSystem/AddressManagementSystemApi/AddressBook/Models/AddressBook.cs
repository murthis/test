namespace AddressManagementSystemApi.AddressBook.Models
{
    public class AddressBook
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