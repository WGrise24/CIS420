using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStart.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Info()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }
    }
}