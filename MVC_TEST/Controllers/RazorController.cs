using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_TEST.Controllers
{
    public class RazorController : Controller
    {
        // GET: Razor
        public ActionResult RazorStatement()
        {
            return View();
        }
    }
}