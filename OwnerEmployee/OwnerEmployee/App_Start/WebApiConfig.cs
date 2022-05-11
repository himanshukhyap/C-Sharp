using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace OwnerEmployee
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
            config.Routes.MapHttpRoute(
name: "OwnerApi",
routeTemplate: "api/ownerdata/{action}/{id}",

            defaults: new { Controller = "Owner", id = RouteParameter.Optional }


            );
            config.Routes.MapHttpRoute(
name: "EmployeeAPI",
routeTemplate: "api/employee/{action}/{id}",

       defaults: new { Controller = "Employee", id = RouteParameter.Optional }


       );


            EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            //EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "*");
            //config.EnableCors(cors);
        }
    }
}
