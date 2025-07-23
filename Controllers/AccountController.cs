using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Auth_oct210725.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddStudent()
        {
            return View();
        }
        public ActionResult setRole()
        {
            return View();
        }
    }
}