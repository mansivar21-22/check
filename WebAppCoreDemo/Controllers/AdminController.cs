using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppCoreDemo.Models;
using System.Web;

namespace WebAppCoreDemo.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        //this is my custom view, that I have created  by myself
        public IActionResult Welcome()
        {
            List<Employee> lst = new List<Employee>() 
            {
            new Employee() { Empid = 5001, Empname = "Waseem", Empsalary = 50000 },
            new Employee() { Empid = 5002, Empname = "Akram", Empsalary = 55000 },
            new Employee() { Empid = 5003, Empname = "John", Empsalary = 65000 },
            new Employee() { Empid = 5004, Empname = "David", Empsalary = 52000 },
            new Employee() { Empid = 5005, Empname = "Sunil", Empsalary = 45000 }
        };
            
            //passing data from controller to the view*/
            return View(lst);

        }
    }
}
