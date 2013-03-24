using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AFSDonations.Controllers
{
    public class InquiryController : Controller
    {
        //
        // GET: /Inquiry/

        public ActionResult Index()
        {
            ViewBag.ErrorMsg = "";
            return View();
        }

        //
        // POST: /Inquiry/
        [HttpPost]
        public ActionResult Index(FormCollection formCollection)
        {
            ViewBag.FirstName = formCollection["FirstName"];
            ViewBag.LastName = formCollection["LastName"];
            ViewBag.BlogUrl = formCollection["BlogUrl"];
            ViewBag.Amount = formCollection["Amount"];

            if (formCollection["FirstName"].Length != 0 && formCollection["LastName"].Length != 0 &&
                formCollection["Amount"].Length != 0)
            {
                return RedirectToAction("Reciept");
            }

            ViewBag.ErrorMsg = "Please fill out all fields.";
            return View();
        }

        public ActionResult Reciept()
        {
            return View();
        }
    }
}
