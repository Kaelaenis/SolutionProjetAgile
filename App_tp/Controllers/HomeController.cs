using App_tp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App_tp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            User user = null;

            if (TempData["UserName"] != null)
            {
                user = new User
                {
                    Name = TempData["UserName"] as string,
                    FirstName = TempData["UserFirstname"] as string,
                    Role = TempData["UserRole"] as string
                };
            }

            ViewBag.User = user;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your login page.";

            return View();
        }
    }
}