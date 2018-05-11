using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VisitorDetails.Models;

namespace VisitorManagement.Controllers
{
    public class VisitorController : Controller
    {
        // GET: Visitor
        public ActionResult Index()
        {
            VisitorClient CC = new VisitorClient();
            ViewBag.listVisitors = CC.findAll();
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public ActionResult Create(VisitorViewmodel cvm)
        {
            VisitorClient CC = new VisitorClient();
            CC.Create(cvm.visitor);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            VisitorClient CC = new VisitorClient();
            CC.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            VisitorClient CC = new VisitorClient();
            VisitorViewmodel CVM = new VisitorViewmodel();
            CVM.visitor = CC.find(id);
            return View("Edit", CVM);
        }       
    }
}