using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AddressBook;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class AddressModelsController : Controller
    {
        private DBContext db = new DBContext();

        // GET: AddressModels
        public ActionResult Index()
        {
            return View(db.Sample.ToList());
        }

        // GET: AddressModels/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddressModel addressModel = db.Sample.Find(id);
            if (addressModel == null)
            {
                return HttpNotFound();
            }
            return View(addressModel);
        }

        // GET: AddressModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddressModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AddressLine")] AddressModel addressModel)
        {
            if (ModelState.IsValid)
            {
                db.Sample.Add(addressModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(addressModel);
        }

        // GET: AddressModels/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddressModel addressModel = db.Sample.Find(id);
            if (addressModel == null)
            {
                return HttpNotFound();
            }
            return View(addressModel);
        }

        // POST: AddressModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AddressLine")] AddressModel addressModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(addressModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(addressModel);
        }

        // GET: AddressModels/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddressModel addressModel = db.Sample.Find(id);
            if (addressModel == null)
            {
                return HttpNotFound();
            }
            return View(addressModel);
        }

        // POST: AddressModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            AddressModel addressModel = db.Sample.Find(id);
            db.Sample.Remove(addressModel);
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
