using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace StationeryAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //config.Routes.MapHttpRoute(
            //    name: "shoppingItemName",
            //    routeTemplate: "api/{controller}/{itemName}",
            //    defaults: new { controller = "Shopping" }
            //);
        }
    }
}
