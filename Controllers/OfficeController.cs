using Auth_oct210725.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Auth_oct210725.Controllers
{
    public class OfficeController : Controller
    {
        // GET: Office
        public ActionResult Index()
        {
            using (var dbo = new DB_authentication_authorisation_Oct_210725Entities1())
            {
                List<tblLogin> lglist = dbo.tblLogins.ToList();


                return View(lglist);
            }
        }
        public ActionResult Home()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(tblLogin lg)
        {
            var dbo = new DB_authentication_authorisation_Oct_210725Entities1();
            var login1 = dbo.tblLogins.FirstOrDefault(x => x.UserName == lg.UserName && x.Password == lg.Password);
            if (login1!=null)
            {
                FormsAuthentication.SetAuthCookie(lg.UserName, false);
                return RedirectToAction("index");
            }
            return View();
        }
        [HttpGet]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("login");
        }
    }
}