using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Visitor_Management;
using VisitorBL;
using VisitorDAL;

namespace Visitor_Management.Controllers
{
    public class VisitorsController : Controller
    {
        VisitorManagementBL visitorManagementBL = new VisitorManagementBL();
        // GET: Visitors
        public ActionResult Index()
        {
            try
            {
                return View(visitorManagementBL.GetVisitorList());
            }
            catch (Exception ex)
            { throw ex; }
        }

        // GET: Visitors/Details/5
        public ActionResult Details(int? id)
        {
            try
            {
                if((id ?? 0) > 0)
                {
                    VisitorDAL.Visitor visitor = visitorManagementBL.getVisitorById(id ?? 0);
                    if (visitor == null)
                    {
                        return HttpNotFound();
                    }
                    return View(visitor);
                }
                else
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        // GET: Visitors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Visitors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VisitorId,VisitorName,ContactNo,EMail,Address,Purpose,meetingPerson")] Visitor visitor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    visitorManagementBL.AddEditVisitor(visitor);
                    return RedirectToAction("Index");
                }
                return View(visitor);
            }
            catch (Exception ex)
            { throw ex; }
        }

        // GET: Visitors/Edit/5
        public ActionResult Edit(int? id)
        {
            try
            {
                if ((id ?? 0) > 0)
                {
                    VisitorDAL.Visitor visitor = visitorManagementBL.getVisitorById(id ?? 0);
                    if (visitor == null)
                    {
                        return HttpNotFound();
                    }
                    return View(visitor);
                }
                else
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        // POST: Visitors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VisitorId,VisitorName,ContactNo,EMail,Address,Purpose,meetingPerson")] Visitor visitor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    visitorManagementBL.AddEditVisitor(visitor);
                    return RedirectToAction("Index");
                }
                return View(visitor);
            }
            catch (Exception ex)
            { throw ex; }
        }

        // GET: Visitors/Delete/5
        public ActionResult Delete(int? id)
        {
            try
            {
                if ((id ?? 0) > 0)
                {
                    VisitorDAL.Visitor visitor = visitorManagementBL.getVisitorById(id ?? 0);
                    if (visitor == null)
                    {
                        return HttpNotFound();
                    }
                    return View(visitor);
                }
                else
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        // POST: Visitors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                visitorManagementBL.DeleteVisitor(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            { throw ex; }
        }

        

        protected override void OnException(ExceptionContext filterContext)
        {
            Exception exception = filterContext.Exception;
            filterContext.ExceptionHandled = true;
            var exceptionResult = this.View("error", new HandleErrorInfo(exception, filterContext.RouteData.Values["controller"].ToString(),
                filterContext.RouteData.Values["action"].ToString()));
            filterContext.Result = exceptionResult;
        }
    }
}
