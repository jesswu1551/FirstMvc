using MVC_TEST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_TEST.Controllers
{
    public class PassDataController : Controller
    {
        // GET: PassData
        public ActionResult PetShop()
        {
            ViewData["Company"] = "汪星人寵物店";
            ViewBag.Address = "新竹縣新豐鄉池府路114號";

            List<string> petList = new List<string>();
            petList.Add("狗狗");
            petList.Add("貓咪");
            petList.Add("熱帶魚");
            petList.Add("天竺鼠");
            petList.Add("變色龍");

            return View(petList);
        }

        public ActionResult StrongTypeView()
        {
            //Employee employees = new Employee { Id = 10001, Name = "David", Phone = "0934-1233232", Email = "david@gmail.com" };
            Employee employees = new Employee { Id = 10001, Name = "David", Phone = "0934-1233232", Email = "david@gmail.com" };

            return View(employees);
        }

        public ActionResult StrongTypeViewList()
        {
            List<Employee> employees = new List<Employee>()
            {
                //new Employee { Name = "", Phone = "", Email = "" },
                new Employee { Id = 10004, Name = "Cindy", Phone = "0921-751459", Email = "cindy@gmail.com" },
                new Employee { Id = 10005, Name = "Rose", Phone = "0908-158813", Email = "rose@gmail.com" },
                new Employee { Id = 10005, Name = "Rose", Phone = "0908-158813", Email = "rose@gmail.com" },
                new Employee { Id = 10003, Name = "Jonn", Phone = "0972-751791", Email = "john@gmail.com" },
                //new Employee { Id = 10005, Name = "Rose", Phone = "0908-158813", Email = "rose@gmail.com" },
            };

            return View(employees);
        }
    }
}
