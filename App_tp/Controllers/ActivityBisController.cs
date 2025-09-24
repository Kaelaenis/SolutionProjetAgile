using System.Collections.Generic;
using System.Web.Mvc;
using App_tp.Models;

namespace App_tp.Controllers
{
    public class ActivityBisController : Controller
    {
        private static List<Activity> activities = new List<Activity>();

        public ActionResult AddActivity()
        {
            return View(activities);
        }

        [HttpPost]
        public ActionResult Add()
        {
            activities.Add(new Activity(Request.Form["activityName"], Request.Form["categoryName"]));
            return RedirectToAction("AddActivity");
        }

        public ActionResult EditActivity()
        {
            return View();
        }

        public ActionResult CreateFolder()
        {
            return View();
        }

        public ActionResult AssignActivity()
        {
            return View();
        }
    }
}