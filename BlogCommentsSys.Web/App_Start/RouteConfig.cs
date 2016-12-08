﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BlogCommentsSys.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            /*
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Home", id = UrlParameter.Optional }
            );
            */

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "BlogCommentsSys.Web.Controllers" }
            );

            /*
            routes.MapRoute(
               name: "Default",
               url: "api/{controller}/{action}/{id}",
               defaults: new { action = "Index", id = UrlParameter.Optional },
               namespaces: new string[] { "BlogCommentsSys.Web.Controllers" }
           );

            routes.MapRoute(
                name: "UserRoute",
                url: "{user}/{controller}/{action}/{id}",
                defaults: new { user = "viktor", controller = "Posts", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "BlogCommentsSys.Web.Controllers" }
            );
            */
        }
    }
}
