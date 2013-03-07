using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AFSDonations.Models;
using AuthorizeNet;

namespace AFSDonations.Controllers
{
    public class MainController : Controller
    {
        //
        // GET: /Main/

        public ActionResult Index(Guid widgetId)
        {
            var donation = new Donation();

            using (var context = new AFSAdminContext())
            {
                var widget = context.StudentWidgets.Find(widgetId);
                donation.StudentWidget_StudentWidgetId = widgetId;
                donation.StudentWidget = widget;
                ViewBag.WidgetName = widget.FirstName;
            }
            return View(donation);
        }

        //
        // POST: /Main/Index
        [HttpPost]
        public ActionResult Index(Donation donation)
        {
            var request = new AuthorizationRequest(donation.CardNumber, donation.ExpMonth + donation.ExpYear, donation.Amount,
                "Test Transaction");

            //step 2 - create the gateway, sending in your credentials
            var gate = new Gateway("6zz6m5N4Et", "9V9wUv6Yd92t27t5", true);

            //step 3 - make some money
            var response = gate.Send(request);

            if (response.Approved)
            {
                donation.TransactionId = response.TransactionID;
                using (var context = new AFSAdminContext())
                {
                    var widget = context.StudentWidgets.Find(donation.StudentWidget_StudentWidgetId);
                    donation.StudentWidget = widget;
                    context.Donations.Attach(donation);
                    context.SaveChanges();

                }
                return RedirectToAction("Reciept");
            }

            return View(donation);
        }

        public ActionResult Reciept()
        {
            return View();
        }
    }
}
