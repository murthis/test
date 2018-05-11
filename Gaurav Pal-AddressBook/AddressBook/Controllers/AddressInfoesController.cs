using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AddressBook;

namespace AddressBook.Controllers
{
    public class AddressInfoesController : Controller
    {
        private AddressBookEntities db = new AddressBookEntities();

        // GET: AddressInfoes
        public ActionResult Index()
        {
            return View(db.AddressInfoes.ToList());
        }

        // GET: AddressInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddressInfo addressInfo = db.AddressInfoes.Find(id);
            if (addressInfo == null)
            {
                return HttpNotFound();
            }
            return View(addressInfo);
        }

        // GET: AddressInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddressInfoes/Create
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AddressId,AddressName,AddressNearbyPlace")] AddressInfo addressInfo)
        {
            if (ModelState.IsValid)
            {
                db.AddressInfoes.Add(addressInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(addressInfo);
        }

        // GET: AddressInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddressInfo addressInfo = db.AddressInfoes.Find(id);
            if (addressInfo == null)
            {
                return HttpNotFound();
            }
            return View(addressInfo);
        }

        // POST: AddressInfoes/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AddressId,AddressName,AddressNearbyPlace")] AddressInfo addressInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(addressInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(addressInfo);
        }

        // GET: AddressInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddressInfo addressInfo = db.AddressInfoes.Find(id);
            if (addressInfo == null)
            {
                return HttpNotFound();
            }
            return View(addressInfo);
        }

        // POST: AddressInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AddressInfo addressInfo = db.AddressInfoes.Find(id);
            db.AddressInfoes.Remove(addressInfo);
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
