using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_TEST.Controllers
{
    public class PartialViewController : Controller
    {
        // GET: PartialView
        public ActionResult SimpleCard()
        {
            return View();
        }
    }
}