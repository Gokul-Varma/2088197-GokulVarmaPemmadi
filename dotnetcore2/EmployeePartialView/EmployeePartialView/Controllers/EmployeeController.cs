using EmployeePartialView.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePartialView.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> e = new List<Employee>()
            {
                new Employee{Id=1 ,Name="Ben",Salary=15000,IsPermanent=true},
                new Employee{Id=2 ,Name="Naruto",Salary=20000,IsPermanent=false}
            };
            return View(e);
        }
    }
}
