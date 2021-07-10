using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;
namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var data = GetEmployee();
            return View(data);
        }
        private Employee GetEmployee()
        {
            return new Employee()
            {
                Id = 1, Name = "Rupali", Address = "India"


        };
        }
    }
}