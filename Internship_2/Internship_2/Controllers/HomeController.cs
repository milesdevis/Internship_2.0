using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Internship_2.Models;

namespace Internship_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<SelectListItem> locations = new List<SelectListItem>();
            locations.Add(new SelectListItem { Text = "Bangalore", Value = "MyId1", Selected = true });
            locations.Add(new SelectListItem { Text = "Chennai", Value = "MyId2" });


            List<SelectListItem> makes = new List<SelectListItem>();
            makes.Add(new SelectListItem { Text = "Blah", Value = "MyId1", Selected = true });
            makes.Add(new SelectListItem { Text = "Bleh", Value = "MyId2" });

            List<SelectListItem> bodytypes = new List<SelectListItem>();
            bodytypes.Add(new SelectListItem { Text = "Bleep", Value = "MyId1", Selected = true });
            bodytypes.Add(new SelectListItem { Text = "Bloop", Value = "MyId2" });

            List<SelectListItem> models = new List<SelectListItem>();
            models.Add(new SelectListItem { Text = "Bing", Value = "MyId1", Selected = true });
            models.Add(new SelectListItem { Text = "Bang", Value = "MyId2" });

            var model = new BuyViewModel
            {
                _locations = locations,
                _makes = makes,
                _bodytypes = bodytypes,
                _models = models
            };

            return View(model);                                  //This view has to be changed 
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