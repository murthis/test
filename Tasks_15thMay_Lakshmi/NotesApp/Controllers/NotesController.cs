using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NotesApp.Models;

namespace NotesApp.Controllers
{
    public class NotesController : Controller
    {
        private TestDB_Notes_DBFirstEntities db = new TestDB_Notes_DBFirstEntities();

        // GET: Notes
        public ActionResult Index()
        {
            return View(db.tbl_Notes.ToList());
        }

        // GET: Notes/Details/5
        [HandleError]
        public ActionResult Details(int? id)
        {
            tbl_Notes tbl_Notes = null;
            try
            {
                if (id == null)
                {
                    return RedirectToAction("ShowError", "Error", new { errorMessage = "Invalid Id..!" });
                }
                tbl_Notes = db.tbl_Notes.Find(id);
                if (tbl_Notes == null)
                {
                    return RedirectToAction("ShowError", "Error", new { errorMessage = "Requested Note is not present..!" });
                }
            }
            catch (Exception e)
            {
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError);
            }

            return View(tbl_Notes);
        }

        // GET: Notes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Notes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description")] tbl_Notes tbl_Notes)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.tbl_Notes.Add(tbl_Notes);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError);
            }
            return View(tbl_Notes);
        }

        // GET: Notes/Edit/5
        public ActionResult Edit(int? id)
        {
            tbl_Notes tbl_Notes = null;
            try
            {
                if (id == null)
                {
                    return RedirectToAction("ShowError", "Error", new { errorMessage = "Requested Note is not present..!" });
                }
                tbl_Notes = db.tbl_Notes.Find(id);
                if (tbl_Notes == null)
                {
                    return RedirectToAction("ShowError", "Error", new { errorMessage = "Note that you are trying to update is not present..!" });

                }
            }
            catch (Exception e)
            {
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError);
            }
            return View(tbl_Notes);
        }

        // POST: Notes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description")] tbl_Notes tbl_Notes)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(tbl_Notes).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError);
            }
            return View(tbl_Notes);
        }

        // GET: Notes/Delete/5
        public ActionResult Delete(int? id)
        {
            tbl_Notes tbl_Notes = null;
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                tbl_Notes = db.tbl_Notes.Find(id);
                if (tbl_Notes == null)
                {
                    return RedirectToAction("ShowError", "Error", new { errorMessage = "Note that your looking for to delete is not present..!" });
                }
            }
            catch (Exception e)
            {
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError);
            }
            return View(tbl_Notes);
        }

        // POST: Notes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Notes tbl_Notes = db.tbl_Notes.Find(id);
            db.tbl_Notes.Remove(tbl_Notes);
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
