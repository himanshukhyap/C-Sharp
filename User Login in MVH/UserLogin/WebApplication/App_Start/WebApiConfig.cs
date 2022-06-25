using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApplication
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            config.Routes.MapHttpRoute(
            name: "UserProfile",
                routeTemplate: "api/userdata/{action}/{id}",

                defaults: new { Controller = "UserProfile", id = RouteParameter.Optional });


//);
//            config.Routes.MapHttpRoute(
//name: "Owner",
//routeTemplate: "api/Owner/{action}/{id}",

//defaults: new { Controller = "Owner", id = RouteParameter.Optional }


//);
            //EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "*");
            //config.EnableCors(cors);
        }
    }
}
