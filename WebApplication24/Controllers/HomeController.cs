using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication24.Controllers
{
    //[LayoutData]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Foo = "foobar";
            ViewBag.person = new Person
            {
                Name = "Avrumi",
                Age = 37
            };

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}