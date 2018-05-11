using AddressBookManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace AddressBookManagementSystem
{
    public class HttpClientHelper
    {
        private const string baseAddress = "http://localhost:50426/";
        static HttpClient client = new HttpClient();

        public static async Task<IEnumerable<AddressBookModel>> GetAddressBookAsync(string path)
        {
            IEnumerable<AddressBookModel> address = null;
            HttpResponseMessage response = await client.GetAsync(baseAddress + path);
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                address = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<AddressBookModel>>(data);
            }
            return address;
        }

        public static async Task<Uri> CreateAddressBookAsync(string path, AddressBookModel address)
        {
            HttpContent body = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(address));
            body.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = await client.PostAsync(
                baseAddress + path, body);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }
    }
}