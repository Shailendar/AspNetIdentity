using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using PasswordAfterMailConfirmation.Models;

namespace PasswordAfterMailConfirmation.Controllers
{
    public class BaseController : Controller
    {
        public PasswordDbContext db;

        public BaseController()
        {
            this.db = new PasswordDbContext();
        }
        protected virtual new CustomPrincipal User
        {
            get { return HttpContext.User as CustomPrincipal; }
        }
    }
}