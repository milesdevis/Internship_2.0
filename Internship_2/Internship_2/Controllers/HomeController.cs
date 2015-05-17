using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Internship_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();                                  //This view has to be changed 
        }

        public ActionResult AboutUs()
        {
            
            return View();
        }

        public ActionResult HowItWorks()
        {
         
            return View();
        }

        public ActionResult Press()
        {

            return View();
        }

        public ActionResult Jobs()
        {

            return View();
        }

        public ActionResult Blog()
        {

            return View();
        }

        public ActionResult PrivacyPolicy()
        {

            return View();
        }

        public ActionResult ContactUs()
        {

            return View();
        }
    }
}