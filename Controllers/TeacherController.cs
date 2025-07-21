using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Auth_oct210725.Controllers
{
    [Authorize(Roles ="HOD,Teacher")]
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }
        //HOD & Teacher only
        public ActionResult updateMarks()
        {
            return View();
        }

    }
}