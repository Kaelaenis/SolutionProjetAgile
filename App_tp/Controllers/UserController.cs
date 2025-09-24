using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App_tp.Models;

namespace App_tp.Controllers
{
    public class UserController : Controller
    {

        [HttpPost]
        public ActionResult CreateUser()
        {
            User user = new User(Request.Form["name"], Request.Form["firstname"], Request.Form["role"]);

            TempData["UserName"] = user.Name;
            TempData["UserFirstname"] = user.FirstName;
            TempData["UserRole"] = user.Role;

            return RedirectToAction("Index", "Home");
        }
    }
}