using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DocumentaryEvidence.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Task";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact info";

            return View();
        }
    }
}
