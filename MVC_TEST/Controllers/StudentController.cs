using MVC_TEST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_TEST.Controllers
{
    public class StudentController : Controller
    {
        // 學生考試成績 Model 資料
        protected List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Joe", Chinese = 88, English = 95, Math = 71 },
            new Student { Id = 12, Name = "Mary", Chinese = 92, English = 82, Math = 60 },
            new Student { Id = 23, Name = "Cathy", Chinese = 98, English = 91, Math = 94 },
            new Student { Id = 34, Name = "John", Chinese = 63, English = 85, Math = 55 },
            new Student { Id = 45, Name = "David", Chinese = 59, English = 77, Math = 82 }
        };

        public ActionResult Scores()
        {
            return View(students);
        }

        public ActionResult CalcScores()
        {
            int topId = 0;
            int topScore = 0;

            foreach (var student in students)
            {
                student.Total = student.Chinese + student.Math + student.English;

                if (student.Total > topScore)
                {
                    topId = student.Id;
                    topScore = student.Total;
                }
            }

            ViewBag.topId = topId;
            ViewBag.topScore = topScore;

            return View(students);
        }

        public ActionResult CalcScoresPure()
        {
            int topId = 0;
            int topScore = 0;

            foreach (var student in students)
            {
                student.Total = student.Chinese + student.Math + student.English;

                if (student.Total > topScore)
                {
                    topId = student.Id;
                    topScore = student.Total;
                }
            }

            ViewBag.topId = topId;
            ViewBag.topScore = topScore;

            return View(students);
        }

        public ActionResult GlobalRazorHelper()
        {
            int topId = 0;
            int topScore = 0;

            foreach (var student in students)
            {
                student.Total = student.Chinese + student.Math + student.English;

                if (student.Total > topScore)
                {
                    topId = student.Id;
                    topScore = student.Total;
                }
            }

            ViewBag.topId = topId;
            ViewBag.topScore = topScore;

            return View(students);
        }
    }
}