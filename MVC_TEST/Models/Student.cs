using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_TEST.Models
{
    public class Student
    {
        [Display(Name = "學生編號")]
        public int Id { get; set; }
        [Display(Name = "學生姓名")]
        public string Name { get; set; }
        [Display(Name = "國文分數")]
        public int Chinese { get; set; }
        [Display(Name = "數學分數")]
        public int Math { get; set; }
        [Display(Name = "英文分數")]
        public int English { get; set; }
        [Display(Name = "總分")]
        public int Total { get; set; }
    }
}