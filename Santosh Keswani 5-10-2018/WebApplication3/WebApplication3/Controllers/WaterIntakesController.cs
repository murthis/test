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
    public class WaterIntakesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: WaterIntakes
        public ActionResult Index()
        {
            return View(db.WaterIntakes.ToList());
        }

        // GET: WaterIntakes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WaterIntake waterIntake = db.WaterIntakes.Find(id);
            if (waterIntake == null)
            {
                return HttpNotFound();
            }
            return View(waterIntake);
        }

        // GET: WaterIntakes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WaterIntakes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,numberOfGlassesConsumed,targetGlasses")] WaterIntake waterIntake)
        {
            if (ModelState.IsValid)
            {
                db.WaterIntakes.Add(waterIntake);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(waterIntake);
        }

        // GET: WaterIntakes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WaterIntake waterIntake = db.WaterIntakes.Find(id);
            if (waterIntake == null)
            {
                return HttpNotFound();
            }
            return View(waterIntake);
        }

        // POST: WaterIntakes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,numberOfGlassesConsumed,targetGlasses")] WaterIntake waterIntake)
        {
            if (ModelState.IsValid)
            {
                db.Entry(waterIntake).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(waterIntake);
        }

        // GET: WaterIntakes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WaterIntake waterIntake = db.WaterIntakes.Find(id);
            if (waterIntake == null)
            {
                return HttpNotFound();
            }
            return View(waterIntake);
        }

        // POST: WaterIntakes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WaterIntake waterIntake = db.WaterIntakes.Find(id);
            db.WaterIntakes.Remove(waterIntake);
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
