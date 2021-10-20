using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult O_nas()
        {
            ViewBag.Message = "Witaj na naszej stronie. W tym miejscu możesz wykonać wiele czynności online. Ne musisz nawet wychodzić z domu do nas!";

            return View();
        }

        public ActionResult Kontakt()
        {
            ViewBag.Message = "Dane kontaktowe.";

            return View();
        }


    }
}