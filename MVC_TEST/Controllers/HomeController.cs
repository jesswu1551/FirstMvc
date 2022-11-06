using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_TEST.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            if (User.Identity.Name != "john@gmail.com")
            {
                return Content($"{User.Identity.Name}帳號無權限存取此 Action 動作方法");
            }

            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize(Users = "kevin4267@gmail.com, mary@gmail.com")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize(Roles = "Admin, Supervisor")]
        public ActionResult Administrators()
        {
            return View();
        }
    }
}