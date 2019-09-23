using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comp2084_lab2.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(string category)
        {

            ViewBag.category = "You selected category: " + category;
            return View();
        }
    }
}