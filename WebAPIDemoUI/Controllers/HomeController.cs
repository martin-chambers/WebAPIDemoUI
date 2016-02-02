using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPIDemoUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This application allows running a triggered webjob and gives access to the some of the external resources and documentation sources used.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "martinclivechambers@gmail.com";

            return View();
        }
    }
}