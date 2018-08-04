using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PasswordAfterMailConfirmation.Models;

namespace PasswordAfterMailConfirmation.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
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
        [Authorize]
        public ActionResult Test()
        {
            if(User.Role.Equals("Admin"))
            {
                return View(db.Book.ToList());
            }
            else if (User.Role.Equals("User"))
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}