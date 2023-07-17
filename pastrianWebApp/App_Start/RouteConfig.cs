using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace pastrianWebApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
          
            routes.MapRoute(
              name: "Default",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Account", action = "LogIn", id = UrlParameter.Optional }
          );

            routes.MapRoute(
                name: "Home",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Settings/Settings", 
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Settings", action = "Settings", id = UrlParameter.Optional }
                );

                routes.MapRoute(
                name: "Alkitab/Alkitab",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Alkitab", action = "Alkitab", id = UrlParameter.Optional }
                );
       
        }

            
    }
}
