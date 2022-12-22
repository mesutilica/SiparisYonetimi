﻿using System.Web.Mvc;
using System.Web.Routing;

namespace SiparisYonetimi.MVCUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes(); // Attribute Route kullanabilmek için
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new[] { "SiparisYonetimi.MVCUI.Controllers" }
            );
        }
    }
}
