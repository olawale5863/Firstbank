using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FIRSTBANKOFNIGERIA.Models;

namespace FIRSTBANK.Controllers
{
    public class HomeController : Controller
    {
        FintrakAcademyContext context = new FintrakAcademyContext();

        public CustomerInformation Customer { get; private set; }

        //To get customer information
        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }
        //to add customer information
        [HttpPost]
        public IActionResult AddCustomer(CustomerInformation customer)
        {
            context.CustomerInformation.Add(Customer);
            context.SaveChanges();
            return View();
        }
        [HttpGet]
        public JsonResult GetCustomer()
        {
            var result = context.CustomerInformation.ToList();
            return Json(result);
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string FirstName)
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

    }
}
