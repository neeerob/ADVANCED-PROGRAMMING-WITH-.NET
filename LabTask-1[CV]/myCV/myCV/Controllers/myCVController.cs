using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myCV.Controllers
{
    public class myCVController : Controller
    {
        // GET: myCV
        public ActionResult PersonalInfo()
        {
            return View();
        }
        public ActionResult Education()
        {
            return View();
        }
        public ActionResult Project()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}