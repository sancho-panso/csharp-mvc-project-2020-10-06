using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _2020_10_06_MVC.Models;

namespace _2020_10_06_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult About(string id)
        //{
        //    ViewData["Message"] = $" it is message from id = {id}";

        //    return View();
        //}

        //public IActionResult About(string name, string surname)
        //{
        //    Person me = new Person(name, surname);
        //    return View(me);
        //}

        //public IActionResult About(Person me)
        //{
        //    return View(me);
        //}

        public IActionResult About(int limit)
        {
            var list = new List<Person>
            {
                new Person() { Name= "Tomas", Surname ="Tomaitis"},
                new Person() { Name= "Mantas", Surname ="Mantaitis"},
                new Person() { Name= "Sigis", Surname ="Sigaitis"},

            };
            return View(list.Take(limit).ToList());
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
