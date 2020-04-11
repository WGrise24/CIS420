using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStart.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Rooms()
        {
            return View();
        }

        public ActionResult Classes()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }
    }
}