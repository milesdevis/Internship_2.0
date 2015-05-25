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
            var model = new BuyViewModel();
            model.LocationFilter = GetLocations();
            model.MakeFilter = GetMakes();
            model.BodyTypeFilter = GetBodyTypes();
            model.ModelFilter = GetModels();

            return View(model);
        }

        private IEnumerable<SelectListItem> GetLocations()
        {
            List<SelectListItem> list = new List<SelectListItem>() {
                new SelectListItem(){ Value="1", Text="Bangalore"},
                new SelectListItem(){ Value="2", Text="Chennai"},
                new SelectListItem(){ Value="3", Text="Hyderabad"},
                new SelectListItem(){ Value="4", Text="Mumbai"},
            };

            return list;
        }

        private IEnumerable<SelectListItem> GetMakes()
        {
            List<SelectListItem> list = new List<SelectListItem>() {
                new SelectListItem(){ Value="1", Text="BMW"},
                new SelectListItem(){ Value="2", Text="AUDI"},
                new SelectListItem(){ Value="3", Text="JAGUAR"},
                new SelectListItem(){ Value="4", Text="BENTLY"},
            };

            return list;
        }

        private IEnumerable<SelectListItem> GetBodyTypes()
        {
            List<SelectListItem> list = new List<SelectListItem>() {
                new SelectListItem(){ Value="1", Text="SUV"},
                new SelectListItem(){ Value="2", Text="Convertible"},
                new SelectListItem(){ Value="3", Text="Sports"},
                new SelectListItem(){ Value="4", Text="Automatic"},
            };

            return list;
        }

        private IEnumerable<SelectListItem> GetModels()
        {
            List<SelectListItem> list = new List<SelectListItem>() {
                new SelectListItem(){ Value="1", Text="Blah"},
                new SelectListItem(){ Value="2", Text="Bloop"},
                new SelectListItem(){ Value="3", Text="Bleep"},
                new SelectListItem(){ Value="4", Text="BadumTish"},
            };

            return list;
        }


        [HttpPost]
        public ActionResult BrowseCars(BuyViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Send thequery to DB
            }
            return RedirectToAction("Index", "Buy", new
            {
                LocationID = model.SelectedLocationId,
                MakeID = model.SelectedMakeId,
                BodyTypeID = model.SelectedBodyTypeId,
                ModelID = model.SelectedModelId

            });
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