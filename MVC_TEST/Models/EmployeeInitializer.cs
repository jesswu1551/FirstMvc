using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_TEST.Models
{
    public class EmployeeInitializer : DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void Seed(EmployeeContext empContext)
        {
            //step1 以 List 建立員工資料
            List<Employee> employees = new List<Employee>
            {

new Employee { Id = 3, Name = "", Phone = "", Email = "", Department = "", Title = "" },
new Employee { Id = 4, Name = "", Phone = "", Email = "", Department = "", Title = "" },
new Employee { Id = 5, Name = "", Phone = "", Email = "", Department = "", Title = "" },
new Employee { Id = 6, Name = "", Phone = "", Email = "", Department = "", Title = "" },
new Employee { Id = 7, Name = "", Phone = "", Email = "", Department = "", Title = "" }
            };

            //step2 將 List 每筆資料加入 Entity Framework 的 Employee 中
            employees.ForEach(x => empContext.Employees.Add(x));

            //step3 儲存異動
            empContext.SaveChanges();
        }
    }
}
