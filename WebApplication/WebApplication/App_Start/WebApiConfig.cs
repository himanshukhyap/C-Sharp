using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApplication
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

     /*       config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                
                defaults: new { id = RouteParameter.Optional }
           
            ) ;*/
            config.Routes.MapHttpRoute(
              name: "UserProfile",
              routeTemplate: "api/userdata/{action}/{id}",

              defaults: new { Controller = "UserProfile" ,  id = RouteParameter.Optional}
            

          );
            EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);
          // config.Formatters.Remove(config.Formatters.XmlFormatter);

            config.Routes.MapHttpRoute(
          name: "Values",
          routeTemplate: "api/Values/{action}/{id}",

          defaults: new { Controller = "Values", id = RouteParameter.Optional }

      );


        }
    }
}
