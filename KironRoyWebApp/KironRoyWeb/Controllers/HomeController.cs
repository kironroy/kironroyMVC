using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KironRoyWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Night()
        {
            return View();
        }

        public ActionResult Sketches()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public ActionResult About()
        {

            return View();
        }

        [Authorize(Roles = "User, Admin")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page";

            return View();
        }
    }
}