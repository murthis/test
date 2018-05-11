using AddressBookApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AddressBookApi.Controllers
{
    public class AddressBookController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();
        
        public IHttpActionResult Get()
        {
            try
            {
                var result = db.AddressBooks.ToList(); 
                return Ok(result);
            }
            catch (Exception)
            { 
                return InternalServerError();
            }
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                var result = db.AddressBooks.Where(x => x.AddressBookId == id).SingleOrDefault();
                return Ok(result);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        // POST api/<controller>
        [HttpPost]
        public HttpResponseMessage Post([FromBody]AddressBook addressBook)
        {
            int result = 0;
            try
            {
                db.AddressBooks.Add(addressBook);
                db.SaveChanges();
                result = 1;
            }
            catch (Exception e)
            {
                result = 0;
            }
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
                     

        // PUT api/<controller>/5
        [HttpPut]
        public HttpResponseMessage Put(int id, [FromBody]AddressBook addressBook)
        {
            int result = 0;
            try
            {
                db.AddressBooks.Attach(addressBook);
                db.Entry(addressBook).State = EntityState.Modified;
                db.SaveChanges();
                result = 1;
            }
            catch (Exception e)
            {
                result = 0;
            }
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

       
        // DELETE api/<controller>/5
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            int result = 0;
            try
            {
                var adBook = db.AddressBooks.Where(x => x.AddressBookId == id).FirstOrDefault();
                db.AddressBooks.Attach(adBook);
                db.AddressBooks.Remove(adBook);
                db.SaveChanges();
                result = 1;
            }
            catch (Exception e)
            {
                result = 0;
            }
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}