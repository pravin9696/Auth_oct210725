using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Auth_oct210725.Controllers
{
  
    public class HODController : Controller
    {
        // GET: HOD
        public ActionResult Index()
        {
            return View();
        }
        //only HOD
        [Authorize(Roles = "HOD")]
        public ActionResult CancleAdmission()
        {
            return View();
        }
    }
}