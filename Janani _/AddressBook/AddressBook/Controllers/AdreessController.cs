using AddressBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AddressBook.Controllers
{
    public class AdreessController : Controller
    {
        // GET: Adreess
        public ActionResult Index()
        {
            return View();
        }

        public List<AddressModel> GetAddress()
        {
            DBContext db = new DBContext();
            return db.Sample.ToList();
        }

        // GET: Adreess/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Adreess/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Adreess/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Adreess/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Adreess/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Adreess/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Adreess/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
