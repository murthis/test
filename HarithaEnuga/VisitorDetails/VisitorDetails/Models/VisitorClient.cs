using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace VisitorDetails.Models
{
    public class VisitorClient
    {
        private string Base_URL = "http://localhost:53005/";

        public IEnumerable<Visitor> findAll()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("visitors").Result;

                if (response.IsSuccessStatusCode)
                {
                    IEnumerable<Visitor> r = response.Content.ReadAsAsync<IEnumerable < Visitor >> ().Result;
                    return r;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        public Visitor find(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("visitors/" + id).Result;

                if (response.IsSuccessStatusCode)
                    return response.Content.ReadAsAsync<Visitor>().Result;
                return null;
            }
            catch
            {
                return null;
            }
        }
        public bool Create(Visitor visitor)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PostAsJsonAsync("visitors", visitor).Result;
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
        public bool Edit(Visitor visitor)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PutAsJsonAsync("visitors/" + visitor.VisitorId, visitor).Result;
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.DeleteAsync("visitors/" + id).Result;
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
    }
}