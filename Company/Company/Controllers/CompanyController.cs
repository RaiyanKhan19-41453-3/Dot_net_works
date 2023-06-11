using Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Company.Controllers
{
    public class CompanyController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Teams()
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee()
            {
                emp_name = "Raiyan",
                emp_age = "22",
                expertise = "Programmer"
            });
            employees.Add(new Employee()
            {
                emp_name = "Rafsan",
                emp_age = "11",
                expertise = "Medic"
            });
            employees.Add(new Employee()
            {
                emp_name = "Ramjan",
                emp_age = "40",
                expertise = "Manager"
            });
            ViewBag.Employees = employees;

            return View(employees);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = "";

            return View();
        }
    }
}