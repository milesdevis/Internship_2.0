using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Internship_2.Models;

namespace Internship_2.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public AccountController()
        {
        }

        public AccountController(ApplicationUserManager userManager, ApplicationSignInManager signInManager )
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set 
            { 
                _signInManager = value; 
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login()
        {
            
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        [ActionName("Buy")]
        public ActionResult BuyPost(
            string location,
            string make,
            string bodytype,
            string model)
        {
            return Redirect(@"~\" + location + "\\" + make + "\\" + bodytype + "\\" + model);
        }

        [HttpGet]
    public ActionResult Buy(
            string location,
            string make,
            string bodytype,
            string model)
    {
      //... actual code ...
            
        return View();    //Strong typed to BuyViewModel
    }
      


        [AllowAnonymous]
        public ActionResult Sell()
        {

            return View();
        }
    }
}