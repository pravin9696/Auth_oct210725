using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Auth_oct210725.Controllers
{
    [Authorize(Roles ="HOD,Student")]
    public class StudentController : Controller
    {
        
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        //HOD and Student allowed
        public ActionResult ShowDetails()
        {
            return View();
        }
        //only student allowed
        public ActionResult UpdateDetails()
        {
            return View();
        }
    }
}