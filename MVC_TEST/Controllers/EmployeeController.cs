using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_TEST.Models;

namespace MVC_TEST.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EmployeeList()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 10001, Name = "David", Phone = "0988-123422", Email = "david@gmail.com" },
                new Employee { Id = 10002, Name = "Mary", Phone = "0924-456789", Email = "mary@gmail.com" },
                new Employee { Id = 10003, Name = "Jonn", Phone = "0972-751791", Email = "john@gmail.com" },
                new Employee { Id = 10004, Name = "Cindy", Phone = "0921-751459", Email = "cindy@gmail.com" },
                new Employee { Id = 10005, Name = "Rose", Phone = "0908-158813", Email = "rose@gmail.com" },
            };

            return View(employees);
        }
    }
}
