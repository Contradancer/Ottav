using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Ottav
{
    public class RouteConfig
    {
        // Separated Attribute Routes Register with the Traditional ones because of Unit Testing
        public static void RegisterRoutes(RouteCollection routes)
        {
            // Enable Attribute Routing
            //routes.MapMvcAttributeRoutes(); 
            RegisterTraditionalRoutes(routes);
        }

        public static void RegisterTraditionalRoutes(RouteCollection routes)
        {
            // Routes to be ignored 
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Valor",
            //    url: "{controller}/About/{valor}",
            //    defaults: new { controller = "Home", action = "Index" },
            //    constraints: new { productId = @"\d+" }
            //);

            // Default Route
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
                //constraints: new { controller = "Home|Settings|General|..." }
            );

            // Couldn't find a route to handle the request.  Show the 404 page.
            routes.MapRoute(
                name: "NotFound",
                url: "{*url}",
                defaults: new { controller = "Error", action = "PageNotFound" }
            );
        }
    }
}
