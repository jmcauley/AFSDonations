using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AFSDonations.Models;

namespace AFSDonations.Controllers
{
    public class MainController : Controller
    {
        //
        // GET: /Main/

        public ActionResult Index()
        {
            ViewBag.WidgetName = "Alice";
            var donation = new Donation();
            return View(donation);
        }

        //
        // POST: /Main/Index
        [HttpPost]
        public ActionResult Index(Donation donation)
        {

            return View(donation);
        }
    }
}
