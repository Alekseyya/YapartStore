using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace YapartStore.UI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Cars",
                url: "{controller}/{action}/{car}",
                defaults: new
                {
                    controller = "Catalog",
                    action = "Cars"
                }
            );

            routes.MapRoute(
                name: "Models",
                url: "{controller}/{action}/{car}/{model}",
                defaults: new
                {
                    controller = "Catalog",
                    action = "Cars"
                }
            );
            
            routes.MapRoute(
                name: "Accessories",
                url: "{controller}/{action}/{accessories}",
                defaults: new
                {
                    controller = "Catalog",
                    action = "Accessories"
                }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "AccessoriesAndMark",
                url: "{controller}/{action}/{accessories}/{mark}",
                defaults: new
                {
                    controller = "Catalog",
                    action = "Accessories",
                    accessories = UrlParameter.Optional,
                    mark = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "AccessoriesAndMarkAndModel",
                url: "{controller}/{action}/{accessories}/{mark}/{model}",
                defaults: new
                {
                    controller = "Catalog",
                    action = "Accessories",
                    accessories = UrlParameter.Optional,
                    mark = UrlParameter.Optional,
                    model = UrlParameter.Optional
                }
            );

           
            
        }
    }
}
