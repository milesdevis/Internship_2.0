using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Internship_2.Models;

namespace Internship_2.Controllers
{
    public class BuyController : Controller
    {
        // GET: Buy
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult CityFilter()
        {
            return View();
        }

        public ActionResult BudgetRangeFilter()
        {
            return View();
        }

        public ActionResult YearRangeFilter()
        {
            return View();
        }

        public ActionResult MakeFilter()
        {
            return View();
        }

        public ActionResult ColorFilter()
        {
            return View();
        }

        public ActionResult KMRangeFilter()
        {
            return View();
        }

    }
}