using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AgileLizard.Site
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "robots",
                url: "robots.txt",
                defaults: new { controller = "Seo", action = "Robots" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "Error", // Route name
                "{controller}/{action}/{aspxerrorpath}", // URL with parameters
                new { controller = "Error", action = "GenericError", aspxerrorpath = UrlParameter.Optional }
            );

        }
    }
}
