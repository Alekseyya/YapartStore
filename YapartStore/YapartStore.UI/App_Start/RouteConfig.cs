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
                name: "Default",
                url: "{controller}/{action}",
                defaults: new
                {
                    controller = "Home",
                    action = "Index"
                }
            );

            routes.MapRoute(
                name: "AllCars",
                url: "{controller}/Cars",
                defaults: new
                {
                    controller = "Catalog",
                    action = "AllCars"
                }
            );

            routes.MapRoute(
                name: "CarsAndCarAndModel",
                url: "{controller}/Cars/{car}/{model}",
                defaults: new
                {
                    controller = "Catalog",
                    action = "Cars",
                    car = UrlParameter.Optional,
                    model = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "AllAccessories",
                url: "{controller}/Accessories",
                defaults: new
                {
                    controller = "Catalog",
                    action = "AllAccessories"
                }
            );

            routes.MapRoute(
                name: "Accessories",
                url: "{controller}/Accessories/{mark}/{model}/{modification}",
                defaults: new
                {
                    controller = "Catalog",
                    action = "Accessories",
                    mark = UrlParameter.Optional,
                    model = UrlParameter.Optional,
                    modification = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "CurrentAccessories",
                url: "{controller}/{accessories}/{mark}/{model}/{modification}",
                defaults: new
                {
                    controller = "Catalog",
                    action = "CurrentAccessories",
                    accessories = UrlParameter.Optional,
                    mark = UrlParameter.Optional,
                    model = UrlParameter.Optional,
                    modification = UrlParameter.Optional
                }
            );
            
        }
    }
}
