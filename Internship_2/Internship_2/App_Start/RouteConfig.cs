using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Internship_2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(null,
            "{loaction}/{make}/{bodytype}/{model}",  

              new RouteValueDictionary
                {{"loaction", "Bangalore"},
                {"make","Blah"},            //DEFAULTS SUBJECT TO CHANGE           
                {"bodytype","Bleep"},        //MODIFY THIS
                {"model", "Bing"}},
            
                new
            {
                controller = "Account",
                Action = "Buy",
              
            }
                );
        }
    }
}
