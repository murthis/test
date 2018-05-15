using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NotesApp.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult ShowError(string errorMessage)
        {
            ViewBag.errorMessage = errorMessage;
            return View();
        }

    }
}
