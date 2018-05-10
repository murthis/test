﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignments.Models;
using Assignments.DataAccess;

namespace Assignments.Controllers
{
    public class AddressBookController : Controller
    {
        // GET: AddressBook
        public ActionResult Index()
        {
            DAAddressBook _DataAccess = new DAAddressBook();

            List<AddressBookModels> _AddressBookModels = _DataAccess.GetAddressBook();
            //_AddressBookModels.Add(new AddressBookModels() { Address = "address", CityName = "Bangalore", StateName="Karnataka", ContactNumber = "1234", PersonName = "Name 1" });
            //_AddressBookModels.Add(new AddressBookModels() { Address = "address 1", CityName = "Mysore", StateName = "Karnataka", ContactNumber = "5678", PersonName = "Name 2" });
            return View(_AddressBookModels);
        }

        // GET: AddressBook/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AddressBook/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddressBook/Create
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

        // GET: AddressBook/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AddressBook/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                
                return RedirectToAction("Edit");
            }
            catch
            {
                return View();
            }
        }

        // GET: AddressBook/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AddressBook/Delete/5
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
