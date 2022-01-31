using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeDetails.Models;

namespace EmployeeDetails.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult GetDetails()
        {
            List<Employee> e = new List<Employee>()
            {
                new Employee{Id=1,Name="John",Salary=10000,IsPermanent=true},
                new Employee{Id=2,Name="Smith",Salary=5000,IsPermanent=false},
                new Employee{Id=3,Name="Mark",Salary=5000,IsPermanent=false},
                new Employee{Id=4,Name="Mary",Salary=5000,IsPermanent=false},
            };
            return View(e);
        }
    }
}
