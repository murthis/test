using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class AddressBooksController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: AddressBooks
        public ActionResult Index()
        {
            return View(db.AddressBooks.ToList());
        }

        // GET: AddressBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddressBook addressBook = db.AddressBooks.Find(id);
            if (addressBook == null)
            {
                return HttpNotFound();
            }
            return View(addressBook);
        }

        // GET: AddressBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddressBooks/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,address,city,pincode")] AddressBook addressBook)
        {
            if (ModelState.IsValid)
            {
                db.AddressBooks.Add(addressBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(addressBook);
        }

        // GET: AddressBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddressBook addressBook = db.AddressBooks.Find(id);
            if (addressBook == null)
            {
                return HttpNotFound();
            }
            return View(addressBook);
        }

        // POST: AddressBooks/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,address,city,pincode")] AddressBook addressBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(addressBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(addressBook);
        }

        // GET: AddressBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddressBook addressBook = db.AddressBooks.Find(id);
            if (addressBook == null)
            {
                return HttpNotFound();
            }
            return View(addressBook);
        }

        // POST: AddressBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AddressBook addressBook = db.AddressBooks.Find(id);
            db.AddressBooks.Remove(addressBook);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
